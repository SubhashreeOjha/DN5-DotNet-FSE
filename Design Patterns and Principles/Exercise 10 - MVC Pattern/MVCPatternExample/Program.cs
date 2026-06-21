using System;

// Model
public class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Grade { get; set; }

    public Student(string name, int id, string grade)
    {
        Name = name;
        Id = id;
        Grade = grade;
    }
}

// View
public class StudentView
{
    public void DisplayStudentDetails(Student student)
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("----------------");
        Console.WriteLine("Name  : " + student.Name);
        Console.WriteLine("ID    : " + student.Id);
        Console.WriteLine("Grade : " + student.Grade);
    }
}

// Controller
public class StudentController
{
    private Student model;
    private StudentView view;

    public StudentController(Student model, StudentView view)
    {
        this.model = model;
        this.view = view;
    }

    public void SetStudentName(string name)
    {
        model.Name = name;
    }

    public void SetStudentGrade(string grade)
    {
        model.Grade = grade;
    }

    public void UpdateView()
    {
        view.DisplayStudentDetails(model);
    }
}

class Program
{
    static void Main()
    {
        Student student =
            new Student("Subhashree", 101, "A");

        StudentView view =
            new StudentView();

        StudentController controller =
            new StudentController(student, view);

        controller.UpdateView();

        Console.WriteLine("\nAfter Update:\n");

        controller.SetStudentName("Subhashree Ojha");
        controller.SetStudentGrade("A+");

        controller.UpdateView();
    }
}