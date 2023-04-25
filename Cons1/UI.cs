usingusing ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class UI
{
    public static void Print(Student student)
    {
        Console.WriteLine(student.Name);
        Console.WriteLine(student.S_name);
        Console.WriteLine(student.P_name);
        Console.WriteLine(student.Date);
        Print(student.Group);
    }

    public static void Print(Group group)
    {
        Console.WriteLine(group);
    }
}