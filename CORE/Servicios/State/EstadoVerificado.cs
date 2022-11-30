using CORE.Interfaces.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Servicios.State
{
    public class EstadoVerificado : EstadoBase
    {
        public override void CambiarEstado(EstadoContext estadoContext)
        {
            //CAMBIO DE ESTADO AL SIGUIENTE PROCESO
            estadoContext.Estado = new EstadoPagado();
            Console.WriteLine("PROCESANDO ESTADO ... iniciando estado de pago.");
        }
    }
}
