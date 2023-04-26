using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

﻿namespace ClassLibrary1
{
    /* https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit */
    public class Group
    {

        public string Name { get; }
        public string Shortname { get; }
        public byte Population { get; }
        public ushort YearOfAdmission { get; }
        public Speciality Speciality { get; }
        public Teacher ClassRoomTeacher { get; }


        public Group(string name, string shortname, byte population, ushort yearofadmission, Speciality speciality, Teacher teacher)
        {
            Name = name;
            Shortname = shortname;
            Population = population;
            YearOfAdmission = yearofadmission;
            Speciality = speciality;
            ClassRoomTeacher = teacher;
        }
    }
}

