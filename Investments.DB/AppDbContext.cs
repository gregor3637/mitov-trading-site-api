using Microsoft.EntityFrameworkCore;

namespace Investments.DB
{
    public class AppDbContext: DbContext
    {
        public DbSet<Investment>Investments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=InvestmentsDB;Integrated Security=True");
        }
    }
}
