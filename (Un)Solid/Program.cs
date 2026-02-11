/* Problemer:
 * 1. InvoiceManager har for mange ansvarsområder (Single Responsibility Principle).
 * 2. Hvis vi ændrer måden, vi gemmer fakturaer på (f.eks. skifter til en fil i stedet for en database), skal vi ændre InvoiceManager, hvilket bryder Open/Closed Principle.
 * 3. Hvis vi ændrer måden, vi sender fakturaer på (f.eks. skifter til SMS i stedet for email), skal vi også ændre InvoiceManager, hvilket bryder Open/Closed Principle.
 * 4. Hvis vi ændrer måden, vi printer fakturaer på (f.eks. skifter til PDF i stedet for konsol), skal vi også ændre InvoiceManager, hvilket bryder Open/Closed Principle.
 * 5. InvoiceManager er tæt koblet til implementeringen af, hvordan fakturaer gemmes, printes og sendes, hvilket gør det svært at teste og vedligeholde (Dependency Inversion Principle).
 * 6. InvoiceManager har for mange metoder, hvilket gør det svært at forstå og vedligeholde (Interface Segregation Principle).
 * 7. InvoiceManager er ikke let at udvide, da det kræver ændringer i eksisterende kode, hvilket kan føre til fejl og problemer (Open/Closed Principle).
 */
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
