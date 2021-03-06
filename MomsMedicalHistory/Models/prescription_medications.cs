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
    
    public partial class prescription_medications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prescription_medications()
        {
            this.prescription_medication_interactions = new HashSet<prescription_medication_interactions>();
        }
    
        public int medicine_ID { get; set; }
        public string medicine_name { get; set; }
        public int medicine_prescription_physician_ID { get; set; }
        public int medicine_form_ID { get; set; }
        public int medicine_strength { get; set; }
        public int medicine_strength_unit_ID { get; set; }
        public int medicine_dosage { get; set; }
        public int medicine_dosage_unit_ID { get; set; }
        public int medicine_pharmacy_ID { get; set; }
    
        public virtual medicine_dosage_units medicine_dosage_units { get; set; }
        public virtual medicine_forms medicine_forms { get; set; }
        public virtual medicine_strength_units medicine_strength_units { get; set; }
        public virtual pharmacy pharmacy { get; set; }
        public virtual physician physician { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prescription_medication_interactions> prescription_medication_interactions { get; set; }
    }
}
