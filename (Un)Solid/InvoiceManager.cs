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
        invoiceSaver.Save(invoices);

        // kode til database gemt direkte her
    }

    public void PrintInvoices()
    {
        invoicePrinter.Print(invoices);
    }

    public void SendInvoicesByEmail()
    {
        emailService.Send(invoices);
    }
}
