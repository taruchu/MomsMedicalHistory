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
    
    public partial class therapeutic_facilities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public therapeutic_facilities()
        {
            this.therapy_visits = new HashSet<therapy_visits>();
        }
    
        public int facility_ID { get; set; }
        public int facility_type_ID { get; set; }
        public string facility_name { get; set; }
        public string facility_phone { get; set; }
        public string facility_address { get; set; }
        public int city_ID { get; set; }
        public int state_ID { get; set; }
        public int zipcode_ID { get; set; }
    
        public virtual city city { get; set; }
        public virtual facility_types facility_types { get; set; }
        public virtual state state { get; set; }
        public virtual zipcode zipcode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<therapy_visits> therapy_visits { get; set; }
    }
}
