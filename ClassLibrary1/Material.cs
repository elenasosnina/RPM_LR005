using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* https://docs.google.com/document/d/1YxpUHX84ZBY6UILHctzRWywnt7bWSSup4JTn6Or4p-k/edit */

namespace ClassLibrary1
{
    public class Material
    {
        
        public string Name { get; }      
        public string Creator { get; }
        public Material(string name, string creator)
        {
            Name = name;
            Creator = creator;
            
        }
    }
}
