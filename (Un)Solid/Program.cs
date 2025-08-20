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
            InvoiceManager invoiceManager = new InvoiceManager();
            invoiceManager.AddInvoice(invoice);
            invoiceManager.SaveToDatabase();
            invoiceManager.PrintInvoices();
            invoiceManager.SendInvoicesByEmail();
        }
    }
}
