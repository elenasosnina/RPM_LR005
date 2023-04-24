namespace ClassLibrary1
{
    public class Auditory
    {
        private readonly string? name; // название
        public string? Name { get => name; }

        private readonly Employee employee; // Ссылка на ответственного сотрудника
        public Employee Employee { get => employee; }

        private readonly int? mest; // кол-во посадочных мест
        public int? Mest { get => mest; }

        private readonly int? window; // кол-во окон
        public int? Window { get => window; }

        private readonly Equipment equipment; // Ссылка на оборудование
        public Equipment Equipment { get => equipment; }
        public Auditory(string name, Employee employee, int mest, int window, Equipment equipment) // конструктор 
        {
            this.name = name;
            this.employee = employee;
            this.mest = mest;
            this.window = window;
            this.equipment = equipment;
        }
    }
}