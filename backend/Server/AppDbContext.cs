using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server
{
    public class AppDbContext: DbContext
    {

        public DbSet<Todo> Todos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                @"Host=http://localhost:7200;Username=postgres;Password=postgres;Database=mydatabase");
        }
    }
}
