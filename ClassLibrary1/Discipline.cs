using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Discipline
    {
        //https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit        
        // Имя
        public string Lname { get; }        
        // Сокращение
        public string Abbreviationn { get; }
        public Discipline(string lname, string abbreviationn)
        {
            Lname = lname;
            Abbreviationn = abbreviationn;
        }
    }
}