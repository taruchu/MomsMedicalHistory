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
    
    public partial class clinical_visits
    {
        public int clinic_visit_ID { get; set; }
        public int clinic_info_ID { get; set; }
        public System.DateTime clinic_visit_date { get; set; }
        public System.TimeSpan clinic_visit_time { get; set; }
        public int clinic_referring_doctor_ID { get; set; }
        public string clinic_detailed_treatment { get; set; }
        public string clinic_results { get; set; }
    
        public virtual clinic clinic { get; set; }
        public virtual physician physician { get; set; }
    }
}