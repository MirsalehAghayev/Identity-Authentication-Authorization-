using fiorello_project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using p323.Models;

namespace fiorello_project.DAL
{
    public class AppDbContext :IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> productPhotos { get; set; }
        public DbSet<ObijectiveComponent> ObijectiveComponents { get; set; }    
    }
}
