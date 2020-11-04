using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Library.Models
{
    public class Book
    {
        [Required] public Author Author { get; set; }
        [Required] public Genre Genre { get; set; }
        [Key] public int ISBN { get; set; }
        [Required, MaxLength(100)] public string Title { get; set; }
        [Required] public int TotalPages { get; set; }
        [Required] public DateTime PublishDate { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }
}