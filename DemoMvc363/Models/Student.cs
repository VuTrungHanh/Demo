using System.ComponentModel.DataAnnotations;

namespace DemoMvc363.Models
{
    public class Student
    {
        [Key]
        public int StudentCode  { get; set; }
        public string? FullName { get; set; }
    }
}
