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
    
    public partial class pracownicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pracownicy()
        {
            this.uslugis = new HashSet<uslugi>();
            this.czynnoscis = new HashSet<czynnosci>();
        }
    
        public int idPracownika { get; set; }
        public string PESEL { get; set; }
        public string nazwisko { get; set; }
        public string nrTelefonu { get; set; }
        public System.DateTime dataZatrudnienia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uslugi> uslugis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<czynnosci> czynnoscis { get; set; }
    }
}
