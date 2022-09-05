using InAndOut.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOut.Data
{
    // i.e the class is inheriting from dbContext,
    // this class put together all our models so that we can use them with the database 
    public class ApplicationDbContext :DbContext
    {
        // pass dbcontext options into the constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           

        } 
        // Item is the entity, items serve as the table in the db
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; } 
    }
}
