
using System.ComponentModel.DataAnnotations;

namespace studentdb_06_06_2023_entity.Models
{
    public class Student
    {
        [key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address{ get; set; }
        [Required]
        public string department { get; set; }
    }
}
