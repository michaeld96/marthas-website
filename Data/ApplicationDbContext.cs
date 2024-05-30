using Microsoft.EntityFrameworkCore;
namespace marthas_website.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ArtPieces> ArtPieces { get; set; }
    }
}