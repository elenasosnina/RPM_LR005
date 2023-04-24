using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassCreator
{
    public static Group Group()
    {
        Console.Write("Введите название группы: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите сокращённое название группы: ");
        string sokr = Console.ReadLine() ?? "";
        Console.Write("Введите численность группы: ");
        int chisl = Convert.ToInt16(Console.ReadLine() ?? "25");
        Console.Write("Введите год поступления группы: ");
        int? year = Convert.ToInt32(Console.ReadLine());

        return new Group(name, sokr, chisl, year, Speciality(), ClassTeacher());

    }
    public static ClassTeacher ClassTeacher()
    {
        return new ClassTeacher();
    }

    public static Speciality Speciality()
    {
        return new Speciality();
    }
}