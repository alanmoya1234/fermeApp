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
    
    public partial class VENT_TIP_PAGO
    {
        public decimal ID_V_TIP_PAGO { get; set; }
        public decimal COD_VENTA { get; set; }
        public decimal ID_TIP_PAGO { get; set; }
    
        public virtual TIPO_PAGO TIPO_PAGO { get; set; }
        public virtual VENTA VENTA { get; set; }
    }
}
