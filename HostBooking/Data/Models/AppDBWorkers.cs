using Microsoft.EntityFrameworkCore;

namespace HostBooking.Data.Models
{
    public class AppDBWorkers: DbContext
    {
        public DbSet<Workers> Blogs { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=DBWorkers;Username=postgres;Password=98909890");
    }
}