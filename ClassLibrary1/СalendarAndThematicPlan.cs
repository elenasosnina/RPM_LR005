using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class СalendarAndThematicPlan
    {
        private readonly Paragraph paragraph;
        public Paragraph Paragraph { get => paragraph; } //ссылка на параграф

        private readonly TypeLesson typeLesson;
        public TypeLesson TypeLesson { get => typeLesson; } //ссылка на вид занятия

        private readonly Materials materials;
        public Materials Materials { get => materials; } //ссылка на материалы

        private readonly int? lessonNumber;
        public int? LessonNumber { get => lessonNumber; } //номер занятия

        private readonly int? numberOfHours;
        public int? NumberOfHours { get => numberOfHours; } //количество часов

        public СalendarAndThematicPlan(Materials materials, Paragraph paragraph, TypeLesson typeLesson, int lessonNumber, int numberOfHours)
        {
            this.paragraph = paragraph;
            this.typeLesson = typeLesson;
            this.materials = materials;
            this.lessonNumber = lessonNumber;
            this.numberOfHours = numberOfHours;
        }
    }
}

