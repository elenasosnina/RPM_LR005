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
        public DateOnly Data { get; }
        public Pair Pair { get; }
        public Employee Employee { get; }
        public TypeOfLesson TypeOfLesson { get; }
        public Auditory Auditory { get; }
        public Discipline Discipline { get; }
        public Group Group { get; }

        public Lesson(DateOnly? data, Pair pair, Group group, Employee employee,
            TypeOfLesson typeOfLesson, Discipline discipline, Auditory auditory)
        {
            Data = data ?? DateOnly.FromDateTime(DateTime.Now);
            Pair = pair;
            Group = group;
            Employee = employee;
            TypeOfLesson = typeOfLesson;
            Discipline = discipline;
            Auditory = auditory;
        }
    }
}
