namespace CORE.Interfaces.Strategy
{
    //Clase abstrácta o interface común a todas las estrategias concretas.
    //Declara un método que el contexto utiliza para ejecutar una estrategia.
    public abstract class IGatewayBase
    {
        public abstract void setProveedorGateway(string pasarela);
        public abstract void getProveedor();
        public abstract void getEstadoGateway();
    }
}
