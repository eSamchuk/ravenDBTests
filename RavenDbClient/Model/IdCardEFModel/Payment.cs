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
    
    public partial class Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment()
        {
        }
    
        public string Id { get; set; }
        public string ApplicationId { get; set; }
        public decimal Amount { get; set; }
        public decimal TypeId { get; set; }
        public Nullable<System.DateTime> DateInsert { get; set; }
    
        public Application Application { get; set; }
        public PARAM Type { get; set; }
    }
}
