//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Junio21.ef
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paises()
        {
            this.Ciudades = new HashSet<Ciudades>();
        }
    
        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> ContinenteId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ciudades> Ciudades { get; set; }
        public virtual Continentes Continentes { get; set; }
    }
}
