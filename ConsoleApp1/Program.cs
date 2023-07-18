using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Ismayil", "Seyyidmemmedli", 26, "UML");
        List<Student> students = new List<Student>() 
        { 
            new Student("Elgun","Haqverdiyev",19,12)
        };
        Group group = new Group("FBMS_2_22_3",teacher,students);

        Console.WriteLine(group.ToString());
    }
}