using CORE.Interfaces.State;
using System;

namespace CORE.Servicios.State
{
    public class EstadoContext
    {
        //El contexto almacena una referencia a uno de los objetos de estado concretos y
        //le delega todo el trabajo específico del estado.
        //El contexto se comunica con el objeto de estado a través de la interfaz de estado.
        //El contexto expone un configurador para pasarle un nuevo objeto de estado.
        public EstadoBase Estado { get; set; }
        public EstadoContext(EstadoBase estadoBase )
        {
            Estado = estadoBase;
        }

        public void Request()
        {
            Estado.CambiarEstado(this);
        }
    }
}
