using Microsoft.EntityFrameworkCore;
using BelotConsoleApp.Data.Models;
namespace BelotConsoleApp.Data
{
    public class BelotDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=belot.db");
    }
}