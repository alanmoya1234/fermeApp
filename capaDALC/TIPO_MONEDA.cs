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
    
    public partial class TIPO_MONEDA
    {
        public TIPO_MONEDA()
        {
            this.VENTA = new HashSet<VENTA>();
        }
    
        public decimal ID_TIP_MONEY { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal VALOR_PESO_CL { get; set; }
    
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}
