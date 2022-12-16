namespace CORE.Interfaces.Strategy
{
    public abstract class IGateway
    {
        public abstract void setProveedorGateway(string pasarela);
        public abstract void getProveedor();
        public abstract void getEstadoGateway();
    }
}
