using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteHospitalSWNet.model
{

    
    class ServicioLocalPaciente
    {
        private static ServidorPacienteSW.PacienteSWClient servicio = new ServidorPacienteSW.PacienteSWClient();
      
        private ServicioLocalPaciente()
        {

        }

        public static void setServicio(ServidorPacienteSW.PacienteSWClient pServicio)
        {
            if(servicio == null)
            {
                servicio = pServicio;
            }
        }

        public static ServidorPacienteSW.PacienteSWClient getServicio()
        {
            return servicio;
        }

    }
}
