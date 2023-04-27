using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class СalendarAndThematicPlan
    {
        
        public Paragraph Paragraph { get; } //ссылка на параграф

        public TypeLesson TypeLesson { get; } //ссылка на вид занятия

        public Materials Materials { get; } //ссылка на материалы

        public int? LessonNumber { get; } //номер занятия
        
        public int? NumberOfHours { get; } //количество часов

        public СalendarAndThematicPlan(int lessonNumber, int numberOfHours, Materials materials, Paragraph paragraph, TypeLesson typeLesson)
        {
            Paragraph = paragraph;
            TypeLesson = typeLesson;
            Materials = materials;
            LessonNumber = lessonNumber;
            NumberOfHours = numberOfHours;
        }
    }
}

