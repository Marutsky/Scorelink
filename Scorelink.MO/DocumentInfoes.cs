//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scorelink.MO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocumentInfoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentInfoes()
        {
            this.DocumentDetail = new HashSet<DocumentDetail>();
        }
    
        public int DocId { get; set; }
        public string FileUID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentDetail> DocumentDetail { get; set; }
    }
}