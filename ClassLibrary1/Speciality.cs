using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Speciality
    {
        public string Name { get; }
        public string Reduction { get; }

        public Speciality(string name, string reduction)
        {
            Name = name;
            Reduction = reduction;
        }
    }
}
