//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektProgramowanie
{
    using System;
    using System.Collections.Generic;
    
    public partial class samochody
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public samochody()
        {
            this.uslugis = new HashSet<uslugi>();
        }
    
        public string VIN { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string nrSilnika { get; set; }
        public string peselWlasciciela { get; set; }
    
        public virtual klienci klienci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uslugi> uslugis { get; set; }
    }
}
