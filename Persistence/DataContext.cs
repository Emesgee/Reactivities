using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence


{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // this is going to represent the table name inside the table we have just created.
        public DbSet<Activity> Activities { get; set; }   
    }
}
