//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctusDT
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Usuarios()
        {
            this.tbl_Actividades = new HashSet<tbl_Actividades>();
        }
    
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Actividades> tbl_Actividades { get; set; }
    }
}
