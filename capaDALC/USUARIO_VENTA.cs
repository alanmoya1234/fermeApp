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
    
    public partial class USUARIO_VENTA
    {
        public decimal ID_US_VEN { get; set; }
        public string RUT { get; set; }
        public decimal COD_VENTA { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
