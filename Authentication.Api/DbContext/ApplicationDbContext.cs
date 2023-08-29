using Authentication.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Authentication.Api.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,Guid> 

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
         
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("ApplicationUsers", "Security");
            builder.Entity<ApplicationRole>().ToTable("ApplicationRoles", "Security");
        }

    }
}
