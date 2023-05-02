using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Corpus
    {
     
        public string Title { get; }
        public string Address { get; }

        private readonly Employee commandant;
        private readonly Organization organization;
        
        public Employee Commandant { get => commandant; }

  
        public Organization Organization { get => organization; }
        public Corpus(string title, string address, Employee commandant, Organization organization)
        {
            this.Title = title;
            this.Address = address;
            this.organization = organization;
            this.commandant = commandant;
        }
    }
}
