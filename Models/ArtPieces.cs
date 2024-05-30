using Microsoft.EntityFrameworkCore;
namespace marthas_website.Models
{
public class ArtPieces
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}