using CORE.Interfaces.Strategy;
using System;

namespace CORE.Servicios.Strategy
{
    //Variantes del algorítmo. Presta el servicio para cada tipo de estrategia
    //con una clase especializada por cada uno de los tipos.
    //Llama al método de ejecución en el objeto de estrategia concreta
    //cada vez que necesita ejecutar el algoritmo.

    public class GatewayDinners : IGatewayBase
    {
        public string? GatewayActual { get; set; }
        public string? estadoGateway { get; set; } = "Ocupada";

        public override void setProveedorGateway(string pasarela)
        {
            Console.WriteLine("SOLICITANDO servicio a la pasarela --> " + pasarela );
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
