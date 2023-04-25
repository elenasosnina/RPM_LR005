using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Speciality
    {
        private readonly string? title; // название

        public string? Title { get => title; }

        private readonly string? reduction; // Сокращение

        public string? Reduction { get => reduction; }

        Speciality(string? title, string? reduction)
        {
            this.title = title;
            this.reduction = reduction;
        }
    }
}
