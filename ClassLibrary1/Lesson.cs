using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit

namespace ClassLibrary1
{
    public class Lesson

    {
        public DateTime Data { get; }
        public Pair Pair { get; }
        public Employee Employee { get; }
        public TypeOfLesson TypeOfLesson { get; }
        public Auditory Auditory { get; }
        public Discipline Discipline { get; }
        public Group Group { get; }

        public Lesson(Pair pair, Group group, Employee employee,
            TypeOfLesson typeOfLesson, Discipline discipline, Auditory auditory) : this(pair, group, employee,
             typeOfLesson, discipline, auditory, DateTime.Now)
        { }
        public Lesson(Pair pair, Group group, Employee employee,
            TypeOfLesson typeOfLesson, Discipline discipline, Auditory auditory,DateTime data) 
        {
            Data = data;
            Pair = pair;
            Group = group;
            Employee = employee;
            TypeOfLesson = typeOfLesson;
            Discipline = discipline;
            Auditory = auditory;

        }
    }
}
