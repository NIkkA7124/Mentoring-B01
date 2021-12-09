using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesRecap.Models
{
    public class Accounter
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public char Sex { get; set; }
        public string Position { get; set; }
        public Company EmployedBy { get; set; }
        public Address Address { get; set; }
        public ElectronicContactDetails Contact { get; set; }
    }
}
