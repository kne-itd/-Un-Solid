using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Un_Solid
{
    public class DatabaseInvoiceSaver : IInvoiceSaver
    {
        public virtual void Save(List<Invoice> invoices)
        {
            Console.WriteLine("Saving invoices to database...");
            // kode til database gemt direkte her
        }
    }
}
