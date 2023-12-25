namespace Case.Roasberry.Core.ValueObjects;
public record InvoiceInfo
{
    public string? TaxNumber { get; set; }
    public string? TaxOffice { get; set; }

    public InvoiceInfo()
    {
        TaxNumber = null;
        TaxOffice = null;
    }

    public InvoiceInfo(string taxNumber, string taxOffice)
    {
        TaxNumber = taxNumber;
        TaxOffice = taxOffice;
    }
}
