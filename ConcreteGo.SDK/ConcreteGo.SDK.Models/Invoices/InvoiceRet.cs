﻿using ConcreteGo.SDK.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Invoices
{
    [XmlRoot("InvoiceRet")]
    public class InvoiceRet
    {
        public int ID { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public DateTime InvoiceDate { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public string CustomerCode { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public int DivisionID { get; set; }
        public string DivisionCode { get; set; } = string.Empty;
        public int ProjectID { get; set; }
        public string ProjectCode { get; set; } = string.Empty;
        public string ProjectName { get; set; } = string.Empty;
        public string JobNumber { get; set; } = string.Empty;
        public string PurchaseOrder {  get; set; } = string.Empty;
        public DeliveryAddress DeliveryAddress { get; set; }
        public InvoiceAddress InvoiceAddress { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public string TicketCodes { get; set; } = string.Empty;
        public string MessageText { get; set; } = string.Empty;
        public string AccountingCategoryCode { get; set; } = string.Empty;
        public string PricingPlantCode { get; set; } = string.Empty;
        public string CustomerJob {  get; set; } = string.Empty;
        public string IsRemoved { get; set; }
        public string RemoveReason { get; set; }
        public string TaxCode { get; set; } = string.Empty;
        public string TaxCodeDescription { get; set; } = string.Empty;
        public string TaxCodeShortDescription { get; set; } = string.Empty;
        public bool Taxable { get; set; }
        public string PaymentForm { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public Products Products { get; set; }

    }

    public class Products
    {
        public List<Product> Product { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public string OrderCode { get; set; }
        public string TicketID { get; set; }
        public string TicketCode { get; set; }
        public string TicketTime { get; set; }
        public int TicketProductID { get; set; }
        public int ItemID { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string AccountLinkCode { get; set; }
        public bool IsMix { get; set; }
        public string PriceQty { get; set; }
        public string Price { get; set; }
        public string PriceQtyUnit { get; set; }
        public string OrderQtyUnit { get; set; }
        public bool Taxable {  get; set; }
        public decimal Amount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TicketAmount { get; set; }
        public decimal TicketTaxAmount { get; set; }
        public decimal TicketTotalAmount { get; set; }
    }

    public class PaymentTerm
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DiscountType { get; set; }
        public string Description { get; set; }
        public string NetDueDays { get; set; }
        public string Discount { get; set; }
        public string DiscountPayDays { get; set; }
    }

    [XmlRoot(ElementName = "DeliveryAddress")]
    public class DeliveryAddress
    {

        [XmlElement(ElementName = "Addr1")]
        public object Addr1 { get; set; }

        [XmlElement(ElementName = "Addr2")]
        public object Addr2 { get; set; }

        [XmlElement(ElementName = "Addr3")]
        public object Addr3 { get; set; }
    }

}
