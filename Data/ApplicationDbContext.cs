using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniEat.Models;

namespace UniEat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<LunchPosting> LunchPostss { get; set; }
        public DbSet<DishesDbModel> DishesDatabase { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
