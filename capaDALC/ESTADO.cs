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
    
    public partial class ESTADO
    {
        public ESTADO()
        {
            this.CREDENCIAL = new HashSet<CREDENCIAL>();
            this.EMPRESA = new HashSet<EMPRESA>();
            this.PRODUCTO = new HashSet<PRODUCTO>();
            this.PROMOCION = new HashSet<PROMOCION>();
            this.PROVEEDOR = new HashSet<PROVEEDOR>();
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public decimal ID_STS { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<CREDENCIAL> CREDENCIAL { get; set; }
        public virtual ICollection<EMPRESA> EMPRESA { get; set; }
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
        public virtual ICollection<PROMOCION> PROMOCION { get; set; }
        public virtual ICollection<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}