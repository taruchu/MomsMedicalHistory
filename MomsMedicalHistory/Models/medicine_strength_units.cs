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
    
    public partial class medicine_strength_units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public medicine_strength_units()
        {
            this.prescription_medications = new HashSet<prescription_medications>();
            this.vitamins = new HashSet<vitamin>();
        }
    
        public int medicine_strength_unit_ID { get; set; }
        public string medicine_strength_units1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prescription_medications> prescription_medications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vitamin> vitamins { get; set; }
    }
}
