using System.ComponentModel.DataAnnotations;

namespace aspcoredemo.Models
{
    public class studentregister
    {
        [Key]

        public int student_id { get; set; }
        [Required]
        public string student_name { get; set; }
        [Required]
        public string student_email { get; set; }
        [Required]

        public string student_branch { get; set; }
        [Required]
        public string student_division { get; set; }
    
    }
}
