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
        Console.WriteLine(auditory.Places);
        Console.WriteLine(auditory.Window);
        Print(auditory.Employee);
        Print(auditory.Equipment);
    }
    public static void Print(Employee employee)
    {
        Console.WriteLine(employee);
    }

    public static void Print(Student student)
    {
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Surname);
        Console.WriteLine(student.Patronimyc);
        Console.WriteLine(student.Date);
        Print(student.Group);
    }

    public static void Print(Equipment equipment)
    {
        Console.WriteLine(equipment);
    }
    
    public static void Print(Lesson lesson)
    {
        Console.WriteLine("Lesson ");
        Console.WriteLine(lesson.Data);
        Print(lesson.Pair);
        Print(lesson.Discipline);
        Print(lesson.Employee);
        Print(lesson.Auditory);
        Print(lesson.Group);
        Print(lesson.TypeLesson);
    }
    
    public static void Print(TypeLesson typeLesson)
    {
        Console.WriteLine(typeLesson);
    }
    public static void Print(Discipline discipline)
    {
        Console.WriteLine(discipline);
    }

    public static void Print(Pair pair)
    {
        Console.WriteLine(pair);
    }
    public static void Print(Group group)
    {
        Console.WriteLine("Group");
        Console.WriteLine(group.Name);
        Console.WriteLine(group.ShortName);
        Console.WriteLine(group.Population);
        Console.WriteLine(group.YearOfAdmission);
        Print(group.ClassRoomTeacher);
        Print(group.Speciality);
    }
    public static void Print(Speciality speciality)
    {
        Console.WriteLine(speciality.Name);
        Console.WriteLine(speciality.Reduction);
    }
    public static void Print(Teacher teacher)
    {
        Console.WriteLine(teacher);

    }
    public static void Print(Paragraph paragraph)
    {
        Console.WriteLine("Paragraph");
        Console.WriteLine(paragraph.Pname);
        Print(paragraph.Theme);
    }
    public static void Print(Theme theme)
    {
        Console.WriteLine(theme);
    }
}
