using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc363.Models
{
    [Table("Person")]
    public class Person
    {
        [Key] 
        public int PersonId { get; set; }
        
        public string? FullName { get; set; }
        
        public string? Address { get; set; }
    }
}