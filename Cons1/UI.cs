using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal static class UI
{
    public static void Print(СalendarAndThematicPlan calendarAndThematicPlan)
    {
        Console.WriteLine("СalendarAndThematicPlan");
        Console.WriteLine(calendarAndThematicPlan.LessonNumber);
        Console.WriteLine(calendarAndThematicPlan.NumberOfHours);
        Print(calendarAndThematicPlan.Paragraph);
        Print(calendarAndThematicPlan.TypeLesson);
        Print(calendarAndThematicPlan.Materials);
    }
    public static void Print(Paragraph paragraph)
    {
        Console.WriteLine(paragraph);
    }

    public static void Print(TypeLesson typeLesson)
    {
        Console.WriteLine(typeLesson);
    }

    public static void Print(Materials materials)
    {
        Console.WriteLine(materials);
    }
    
}


