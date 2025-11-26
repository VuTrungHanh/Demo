using System.ComponentModel.DataAnnotations;

namespace DemoMvc363.Models
{
    public class Student
    {
        [Key]
        [Required(ErrorMessage = "Mã sinh viên không được để trống")]
        public int StudentCode  { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống")]
        public string? FullName { get; set; }
    }
}
