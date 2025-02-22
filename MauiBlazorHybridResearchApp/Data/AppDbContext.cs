using Microsoft.EntityFrameworkCore;

namespace MauiBlazorHybridResearchApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define your DB sets here
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}
