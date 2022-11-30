//using CORE.Servicios.Strategy;
//using Infraestructura.Strategy;

//namespace PATRONESAPP.UIStrategy
//{
//    public class ProgramStrategy
//    {
//        static async Task Main(string[] arg)
//        {
//            Console.WriteLine("---------------------------");
//            Console.WriteLine(" PATRONES - Strategy ");
//            Console.WriteLine("---------------------------");

//            GatewayContext _ContextDinners = new GatewayContext(new GatewayDinners());
//            GatewayContext _ContextVISA = new GatewayContext(new GatewayVISA());


//            char continuar = default;
//            do
//            {
//                Console.WriteLine("\n");
//                Console.WriteLine("SERVICIOS DE PAGO ");
//                Console.WriteLine("-------------------");

//                Console.WriteLine("Pasarelas disponibles : \n" +
//                    "[1] Dinners,\n" +
//                    "[2] VISA");
//                Console.Write("Selecione su pasarela : ");
//                var opcion = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("\n");

//                switch (opcion)
//                {
//                    case 1:
//                        _ContextDinners.GestionPasarela("Dinners");
//                        await Task.Delay(3000);
//                        _ContextDinners.gettingEstado();

//                        Console.WriteLine("Ubicando otras pasarelas disponibles....\n");
//                        _ContextVISA.GestionPasarela("VISA");
//                        await Task.Delay(5000);
//                        _ContextVISA.gettingEstado();

//                        Console.Write("¿Desea conmutar de pasarela (Strategy)? Sí(s) / No(n)");
//                        var conmutar = Console.ReadKey().KeyChar;
//                        Console.WriteLine("\n");

//                        if (conmutar == 's')
//                        {
//                            Console.WriteLine("PROCESANDO LA TRANSACCIÓN . . . espere por favor\n");
//                            _ContextVISA.SetStrategyPasarela(new GatewayVISA());
//                            await Task.Delay(5000);
//                            Console.WriteLine("Transacción exitosa!");
//                        }
//                        break;
//                    case 2:
//                        _ContextVISA.GestionPasarela("VISA");
//                        await Task.Delay(3000);
//                        _ContextVISA.gettingEstado();

//                        Console.WriteLine("PROCESANDO LA TRANSACCIÓN . . . espere por favor\n");
//                        _ContextVISA.SetStrategyPasarela(new GatewayVISA());
//                        await Task.Delay(5000);
//                        Console.WriteLine("Transacción exitosa!");
//                        break;
//                }

//                Console.Write("Desea continuar? Sí(s) / No(n)");
//                continuar = Console.ReadKey().KeyChar;
//                Console.Clear();

//                Console.WriteLine("---------------------------");
//                Console.WriteLine(" PATRONES - Strategy ");
//                Console.WriteLine("---------------------------");

//            } while (continuar != 'n');
//        }
//    }
//}
