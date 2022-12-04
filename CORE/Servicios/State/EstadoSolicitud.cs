using CORE.Interfaces.State;

namespace CORE.Servicios.State
{
    public class EstadoSolicitud : EstadoBase
    {
        //Los Estados concretos proporcionan sus propias implementaciones
        //para los métodos específicos del Estado.
        //Para evitar la duplicación de código similar en varios estados,
        //puede proporcionar clases abstractas intermedias
        //que encapsulen algún comportamiento común.
        public override void CambiarEstado(EstadoContext estadoContext)
        {
            //CAMBIO DE ESTADO AL SIGUIENTE PROCESO
            estadoContext.Estado = new EstadoVerificado();
            Console.WriteLine("PROCESANDO ESTADO ... iniciando estado de verificación.");
        }
    }
}
