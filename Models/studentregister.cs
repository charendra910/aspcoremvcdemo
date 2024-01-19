using System.ComponentModel.DataAnnotations;

namespace aspcoredemo.Models
{
    public class studentregister
    {
        [Key]
        public int student_enroll { get; set; }
        [Required]
        public string studentname { get; set; }
        [Required]
        public string branch { get; set; }
    
    }
}
