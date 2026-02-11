using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Un_Solid
{
    public class DatabaseInvoiceSaver : IDatabaseSaver
    {
        public void CreateConnection()
        {
            // kode til db-connection ... 
             Console.WriteLine("Creating database connection...");
        }

        public virtual void Save(List<Invoice> invoices)
        {
            Console.WriteLine("Saving invoices to database...");
            // kode til database gemt direkte her
        }
    }
}
