using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassCreator
{
    public static СalendarAndThematicPlan CalendarAndThematicPlan()
    {
        Console.Write("Введите номер занятия: ");
        int lessonNumber = Convert.ToInt32(Console.ReadLine() ?? "");
        Console.Write("Введите количество часов: ");
        int numberOfHours = Convert.ToInt32(Console.ReadLine() ?? "");

        return new СalendarAndThematicPlan(lessonNumber, numberOfHours, Materials(), Paragraph(), TypeLesson());
    }


    public static TypeLesson TypeLesson()
    {
        return new TypeLesson();
    }

    public static Materials Materials()
    {
        return new Materials();
    }

    public static Paragraph Paragraph()
    {
        return new Paragraph();
    }

}