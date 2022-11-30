using CORE.Servicios.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Interfaces.State
{
    public abstract class EstadoBase
    {
        public abstract void CambiarEstado(EstadoContext estadoContext);
    }
}
