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
    
    public partial class EgyptSecondLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EgyptSecondLevel()
        {
        }
    
        public string Id { get; set; }
        public string NameEng { get; set; }
        public string NameArb { get; set; }
        public string Code { get; set; }
        public int IsActual { get; set; }
        public System.DateTime DateInsert { get; set; }
        public string EgyptFirstLevelId { get; set; }
    
        public EgyptFirstLevel EgyptFirstLevel { get; set; }
    }
}
