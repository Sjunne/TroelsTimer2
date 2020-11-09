using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ManyToManyExamples.Models
{
    public class Course
    {
   
            [Key]
            public string CourseCode { get; set; }
            public string Abbreviation { get; set; }
            public string Name { get; set; }
            public int ECTS { get; set; }
            public int Semester { get; set; }
            [JsonIgnore]
            public IList<StudentCourse> StudentCourses { get; set; }
        
            public override string ToString()
            {
                return JsonSerializer.Serialize(this, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            }
    }
}