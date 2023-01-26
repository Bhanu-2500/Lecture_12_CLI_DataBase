using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

using (var db = new DataBaseContext())
{
    Console.WriteLine("Student Name  List -->\n");
    var students = db.Students;
    foreach (var student in students)
    {
        Console.Write(student.Id);
        Console.Write(")  -- ");
        Console.WriteLine(student.Name);
    }
    Console.WriteLine("\n");
    Console.WriteLine("Advisor Group List -->\n");

    var teachers = db.Teachers.Include(t=>t.Students);
    foreach(var t in teachers)
    {
        Console.WriteLine(t.Name);
        foreach(var s in t.Students)
        {
            Console.WriteLine($"  -->{s.Name}");
        }
        Console.WriteLine("\n");

    }
}