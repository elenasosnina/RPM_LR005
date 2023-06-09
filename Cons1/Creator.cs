using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

internal class ClassCreator
{
    public static СalendarAndThematicPlan CalendarAndThematicPlan()
    {
        Console.Write("Введите номер занятия: ");
        int lessonNumber = Convert.ToInt32(Console.ReadLine() ?? "");
        Console.Write("Введите количество часов: ");
        int numberOfHours = Convert.ToInt32(Console.ReadLine() ?? "");

        return new СalendarAndThematicPlan(lessonNumber, numberOfHours, Material(), Paragraph(), TypeOfLesson());
    }
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
        Console.Write("Введите фамилию: ");
        string surname = Console.ReadLine() ?? "";
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите отчество: ");
        string patronimyc = Console.ReadLine() ?? "";
        DateOnly dateOfBirth;
        Console.WriteLine("Введите дату рождения в формате дд.мм.гггг");
        while (!DateOnly.TryParse(Console.ReadLine(), out dateOfBirth)) ;
        return new Student(name, surname, patronimyc, Group(), dateOfBirth);
    }
    public static Lesson Lesson()
    {
        return new Lesson(
            Pair(),
            Group(),
            Employee(),
            TypeOfLesson(),
            Discipline(),
            Auditory(),
            DateTime.Now);
    }
    public static Paragraph Paragraph()
    {
        return new Paragraph();
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
        Console.Write("Введите название дисциплины: "); 
        string lname = Console.ReadLine() ?? "";
        Console.Write("Введите сокращенное название дисциплины: "); 
        string abbreviationn = Console.ReadLine() ?? "";
        return new Discipline(lname, abbreviationn);
    }

    public static Employee Employee()
    {
        return new Employee();
    }

    public static Equipment Equipment()
    {
        return new Equipment();
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

    public static Competence Competence()
    {
        Console.WriteLine("Введите код: ");
        string code = Console.ReadLine() ?? "";
        Console.WriteLine("Введите содержание: ");
        string content = Console.ReadLine() ?? "";
        return new Competence(code, content, Speciality());

    }

    public static Shift Shift()
    {
        return new Shift();
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
    public static Pair Pair()
    {
        TimeOnly pairStart, pairEnd, breakStart, breakEnd;

        Console.WriteLine("Введите время начала пары: "); string input = Console.ReadLine() ?? "";
        if (input != "") pairStart = TimeOnly.Parse(input);
        else
        {
            while (input == "") { Console.WriteLine("Введите время начала пары: "); input = Console.ReadLine() ?? ""; }
            pairStart = TimeOnly.Parse(input);
        }
        
        Console.WriteLine("Введите время окончания пары: "); input = Console.ReadLine() ?? "";
        if (input != "") pairEnd = TimeOnly.Parse(input);
        else
        {
            while (input == "") { Console.WriteLine("Введите время окончания пары: "); input = Console.ReadLine() ?? ""; }
            pairEnd = TimeOnly.Parse(input);
        }

        Console.WriteLine("Введите время начала перерыва: "); input = Console.ReadLine() ?? "";
        if (input != "") breakStart = TimeOnly.Parse(input);
        else
        {
            while (input == "") { Console.WriteLine("Введите время начала перерыва: "); input = Console.ReadLine() ?? ""; }
            breakStart = TimeOnly.Parse(input);
        }

        Console.WriteLine("Введите время окончания перерыва: "); input = Console.ReadLine() ?? "";
        if (input != "") breakEnd = TimeOnly.Parse(input);
        else
        {
            while (input == "") { Console.WriteLine("Введите время окончания перерыва: "); input = Console.ReadLine() ?? ""; }
            breakEnd = TimeOnly.Parse(input);
        }
        
        return new Pair(pairStart, pairEnd, breakStart, breakEnd, Shift());
    }
    public static Organization Organization()
    {
        return new Organization();
    }
    public static Corpus Corpus()
    {
        Console.Write("Введите название: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Введите адрес: ");
        string address = Console.ReadLine() ?? "";
        return new Corpus(name, address, Employee(), Organization());
    }
}
