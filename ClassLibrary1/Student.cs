//https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit - задание
namespace ClassLibrary1
{
    public class Student
    {
        private readonly string? name; // имя
        public string? Name { get => name; }

        private readonly string? s_name; // фамилия

        public string? S_name { get => s_name; }

        private readonly string? p_name; // отчество

        public string? P_name { get => p_name; }

        private readonly Group group;

        public Group Group { get => group; }

        private readonly DateTime date; // дата рождения

        public DateTime? Date { get => date; }
        public Student(string name, string s_name, string p_name, Group group, DateTime? date) // конструктор со всей фигней
        {
            this.name = name;
            this.s_name = s_name;
            this.p_name = p_name;
            this.group = group;
            this.date = date ?? DateTime.Today;
        }
    }
}
