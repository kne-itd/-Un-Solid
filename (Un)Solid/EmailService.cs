using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Un_Solid
{
    public class EmailService : IEmailService
    {
        public void Send(List<Invoice> invoices)
        {
            foreach (var invoice in invoices)
            {
                Console.WriteLine($"Sending invoice {invoice.Id} by email...");
            }
        }
    }
}
