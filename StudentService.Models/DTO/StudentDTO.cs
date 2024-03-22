using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace StudentService.Models.DTO
{
    public class StudentDTO
    {
        [Key]
        [JsonIgnore]
        public int StudentId { get; set; }
        
        [Required(ErrorMessage ="Roll No is required")]
        [DisplayName("RollNo")]
        public string RollNo { get; set; }
        
        [RegularExpression("[a-zA-Z]+$",ErrorMessage ="Please enter valid Student Name")]
        [DisplayName("SName")]
        public string SName { get; set; }
        
        [Required(ErrorMessage = "College Name is required")]
        [DisplayName("CollegeName")]
        public string CollegeName { get; set; }
        
        [Required(ErrorMessage = "Mobile is required")]
        [StringLength(10,ErrorMessage = "Mobile must be 10 digit")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Mobile must be numeric")]
        [DisplayName("Mob")]
        public string Mob { get; set; }
        
        [Range(0,100,ErrorMessage = "Marks must be between 0 and 100"),]
        [DisplayName("PercentageMarks")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PercentageMarks { get; set; }
    }
}
