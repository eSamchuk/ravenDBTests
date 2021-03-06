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
    
    public partial class Biometrics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Biometrics()
        {
        }
    
        public string Id { get; set; }
        public string PhotoId { get; set; }
        public string SignId { get; set; }
        public string Finger1Id { get; set; }
        public string Finger2Id { get; set; }
        public string Finger3Id { get; set; }
        public string Finger4Id { get; set; }
        public string Finger5Id { get; set; }
        public string Finger6Id { get; set; }
        public string Finger7Id { get; set; }
        public string Finger8Id { get; set; }
        public string Finger9Id { get; set; }
        public string Finger10Id { get; set; }
        public string ThumbnailPhotoId { get; set; }
        public Nullable<System.DateTime> DateInsert { get; set; }
    
        public BIO_CONTAINER Finger1Container { get; set; }
        public BIO_CONTAINER Finger10Container { get; set; }
        public BIO_CONTAINER Finger2Container { get; set; }
        public BIO_CONTAINER Finger3Container { get; set; }
        public BIO_CONTAINER Finger4Container { get; set; }
        public BIO_CONTAINER Finger5Container { get; set; }
        public BIO_CONTAINER Finger6Container { get; set; }
        public BIO_CONTAINER Finger7Container { get; set; }
        public BIO_CONTAINER Finger8Container { get; set; }
        public BIO_CONTAINER Finger9Container { get; set; }
        public BIO_CONTAINER PhotoContainer { get; set; }
        public BIO_CONTAINER ThumbnailPhotoContainer { get; set; }
        public BIO_CONTAINER SignContainer { get; set; }
    }
}
