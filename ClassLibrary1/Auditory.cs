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
        private readonly string name; // название
        public string Name { get => name; }

        private readonly Employee employee; // Ссылка на ответственного сотрудника
        public Employee Employee { get => employee; }

        private readonly byte mest; // кол-во посадочных мест
        public byte Mest { get => mest; }

        private readonly byte window; // кол-во окон
        public byte Window { get => window; }

        private readonly Equipment equipment; // Ссылка на оборудование
        public Equipment Equipment { get => equipment; }
        public Auditory(string name, Employee employee, byte mest, byte window, Equipment equipment) // конструктор 
        {
            this.name = name;
            this.employee = employee;
            this.mest = mest;
            this.window = window;
            this.equipment = equipment;
        }
    }
}
