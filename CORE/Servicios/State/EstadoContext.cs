using CORE.Interfaces.State;
namespace CORE.Servicios.State
{
    public class EstadoContext
    {
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
