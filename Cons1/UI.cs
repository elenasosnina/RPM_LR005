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
    
}

