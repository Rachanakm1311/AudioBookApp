using System.ComponentModel.DataAnnotations;

namespace AudioBookApp.Models
{
    public class AudioBook
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Author { get; set; }

        public string? Description { get; set; }

        public string? Category { get; set; }

        public string? PdfFilePath { get; set; }
    }
}