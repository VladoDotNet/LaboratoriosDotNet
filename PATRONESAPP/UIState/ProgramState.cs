//using CORE.Servicios.State;

//namespace PATRONESAPP.UIState
//{
//    public class ProgramState
//    {
//        static async Task Main(string[] arg)
//        {
//            Console.WriteLine("------------------------");
//            Console.WriteLine(" PATRONES - State ");
//            Console.WriteLine("------------------------");

//            char continuar = default;
//            do
//            {
//                Console.WriteLine("\n");
//                Console.WriteLine("PROCESO DE MATRÍCULA ");
//                Console.WriteLine("------------------------");


//                EstadoContext estadoContext = new EstadoContext(new EstadoSolicitud());
//                estadoContext.Request();
//                await Task.Delay(4000);
//                Console.WriteLine("Solicitud revisada. VoB Ok!\n");

//                estadoContext.Request();
//                await Task.Delay(4000);
//                Console.WriteLine("Verificación de documentos y soportes. VoB Ok!\n");

//                estadoContext.Request();
//                await Task.Delay(4000);
//                Console.WriteLine("Se confirma pago de matrícula. VoB Ok!\n");

//                estadoContext.Request();
//                await Task.Delay(4000);
//                Console.WriteLine("el estudiante ha sido matriculado para el semestre. VoB Ok!\n");


//                Console.WriteLine("\n");


//                Console.Write("Desea continuar? Sí(s) / No(n)");
//                continuar = Console.ReadKey().KeyChar;
//                Console.Clear();

//                Console.WriteLine("-------------------------");
//                Console.WriteLine(" PATRONES - State ");
//                Console.WriteLine("-------------------------");

//            } while (continuar != 'n');
//        }
//    }
//}
