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
    
    public partial class hospital
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hospital()
        {
            this.hospital_visits = new HashSet<hospital_visits>();
        }
    
        public int hospital_ID { get; set; }
        public string hospital_name { get; set; }
        public int hospital_department_ID { get; set; }
        public Nullable<int> hospital_physician_ID { get; set; }
        public string hospital_phone { get; set; }
        public string hospital_address { get; set; }
        public int city_ID { get; set; }
        public int state_ID { get; set; }
        public int zipcode_ID { get; set; }
    
        public virtual city city { get; set; }
        public virtual hospital_departments hospital_departments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hospital_visits> hospital_visits { get; set; }
        public virtual physician physician { get; set; }
        public virtual state state { get; set; }
        public virtual zipcode zipcode { get; set; }
    }
}
