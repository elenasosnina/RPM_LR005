using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Extracurricular
    {
        private readonly string name;
        public string Name { get => name; }
        private readonly Equipment equipment;
        public Equipment Equipment { get => equipment; }
        private readonly List<Student> student;
        public List<Student> Student { get => student; }
        public Extracurricular(string name, Equipment equipment, List<Student> student)
        {
            this.name = name;
            this.equipment = equipment;
            this.student = student;
        }
    }
}
