using System.ComponentModel.DataAnnotations;

namespace aspcoredemo.Models
{
    public class table1
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string department { get; set; }

        [Required]
        public string mobile { get; set; }

        
    }
}
