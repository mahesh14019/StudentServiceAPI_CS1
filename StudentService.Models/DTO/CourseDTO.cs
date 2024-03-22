using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StudentService.Models.DTO
{
    public class CourseDTO
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }        
    }
}
