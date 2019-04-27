using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDALC;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace capaLogicaNegocio
{
    public class CL_Contexto
    {
        private capaDALC.Entities conexion;

        public Entities Entidades
        {
            get
            {
                if (conexion == null)
                {
                    conexion = new capaDALC.Entities();
                }
                return conexion;
            }
        }
        public CL_Contexto(){}
    }
}
