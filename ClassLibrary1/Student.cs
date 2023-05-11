//https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit - задание
namespace ClassLibrary1
{
    public class Student
    {
        public string Name { get; }

        public string Surname { get; }

        public string Patronimyc { get; }

        public Group Group { get; }
        
        public DateTime DateOfBirth { get; }
        
        public Student(string name, string surname, string patronimyc, Group group) : this(name, surname, patronimyc, group, DateTime.Now)
        { }
        public Student(string name, string surname, string patronimyc, Group group, DateTime dateOfBirth) // конструктор со всей фигней
        {
            Name = name;
            Surname = surname;
            Patronimyc = patronimyc;
            Group = group;
            DateOfBirth = dateOfBirth;
        }
    }
}
