using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //https://docs.google.com/document/d/1yVUsN3kjBq8p0lpNqIPmfKwpoLFw12PQTUwH_bwbODc/edit
    public class Paragraph
    {
        public string Pname { get; }

        private readonly Theme theme;
        public Theme Theme { get => theme; }
        public Paragraph(string pname, Theme theme)
        {
            Pname = pname;
            this.theme = theme;
        }
    }
}
