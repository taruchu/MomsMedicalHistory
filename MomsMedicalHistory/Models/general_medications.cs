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
    
    public partial class general_medications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public general_medications()
        {
            this.prescription_medication_interactions = new HashSet<prescription_medication_interactions>();
        }
    
        public int general_medicine_ID { get; set; }
        public string general_medicine_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prescription_medication_interactions> prescription_medication_interactions { get; set; }
    }
}