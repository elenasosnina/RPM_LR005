//https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit - задание
namespace ClassLibrary1
{
    public class Student
    {
        public string Name { get; }

        public string Surname { get; }

        public string Patronimyc { get; }

        public Group Group { get; }
        
        public DateOnly DateOfBirth { get; }
        
        public Student(string name, string surname, string patronimyc, Group group, DateOnly dateOfBirth) // конструктор со всей фигней
        {
            Name = name;
            Surname = surname;
            Patronimyc = patronimyc;
            Group = group;
            DateOfBirth = dateOfBirth;
        }
    }
}
