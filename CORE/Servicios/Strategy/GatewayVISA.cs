using CORE.Interfaces.Strategy;

namespace CORE.Servicios.Strategy
{
    public class GatewayVISA : IGatewayBase
    {
        public string? GatewayActual { get; set; }
        public string? estadoGateway { get; set; } = "Disponible";

        public override void setProveedorGateway(string pasarela)
        {
            Console.WriteLine("SOLICITANDO servicio a la pasarela --> " + pasarela);
            GatewayActual = pasarela;
        }

        public override void getProveedor()
        {
            Console.WriteLine("PASARELA ACTUAL -- > " + GatewayActual);
        }

        public override void getEstadoGateway()
        {
            Console.WriteLine("ESTA PASARELA SE HALLA -- > " + estadoGateway + "\n");
        }
    }
}
