using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdvancedTodo.Models
{
    public class Todo {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        [JsonPropertyName("UserId")]
        public int UserId { get; set; }
        [JsonPropertyName("TodoId")]
        public int TodoId { get; set; }
        [Required, MaxLength(128)]
        [JsonPropertyName("Title")]    
        public string Title { get; set; }
        [JsonPropertyName("IsCompleted")]
        public bool IsCompleted { get; set; }

  }

}