using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Group
    {
    }
}
﻿namespace ClassLibrary1
{
    /* https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit */
    public class Group
    {
        private readonly string name;
        public string Name { get => name; }

        private readonly string sokr;
        public string Sokr { get => sokr; }

        private readonly byte population;
        public byte Population { get => population; }

        private readonly ushort year = 0;
        public ushort Year { get => year; }

        private readonly Speciality speciality;
        public Speciality Speciality { get => speciality; }

        private readonly Teacher teacher;
        public Teacher Teacher { get => teacher; }


        public Group(string name, string sokr, byte population, ushort year, Speciality speciality, Teacher teacher)
        {
            this.name = name;
            this.sokr = sokr;
            this.population = population;
            this.year = year;
            this.speciality = speciality;
            this.teacher = teacher;
        }
    }
}

