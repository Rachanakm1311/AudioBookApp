using Microsoft.EntityFrameworkCore;
using AudioBookApp.Models;

namespace AudioBookApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AudioBook> AudioBooks { get; set; }
    }
}