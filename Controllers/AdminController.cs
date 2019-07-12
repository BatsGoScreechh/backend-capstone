using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MCTCTicketSystem2.Data;
using MCTCTicketSystem2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace MCTCTicketSystem2.Controllers
{
    public class AdminController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Tickets
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();


            if (user.isAdmin == false)
            {

                return NotFound();

            }
            if (user.isAdmin == true)
            {
                var applicationDbContext = _context.Ticket.Include(o => o.User).Include(o => o.currentCategory).Include(o => o.currentPlatform);

                return View(await applicationDbContext.ToListAsync());
            }

                return View();
          
        }

        // GET: Tickets/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket.Include(o => o.User).Include(o => o.currentCategory).Include(o => o.currentPlatform)
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        [Authorize]
        public IActionResult Create()
        {
            Ticket ticketModel = new Ticket();
            SelectList ticketCategories = new SelectList(_context.Category, "CategoryId", "Label");
            SelectList ticketPlatforms = new SelectList(_context.Platform, "PlatformId", "Label");
            SelectList ticketCategories0 = CategoryDropdown(ticketCategories);
            SelectList ticketPlatforms0 = PlatformDropdown(ticketPlatforms);
            ticketModel.Categories = ticketCategories0;
            ticketModel.Platforms = ticketPlatforms0;

            return View(ticketModel);
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Description,CategoryId,PlatformId, currentPlatform, currentCategory,Title,isActive")] Ticket ticket)
        {
            ModelState.Remove("UserId");
            ModelState.Remove("User");
            if (ModelState.IsValid)
            {
                var currentUser = await GetCurrentUserAsync();
                ticket.DateCompleted = null;
                ticket.UserId = currentUser.Id;
                ticket.isActive = true;
                ticket.activeMessage = "Open";
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                Task.WaitAll(Task.Delay(5000));
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", ticket.UserId);
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }




            var ticket = await _context.Ticket.FindAsync(id);
            SelectList ticketCategories = new SelectList(_context.Category, "CategoryId", "Label");
            SelectList ticketPlatforms = new SelectList(_context.Platform, "PlatformId", "Label");
            SelectList ticketCategories0 = CategoryDropdown(ticketCategories);
            SelectList ticketPlatforms0 = PlatformDropdown(ticketPlatforms);
            ticket.Categories = ticketCategories0;
            ticket.Platforms = ticketPlatforms0;

            ApplicationUser user = await GetCurrentUserAsync();
            user.Id = ticket.UserId;
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id,
            [Bind("TicketId,Description,PlatformId,CategoryId,DateSubmit,currentPlatform,currentCategory, isActive, AdminComment,Title")] Ticket ticket)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            id = ticket.TicketId;

            if (ModelState.IsValid)
            {
                ticket.isActive = true;
                ticket.activeMessage = "Open";

                try
                {
                    ApplicationUser user = await GetCurrentUserAsync();
                    ticket.UserId = user.Id;

                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.TicketId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = ticket.TicketId });

            }
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket.Include(o => o.User).Include(o => o.currentCategory).Include(o => o.currentPlatform)
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Ticket.FindAsync(id);

            if (ticket.isActive == true)
            {
                ticket.isActive = false;
                ticket.activeMessage = "Closed";
                ticket.DateCompleted = DateTime.Now;

            }
            _context.Ticket.Update(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.TicketId == id);
        }


        public static SelectList CategoryDropdown(SelectList selectList)
        {

            SelectListItem firstItem = new SelectListItem()
            {
                Text = "Select a Category"
            };
            List<SelectListItem> newList = selectList.ToList();
            newList.Insert(0, firstItem);

            var selectedItem = newList.FirstOrDefault(item => item.Selected);
            var selectedItemValue = String.Empty;
            if (selectedItem != null)
            {
                selectedItemValue = selectedItem.Value;
            }

            return new SelectList(newList, "Value", "Text", selectedItemValue);
        }
        public static SelectList PlatformDropdown(SelectList selectList)
        {

            SelectListItem firstItem = new SelectListItem()
            {
                Text = "Select a Platform"
            };
            List<SelectListItem> newList = selectList.ToList();
            newList.Insert(0, firstItem);

            var selectedItem = newList.FirstOrDefault(item => item.Selected);
            var selectedItemValue = String.Empty;
            if (selectedItem != null)
            {
                selectedItemValue = selectedItem.Value;
            }

            return new SelectList(newList, "Value", "Text", selectedItemValue);
        }

        public IActionResult Line()
        {

        //list of countries  
       
        var lstModel = new List<SimpleReportViewModel>();
        lstModel.Add( new SimpleReportViewModel  
           {  
               DimensionOne = "Brazil",  
               Quantity = 10  
           } );  
           lstModel.Add( new SimpleReportViewModel  
           {  
               DimensionOne = "USA",  
               Quantity = 6  
           } );  
           lstModel.Add( new SimpleReportViewModel  
           {  
               DimensionOne = "Portugal",  
               Quantity = 4  
           } );  
           lstModel.Add( new SimpleReportViewModel  
           {  
               DimensionOne = "Russia",  
               Quantity = 7  
           } );  
           lstModel.Add( new SimpleReportViewModel  
           {  
               DimensionOne = "Ireland",  
               Quantity = 9 
           } );  
           lstModel.Add( new SimpleReportViewModel  
           {  
               DimensionOne = "Germany",  
               Quantity = 1
           } );  
           return View(lstModel );  
       }  
    }

}
