using StudentEnrollment.Services;

namespace StudentEnrollment;

internal class ConsoleUI
{
    private readonly StudentService _studentService;

    public ConsoleUI(StudentService studentService)
    {
        _studentService = studentService;
    }

    //en metod
    public void CreateStudent_UI()
    {
        Console.Clear();
        Console.WriteLine("---- CREATE STUDENT ----");

        Console.Write("Student's First Name: ");
        var firstName = Console.ReadLine();

        Console.Write("Student's Last Name: ");
        var lastName = Console.ReadLine();

        Console.Write("Birthdate (yyyy-MM-dd: ");
        var dateOfBirth = DateTime.TryParse(Console.ReadLine(), out DateTime birthDate);

        Console.Write("Grade: ");
        var studentGrade = int.TryParse(Console.ReadLine(), out int grade);

        var result = _studentService.CreateStudent(firstName, lastName, birthDate, grade);

        if (result != null)
        {
            Console.Clear();
            Console.WriteLine("Student was created.");
            Console.ReadKey();

        }
    }


}
