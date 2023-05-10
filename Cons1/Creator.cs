using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

    public static Student Student()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine() ?? "";
        Console.Write("Введите отчество: ");
        string patronimyc = Console.ReadLine() ?? "";
        Console.WriteLine("Введите дату рождения: ");
        DateTime date = CreateDateTime();

        return new Student(name,surname, patronimyc, Group(), date);
    }

    static DateTime CreateDateTime()
    {
        Console.Write("Введите год: ");
        _ = int.TryParse(Console.ReadLine(), out int year);
        Console.Write("Введите месяц: ");
        _ = int.TryParse(Console.ReadLine(), out int month);
        Console.Write("Введите день: ");
        _ = int.TryParse(Console.ReadLine(), out int day);

        return new DateTime(year, month, day);
    }

    public static Lesson Lesson()
    {
        return new Lesson(
            Pair(),
            Group(),
            Employee(),
            TypeOfLesson(),
            Discipline(),
            Auditory());
    }
    public static TypeOfLesson TypeOfLesson()

    {
        return new TypeOfLesson();
    }

    public static Material Material()
    {
        Console.Write("Введите название: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите автора: ");
        string creator = Console.ReadLine() ?? "";
        return new Material(name, creator);
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
            Console.Write("Введите название специальности: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Введите сокращенное название специальноти: ");
            string reduction = Console.ReadLine() ?? "";
            return new Speciality(name, reduction);

    }
 } 

