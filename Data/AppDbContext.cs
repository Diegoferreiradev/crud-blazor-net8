using CrudBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBlazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;
    }
}
