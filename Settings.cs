Namespace MyApp
{
    public class Settings
    {
        public string DatabaseConnectionString { get; set; }
        public int MaxItemsToDisplay { get; set; }
        public bool EnableLogging { get; set; }
        public Settings()
        {
            // Default values
            DatabaseConnectionString = "Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;";
            MaxItemsToDisplay = 100;
            EnableLogging = true;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Settings appSettings = new Settings();
        Console.WriteLine("Database Connection String: " + appSettings.DatabaseConnectionString);
        Console.WriteLine("Max Items to Display: " + appSettings.MaxItemsToDisplay);
        Console.WriteLine("Enable Logging: " + appSettings.EnableLogging);
    }
}

public class Settings
{
    public string DatabaseConnectionString { get; set; }
    public int MaxItemsToDisplay { get; set; }
    public bool EnableLogging { get; set; }
    public Settings()
    {
        // Default values
        DatabaseConnectionString = "Server=localhost;Database=mydb;User Id=myuser;Password=mypassword;";
        MaxItemsToDisplay = 100;
        EnableLogging = true;
    }
}

class Students{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public Students(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}
class Teacher { 
    public string Name { get; set; }
    public string Subject { get; set; }
    public Teacher(string name, string subject)
    {
        Name = name;
        Subject = subject;
    }
}
class Course
{
    public string CourseName { get; set; }
    public Teacher CourseTeacher { get; set; }
    public List<Students> EnrolledStudents { get; set; }
    public Course(string courseName, Teacher courseTeacher)
    {
        CourseName = courseName;
        CourseTeacher = courseTeacher;
        EnrolledStudents = new List<Students>();
    }
    public void EnrollStudent(Students student)
    {
        EnrolledStudents.Add(student);
    }
}

class Class {
    public string ClassName { get; set; }
    public List<Course> Courses { get; set; }
    public Class(string className)
    {
        ClassName = className;
        Courses = new List<Course>();
    }
    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
}
// END