namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
              Name ="Orxan",
              Surname = "Aslanov",
              Age=25,
              Group ="P327",
              

            
            };

            Console.WriteLine(student.GetStudentFullName());
            student.GetStudent();
            student.GetGrade();
        }
        
    }
}