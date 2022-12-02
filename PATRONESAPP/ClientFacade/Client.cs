using CORE.Servicios.Facade;

namespace PATRONESAPP.ClientFacade
{
    public class Client
    {
        // El código del cliente trabaja con subsistemas complejos a través de un simple
        // interfaz proporcionada por Facade.
        // Para la gestiona el ciclo de vida de los subsistemas,
        // es posible que el cliente ni siquiera sepa sobre la existencia
        // del subsistema.
        // Este enfoque le permite mantener la complejidad bajo control.

        public static void CodigoCliente(Facade oFacade)
        {
            Console.WriteLine(oFacade.CargandoSubsistemas());
        }
    }
}
