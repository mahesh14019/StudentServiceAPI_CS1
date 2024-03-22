using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StudentService.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        //public List<Student> Students { get; set; }
        [JsonIgnore]
        public int StudentId { get; set;}
        [JsonIgnore]
        public virtual Student Student { get; set;}
    }
}
