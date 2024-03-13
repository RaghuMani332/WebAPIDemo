
using Microsoft.EntityFrameworkCore;

namespace WebAPIDemo.Models.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        const String server = "Server=RAGHU\\SQLEXPRESS;Database=Dresses;TrustServerCertificate=True;Trusted_Connection=True;";

        public DbSet<Shirt> Dress { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(server);
        }
    }
}
