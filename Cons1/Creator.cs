
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

    public static Group Group()
    {
        return new Group();
    }
}
