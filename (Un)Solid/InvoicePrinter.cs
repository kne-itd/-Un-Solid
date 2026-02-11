using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Un_Solid
{
    public class InvoicePrinter
    {
        public void Print(List<Invoice> invoices)
        {
            foreach (var invoice in invoices)
            {
                Console.WriteLine($"Invoice {invoice.Id}: {invoice.Amount} DKK");
            }
        }
    }
}
