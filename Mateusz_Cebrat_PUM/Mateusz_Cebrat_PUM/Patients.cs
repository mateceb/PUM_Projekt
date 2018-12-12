//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mateusz_Cebrat_PUM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patients()
        {
            this.Visits = new HashSet<Visits>();
        }
    
        public int patientID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string pesel { get; set; }
        public string sex { get; set; }
        public string dateOfBirth { get; set; }
        public string adress { get; set; }
        public string city { get; set; }
        public int doctorID { get; set; }
    
        public virtual Anamnesis Anamnesis { get; set; }
        public virtual Doctors Doctors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visits> Visits { get; set; }
        public virtual WorkInterview WorkInterview { get; set; }
    }
}
