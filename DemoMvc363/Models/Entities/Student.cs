namespace DemoMvc363.Models.Entities
{
    public class Student
    {
        public string StudentCode { get; set; }
        public string FullName { get; set; }
        public void EnterData()
        {
            System.Console.Write("Full name = ");
            FullName = Console.ReadLine();
            System.Console.Write("Student Code = ")
            StudentCode = Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1}", FullName, StudentCode);
        }
    }
}