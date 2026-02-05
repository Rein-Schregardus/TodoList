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
                @"Host=db;Port=5432;Username=postgres;Password=postgres;Database=postgres");
        }
    }
}
