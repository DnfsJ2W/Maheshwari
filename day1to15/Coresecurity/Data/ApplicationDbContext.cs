using Coresecurity.Areas.Admin.Models;
using Coresecurity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coresecurity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Application> application { get; set; }

    }
}
