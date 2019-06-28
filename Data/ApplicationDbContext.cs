using System;
using System.Collections.Generic;
using System.Text;
using MCTCTicketSystem2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Platform> Platform { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<Ticket>()
                .Property(b => b.DateSubmit)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Ticket>()
                .Property(b => b.DateCompleted)
                .HasDefaultValueSql("GETDATE()");

            ApplicationUser user = new ApplicationUser
            {
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                isAdmin = true,
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    Label = "Grammatical Errors",
                    Rating = 2
                },
                new Category()
                {
                    CategoryId = 2,
                    Label = "Missing/Out Of Date Content",
                    Rating = 3
                },
                new Category()
                {
                    CategoryId = 3,
                    Label = "Broken Link",
                    Rating = 4
                },
                new Category()
                {
                    CategoryId = 4,
                    Label = "Webpage Unresponsive/Not Loading",
                    Rating = 5
                },
                new Category()
                {
                    CategoryId = 5,
                    Label = "Other",
                    Rating = 1
                }
            );

            modelBuilder.Entity<Platform>().HasData(
                new Platform()
                {
                    PlatformId = 1,
                    Label = "PC"
                },
                new Platform()
                {
                    PlatformId = 2,
                    Label = "Mobile"
                },
                new Platform()
                {
                    PlatformId = 3,
                    Label = "Mac"
                }
            );
        }
    }
}