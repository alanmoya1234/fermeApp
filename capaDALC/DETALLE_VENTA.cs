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
    
    public partial class DETALLE_VENTA
    {
        public decimal ID_DET_VENT { get; set; }
        public decimal COD_PRODUCTO { get; set; }
        public decimal COD_VENTA { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
