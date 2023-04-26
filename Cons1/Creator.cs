using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassCreator
{
    public static Auditory Auditory()
    {
        Console.Write("Введите название: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите кол-во посадочных мест: ");
        byte mest = Convert.ToByte(Console.ReadLine() ?? "");
        Console.Write("Введите кол-во окон: ");
        byte window = Convert.ToByte(Console.ReadLine() ?? "");
        return new Auditory(name, Employee(), mest, window, Equipment());
    }
    public static Employee Employee()
    {
        return new Employee();
    }

    public static Equipment Equipment()
    {
        return new Equipment();
    }
}