using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesRecap.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string NIP { get; set; }
        public Address Address { get; set; }
        public ElectronicContactDetails Contact { get; set; }
    }
}
