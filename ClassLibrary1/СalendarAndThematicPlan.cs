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
        public TypeOfLesson TypeOfLesson { get; } //ссылка на вид занятия
        public Material Materials { get; } //ссылка на материалы
        public int? LessonNumber { get; } //номер занятия
        public int? NumberOfHours { get; } //количество часов

        public СalendarAndThematicPlan(int lessonNumber, int numberOfHours, Material materials, Paragraph paragraph, TypeOfLesson typeOfLesson)
        {
            Paragraph = paragraph;
            TypeOfLesson = typeOfLesson;
            Materials = materials;
            LessonNumber = lessonNumber;
            NumberOfHours = numberOfHours;
        }
    }
}

