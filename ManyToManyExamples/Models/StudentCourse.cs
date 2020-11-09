using System.Text.Json;

namespace ManyToManyExamples.Models
{
    public class StudentCourse
    {
        public int StudentNum { get; set; }
        public Student Student { get; set; }
        public string CourseCode { get; set; }
        public Course Course { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }
    }
}