public class InvoiceManager
{
    private List<Invoice> invoices = new List<Invoice>();

    public void AddInvoice(Invoice invoice)
    {
        invoices.Add(invoice);
    }

    public void SaveToDatabase()
    {
        Console.WriteLine("Saving invoices to database...");
        // kode til database gemt direkte her
    }

    public void PrintInvoices()
    {
        foreach (var invoice in invoices)
        {
            Console.WriteLine($"Invoice {invoice.Id}: {invoice.Amount} DKK");
        }
    }

    public void SendInvoicesByEmail()
    {
        foreach (var invoice in invoices)
        {
            Console.WriteLine($"Sending invoice {invoice.Id} by email...");
        }
    }
}
