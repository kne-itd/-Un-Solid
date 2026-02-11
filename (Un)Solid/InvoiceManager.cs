using _Un_Solid;

public class InvoiceManager
{
    private IInvoiceSaver invoiceSaver;
    private IEmailService emailService;
    private IInvoicePrinter invoicePrinter;

     public InvoiceManager(IInvoiceSaver invoiceSaver, IEmailService emailService, IInvoicePrinter invoicePrinter)
    {
        this.invoiceSaver = invoiceSaver;
        this.emailService = emailService;
        this.invoicePrinter = invoicePrinter;
    }
    private List<Invoice> invoices = new List<Invoice>();

    public void AddInvoice(Invoice invoice)
    {
        invoices.Add(invoice);
    }

    public void SaveToDatabase()
    {
        DatabaseInvoiceSaver repository = new DatabaseInvoiceSaver();
        repository.Save(invoices);
        //Console.WriteLine("Saving invoices to database...");
        // kode til database gemt direkte her
    }

    public void PrintInvoices()
    {
        InvoicePrinter printer = new InvoicePrinter();
        printer.Print(invoices);
        //foreach (var invoice in invoices)
        //{
        //    Console.WriteLine($"Invoice {invoice.Id}: {invoice.Amount} DKK");
        //}
    }

    public void SendInvoicesByEmail()
    {
        EmailService emailService = new EmailService(); 
        emailService.Send(invoices);
        //foreach (var invoice in invoices)
        //{
        //    Console.WriteLine($"Sending invoice {invoice.Id} by email...");
        //}
    }
}
