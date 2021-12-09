using System;
using System.Collections.Generic;
using TypesRecap.Models;

namespace TypesRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var number = 15;

            var accounter = new Accounter
            {
                Name = "Dominika",
                Surname = "Pawlik",
                Position = "Junior C# Developer & Part-Time Accounter hating this job",
                Sex = 'F'
            };

            var invoice1 = new Invoice()
            {
                Account = $"REG{number}WAW2021",
                Total = 14.44m,
                WhiteListed = true,
                Rows = 15,
                OverseaType = (int)InvoiceEnums.OverseaTypes.Blik,
                Accounter = accounter
            };

            var invoice2 = new Invoice()
            {
                Account = $"REG{number + 7}KRK2019",
                Total = 2994.44m,
                WhiteListed = false,
                Rows = 43,
                OverseaType = (int)InvoiceEnums.OverseaTypes.Cash,
                Accounter = accounter
            };

            var invoice3 = new Invoice()
            {
                Account = $"REG{number + 14}KRK2019",
                Total = 2994.44m,
                WhiteListed = false,
                Rows = 43,
                OverseaType = (int)InvoiceEnums.OverseaTypes.Blik,
                Accounter = accounter
            };

            var invoice4 = new Invoice()
            {
                Account = $"REG{number + 21}KRK2019",
                Total = 2994.44m,
                WhiteListed = false,
                Rows = 43,
                OverseaType = (int)InvoiceEnums.OverseaTypes.Blik,
                Accounter = accounter
            };

            var invoices = new List<Invoice>() { invoice1, invoice2, invoice3, invoice4 };

            foreach (var invoice in invoices)
            {
                if (invoice.OverseaType == (int)InvoiceEnums.OverseaTypes.Blik)
                {
                    Console.WriteLine($"Paying invoice acount {invoice.Account}");
                }
            }

            //if (invoice2.Total > invoice1.Total)
            //{
            //    Console.WriteLine(invoice2.Account);
            //}
            //else
            //{
            //    Console.WriteLine(invoice1.Account);
            //}
        }
    }
}
