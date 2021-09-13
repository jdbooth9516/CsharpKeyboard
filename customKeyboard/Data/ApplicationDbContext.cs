using customKeyboard.Configuration;
using customKeyboard.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace customKeyboard.Data
{
    public class ApplicationDbContext : IdentityDbContext<User> 
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        // add the various models here but not the user. 
       
        public DbSet<Products> Products { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}