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
    
    public partial class TIPO_PAGO
    {
        public TIPO_PAGO()
        {
            this.VENT_TIP_PAGO = new HashSet<VENT_TIP_PAGO>();
        }
    
        public decimal ID_TIP_PAGO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<VENT_TIP_PAGO> VENT_TIP_PAGO { get; set; }
    }
}