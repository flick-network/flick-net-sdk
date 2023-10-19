using System;
using System.Collections.Generic;

namespace flick_net_sdk.Models
{
    public class InvoiceData
    {
        public string EGSUuid { get; set; }
        public string InvoiceRefNumber { get; set; }
        public string IssueDate { get; set; }
        public string IssueTime { get; set; }
        public PartyDetails PartyDetails { get; set; }
        public string DocType { get; set; }
        public bool HasAdvance { get; set; }
        public AdvanceDetails AdvanceDetails { get; set; }
        public string InvType { get; set; }
        public int PaymentMethod { get; set; }
        public string Currency { get; set; }
        public string TotalTax { get; set; }
        public List<LineItem> LineItems { get; set; }
    }

    public class PartyDetails
    {
        public string PartyNameAr { get; set; }
        public string PartyNameEn { get; set; }
        public string PartyVat { get; set; }
        public PartyAddId PartyAddId { get; set; }
        public string CityAr { get; set; }
        public string CityEn { get; set; }
        public string CitySubdivisionAr { get; set; }
        public string CitySubdivisionEn { get; set; }
        public string StreetAr { get; set; }
        public string StreetEn { get; set; }
        public string PlotIdentification { get; set; }
        public string Building { get; set; }
        public string PostalZone { get; set; }
    }

    public class PartyAddId
    {
        public int CRN { get; set; }
    }

    public class AdvanceDetails
    {
        public decimal AdvanceAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public List<AdvanceInvoice> AdvanceInvoices { get; set; }
    }

    public class AdvanceInvoice
    {
        public string TaxCategory { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public List<Invoice> Invoices { get; set; }
    }

    public class Invoice
    {
        public string ID { get; set; }
        public string IssueDate { get; set; }
        public string IssueTime { get; set; }
    }

    public class LineItem
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public decimal Quantity { get; set; }
        public string TaxCategory { get; set; }
        public decimal TaxExclusivePrice { get; set; }
        public decimal TaxPercentage { get; set; }
    }
}
