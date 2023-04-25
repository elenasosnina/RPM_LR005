using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ClassCreator
{

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

    public static Group Group()
    {
        return new Group();
    }
    
    public static Employee Employee()
    {
        return new Employee();
    }
    
    public static Pair Pair()
    {
        return new Pair();
    }
}