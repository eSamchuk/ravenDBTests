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
    
    public partial class AuxiliaryDocument
    {
        public string Id { get; set; }
        public string ApplicationId { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocDescription { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string IssuedBy { get; set; }
        public Nullable<System.DateTime> DateIssue { get; set; }
        public Nullable<System.DateTime> DateInsert { get; set; }
        public Nullable<decimal> ScanId { get; set; }
    
        public Application Application { get; set; }
        public PARAM DocumentType { get; set; }
        public ScannedDocument Scan { get; set; }
    }
}
