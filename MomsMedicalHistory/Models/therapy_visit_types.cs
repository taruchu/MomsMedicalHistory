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
    
    public partial class therapy_visit_types
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public therapy_visit_types()
        {
            this.therapy_visits = new HashSet<therapy_visits>();
        }
    
        public int therapy_visit_type_ID { get; set; }
        public string therapy_visit_type_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<therapy_visits> therapy_visits { get; set; }
    }
}
