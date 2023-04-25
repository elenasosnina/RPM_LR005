﻿namespace ClassLibrary1
{
    /* https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit */
    public class Group
    {
        private readonly string? name;
        public string? Name { get => name; }

        private readonly string? sokr;
        public string? Sokr { get => sokr; }

        private readonly int? chisl;
        public int? Chisl { get => chisl; }

        private readonly int? year = 0;
        public int? Year { get => year; }

        private readonly Speciality speciality;
        public Speciality Speciality { get => speciality; }

        private readonly Teacher teacher;
        public Teacher Teacher { get => teacher; }


        public Group(string? name, string? sokr, int? chisl, int? year, Speciality speciality, Teacher teacher)
        {
            this.name = name;
            this.sokr = sokr;
            this.chisl = chisl;
            this.year = year ?? DateTime.Now.Year;
            this.speciality = speciality;
            this.teacher = teacher;
        }
    }
}

