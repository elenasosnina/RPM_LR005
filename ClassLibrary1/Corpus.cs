using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit */
namespace ClassLibrary1
{
    public class Corpus
    {
     
        public string Title { get; }
        public string Address { get; }
        public Employee Commandant { get; }
        public Organization Organization { get; }
        public Corpus(string title, string address, Employee commandant, Organization organization)
        {
            this.Title = title;
            this.Address = address;
            this.Organization = organization;
            this.Commandant = commandant;
        }
    }
}
