using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc363.Models
{
    public class Employee
    {
        [Key]
    public int EmployeeId { get; set;}
    public string? FullName { get; set;}
    public string? Address { get; set;}
    }
}
