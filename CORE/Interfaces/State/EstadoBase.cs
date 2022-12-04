using CORE.Servicios.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Interfaces.State
{
    //La interfaz de estado declara los métodos específicos del estado.
    //Estos métodos deberían tener sentido para todos los estados concretos
    //porque no quieres que algunos de tus estados
    //tengan métodos inútiles que nunca serán llamados.
    public abstract class EstadoBase
    {
        public abstract void CambiarEstado(EstadoContext estadoContext);
    }
}
