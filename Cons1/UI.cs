using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class UI
{

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


    public static void Print(Auditory auditory)
    {
        Console.WriteLine(auditory);
    }
    public static void Print(Theme theme)
    {
        Console.WriteLine(theme);
    }

    public static void Print(Group group)
    {
        Console.WriteLine(group);   
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
    public static void Print(Employee employee)
    {
        Console.WriteLine(employee);
    }
    
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

