//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MomsMedicalHistory.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class facility_types
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public facility_types()
        {
            this.therapeutic_facilities = new HashSet<therapeutic_facilities>();
        }
    
        public int facility_type_ID { get; set; }
        public string facility_type_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<therapeutic_facilities> therapeutic_facilities { get; set; }
    }
}