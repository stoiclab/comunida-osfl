using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using comunida.Models;

namespace comunida.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<PersonOrganizationInterest> UserOrganizationInterest { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Organization>().ToTable("Organization");
            builder.Entity<Calendar>().ToTable("Calendar");
            builder.Entity<Interest>().ToTable("Interest");
        }

        public DbSet<comunida.Models.Person> Person { get; set; }


        
    }
}
