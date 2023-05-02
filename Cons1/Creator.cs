
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

internal class ClassCreator
{


public static Student Student()
{
    {
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine() ?? "";
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите отчество: ");
        string patronimyc = Console.ReadLine() ?? "";
        DateOnly dateOfBirth;
        Console.WriteLine("Введите дату рождения в формате дд.мм.гггг");
        while (DateOnly.TryParse(Console.ReadLine(), out dateOfBirth)) ;
        return new Student(name, surname, patronimyc, Group(), dateOfBirth);
    }
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
    public static Auditory Auditory()
    {
        return new Auditory();
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
