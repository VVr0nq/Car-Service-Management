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
    
    public partial class uslugi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uslugi()
        {
            this.czynnoscis = new HashSet<czynnosci>();
        }
    
        public long idUslugi { get; set; }
        public Nullable<decimal> kwotaDoZaplaty { get; set; }
        public System.DateTime dataPrzyjeciaSamochodu { get; set; }
        public Nullable<System.DateTime> dataOdbioruSamochodu { get; set; }
        public string peselKlienta { get; set; }
        public int idPracownika { get; set; }
        public string VIN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<czynnosci> czynnoscis { get; set; }
        public virtual klienci klienci { get; set; }
        public virtual pracownicy pracownicy { get; set; }
        public virtual samochody samochody { get; set; }
    }
}
