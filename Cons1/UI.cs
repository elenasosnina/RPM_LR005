using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class UI
{
    public static void Print(Auditory auditory)
    {
        Console.WriteLine(auditory.Name);
        Console.WriteLine(auditory.Mest);
        Console.WriteLine(auditory.Window);
        Print(auditory.Employee);
        Print(auditory.Equipment);
    }
    public static void Print(Employee employee)
    {
        Console.WriteLine(employee);
    }

    public static void Print(Equipment equipment)
    {
        Console.WriteLine(equipment);
    }
}

