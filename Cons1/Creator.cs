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


    public static Lesson Lesson()
    {
        return new Lesson(
            DateTime.Now,
            Pair(),
            Group(),
            Employee(),
            TypeLesson(),
            Discipline(),
            Auditory());
    }
    public static TypeLesson TypeLesson()
    {
        return new TypeLesson();
    }

    public static Discipline Discipline()
    {
        return new Discipline();
    }

    public static Employee Employee()
    {
        return new Employee();
    }


    public static Equipment Equipment()
    {
        return new Equipment();
    }
    public static Pair Pair()
    {
        return new Pair();
    }
    public static Group Group()
    {
        Console.Write("Введите название группы: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите сокращённое название группы: ");
        string sokr = Console.ReadLine() ?? "";
        Console.Write("Введите численность группы: ");
        byte population = Convert.ToByte(Console.ReadLine() ?? "25");
        Console.Write("Введите год поступления группы: ");
        ushort year = Convert.ToUInt16(Console.ReadLine());

        return new Group(name, sokr, population, year, Speciality(), Teacher());

    }
    public static Teacher Teacher()
    {
        return new Teacher();
    }

    public static Speciality Speciality()
    {
        return new Speciality();
    }
}