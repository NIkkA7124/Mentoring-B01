using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesRecap.Models
{
    public class Invoice
    {
        public string Number { get; private set; }
        public string Account { get; set; }
        public Company Receiver { get; set; }
        public Company Issuer { get; set; }
        public Accounter Accounter { get; set; }
        public bool WhiteListed { get; set; }
        public DateTime ReceivedDate { get; set; }
        public List<Item> Items { get; set; }
        public int Rows { get; set; }
        public decimal Total { get; set; }
        public int OverseaType { get; set; }
    }
}
