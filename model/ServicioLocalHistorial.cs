using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteHospitalSWNet.model
{
    class ServicioLocalHistorial
    {

        private static ServicioHistorialClinicoSW.HistorialClinicoSWClient servicio = new ServicioHistorialClinicoSW.HistorialClinicoSWClient();

        private ServicioLocalHistorial()
        {

        }

        public static void setServicio(ServicioHistorialClinicoSW.HistorialClinicoSWClient pServicio)
        {
            if(servicio == null)
            {
                servicio = pServicio;
            }

        }

        public static ServicioHistorialClinicoSW.HistorialClinicoSWClient getServicio()
        {
            return servicio;
        }
    }
}
