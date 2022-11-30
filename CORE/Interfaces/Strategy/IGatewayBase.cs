namespace CORE.Interfaces.Strategy
{
    public abstract class IGatewayBase
    {
        public abstract void setProveedorGateway(string pasarela);
        public abstract void getProveedor();
        public abstract void getEstadoGateway();
    }
}
