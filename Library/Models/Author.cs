using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Library.Models
{
    public class Author
    {
        [Key, MaxLength(4)] public int AuthorId { get; set; }
        [Required, MaxLength(100)] public string FirstName { get; set; }
        [Required, MaxLength(100)] public string LastName { get; set; }
        [MaxLength(255)] public string Bio { get; set; }
        
        public override string ToString() =>
            JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
    }
}