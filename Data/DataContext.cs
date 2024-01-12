
using Microsoft.EntityFrameworkCore;
using RasuliEDatabase.Models;

namespace RasuliEDatabase.Data
{
    public class DataContext : DbContext // Class to represent database. Sets up data functionality
    {
        public DbSet<Student> Students {get; set;}
        // : Base inherits from the base class
        public DataContext(DbContextOptions<DataContext> o) : base(o)
        {
            
        }
    }
}