using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*https://docs.google.com/document/d/13_tv-C4ZubcDGlzV3_LZR4QZY0YfZNturolzu6pO0ho/edit */

namespace ClassLibrary1
{
    public class Theme
    {
        private readonly string title;
        public string Title {get => title;}

        public Theme(string Title) {this.title = title;}
    }
}
