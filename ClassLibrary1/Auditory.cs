using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit - задание﻿

namespace ClassLibrary1
{
    public class Auditory
    {

        public string Name { get; }   // название

        public Employee Employee { get; } // Ссылка на ответственного сотрудника

        public byte Places { get; }  // кол-во посадочных мест

        public byte Window { get; }  // кол-во окон

        public List<Equipment> Equipment { get; } // Ссылка на оборудование
        public Auditory(string name, Employee employee, byte places, byte window, List<Equipment> equipment) // конструктор 
        {
            Name = name;
            Employee = employee;
            Places = places;
            Window = window;
            Equipment = equipment;
        }

    }
}
