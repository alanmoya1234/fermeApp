//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capaDALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMUNA
    {
        public COMUNA()
        {
            this.DIR_DESPACHO = new HashSet<DIR_DESPACHO>();
            this.PROVEEDOR = new HashSet<PROVEEDOR>();
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public decimal ID_COMUNA { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal ID_CIUDAD { get; set; }
    
        public virtual CIUDAD CIUDAD { get; set; }
        public virtual ICollection<DIR_DESPACHO> DIR_DESPACHO { get; set; }
        public virtual ICollection<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}
