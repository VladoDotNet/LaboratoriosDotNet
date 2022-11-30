using CORE.Interfaces.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Servicios.State
{
    public class EstadoSolicitud : EstadoBase
    {
        public override void CambiarEstado(EstadoContext estadoContext)
        {
            //CAMBIO DE ESTADO AL SIGUIENTE PROCESO
            estadoContext.Estado = new EstadoVerificado();
            Console.WriteLine("PROCESANDO ESTADO ... iniciando estado de verificación.");
        }
    }
}
