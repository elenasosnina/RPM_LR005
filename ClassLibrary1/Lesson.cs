//https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit

namespace ClassLibrary1
{
    public class Lesson
    {
        private readonly DateTime data; //дата
        public DateTime Data { get => data; }

        private readonly Pair pair;
        public Pair Pair { get => pair; } //ссылка на пару(Каргин. М)

        private readonly Employee employee;
        public Employee Employee { get => employee; }//ссылка на сотрудника(Журавлев В.)

        private readonly TypeLesson typeLesson;
        public TypeLesson TypeLesson { get => typeLesson; }//ссылка на вид занятия(Ковалев. А)

        private readonly Auditory auditory;
        public Auditory Auditory { get => auditory; }//ссылка на аудиторию (Рощин Э.)

        private readonly Discipline discipline;
        public Discipline Discipline { get => discipline; }//ссылка на дисциплину(Евграфов Д.)

        private readonly Group group;
        public Group Group { get => group; }//ссылка на группу(Ломоносов А.)


        public Lesson(DateTime? data, Pair pair, Group group, Employee employee,
            TypeLesson typeLesson, Discipline discipline, Auditory auditory)
        {
            this.data = data ?? DateTime.Now;
            this.pair = pair;
            this.group = group;
            this.employee = employee;
            this.typeLesson = typeLesson;
            this.discipline = discipline;
            this.auditory = auditory;
        }
    }
}
