//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDCard.Data.IdCardEFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentTemplate
    {
        public string Id { get; set; }
        public string PaymentServiceId { get; set; }
        public decimal Amount { get; set; }
        public string Account { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string Purpose { get; set; }
        public string Receiver { get; set; }
        public int IsActual { get; set; }
        public System.DateTime DateInsert { get; set; }
        public PaymentService PaymentService { get; set; }
    }
}
