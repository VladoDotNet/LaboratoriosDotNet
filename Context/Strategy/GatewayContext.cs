using CORE.Interfaces.Strategy;

namespace Infraestructura.Strategy
{
    /// <summary>
    /// MIDDLWARE...
    /// </summary>
    public class GatewayContext
    {
        private IGateway _gateway;
        public GatewayContext(IGateway gateway)
        {
            _gateway = gateway;
        }

        //MÉTODOS DE GESTIÓN...
        public void GestionPasarela(string pasarela)
        {
            _gateway.setProveedorGateway(pasarela);
        }

         public void SetStrategyPasarela(IGateway setGateway)
        {
            _gateway = setGateway;
        }

        public void gettingProveedor()
        {
            _gateway.getProveedor();
        }

        public void gettingEstado()
        {
            _gateway.getEstadoGateway();
        }
    }
}
