using System.ComponentModel.DataAnnotations;

namespace FormApp.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public int? Age { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Hometown { get; set; } = string.Empty;
    }
}
