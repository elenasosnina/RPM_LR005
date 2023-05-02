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
        Print(lesson.TypeOfLesson);
    }
    
    public static void Print(Material material)
    {
        Console.WriteLine(material.Name);
        Console.WriteLine(material.Creator);
    }

    public static void Print(TypeOfLesson typeOfLesson)
    {
        Console.WriteLine(typeOfLesson);
    }
    public static void Print(Discipline discipline)
    {
        Console.WriteLine(discipline);
    }

    public static void Print(Pair pair)
    {
        Console.WriteLine("Pair");
        Console.WriteLine(pair.PairStart);
        Console.WriteLine(pair.PairEnd);
        Console.WriteLine(pair.BreakStart);
        Console.WriteLine(pair.BreakEnd);
        Print(pair.ShiftLink);

    }
    public static void Print(Shift shift)
    {
        Console.WriteLine(shift);
    }


    public static void Print(Employee employee)
    {
        Console.WriteLine(employee);
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

    public static void Print(Organization organization)
    {
        Console.WriteLine(organization);
    }
    public static void Print(Corpus corpus)
    {
        Console.WriteLine("Corpus");
        Console.WriteLine(corpus.Title);
        Console.WriteLine(corpus.Address);
        Print(corpus.Commandant);
        Print(corpus.Organization);
    }

    public static void Print(Competence competence)
    {
        Console.WriteLine(competence.Code);
        Console.WriteLine(competence.Content);
        Print(competence.Speciality);
    }
}

