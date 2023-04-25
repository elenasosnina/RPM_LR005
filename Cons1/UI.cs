using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class UI
{
    public static void Print(Group group)
    {
        Console.WriteLine("Group");
        Console.WriteLine(group.Name);
        Console.WriteLine(group.Sokr);
        Console.WriteLine(group.Population);
        Console.WriteLine(group.Year);
        Print(group.Teacher);
        Print(group.Speciality);
    }
    public static void Print(Speciality speciality)
    {
        Console.WriteLine(speciality);
    }
    public static void Print(Teacher teacher)
    {
        Console.WriteLine(teacher);
    }
}

