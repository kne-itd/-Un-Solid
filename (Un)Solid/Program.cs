/* 
 * Løsning:
 * Del funktionaliteten op i flere klasser, hvor hver klasse har et enkelt ansvar.
*/
using _Un_Solid;

namespace UnSolidToSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice
            {
                Id = 1,
                Amount = 100.0,
            };
            InvoicePrinter invoicePrinter = new InvoicePrinter();
            DatabaseInvoiceSaver databaseInvoiceSaver = new DatabaseInvoiceSaver();
            EmailService emailService = new EmailService();

            InvoiceManager invoiceManager = new InvoiceManager(
                databaseInvoiceSaver, 
                emailService, 
                invoicePrinter);

            invoiceManager.AddInvoice(invoice);
            invoiceManager.SaveToDatabase();
            invoiceManager.PrintInvoices();
            invoiceManager.SendInvoicesByEmail();
        }
    }
}
