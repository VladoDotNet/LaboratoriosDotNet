//using Core.Interfaces.FactoryMethod;
//using Core.Servicios.FactoryMethod;

//namespace PATRONESAPP.UIProgramFactoryMethod
//{
//    public class ProgramFactoryMethod
//    {
//        static async Task Main(string[] arg)
//        {
//            // FABRICA DE REVISTAS PARA IoT
//            IRevistasAcedemicas oRevista = new RevistasIoTFactory().CrearPublicacion();


//            Console.WriteLine("-------------------------------------");
//            Console.WriteLine(" PATRONES - Factory Method ");
//            Console.WriteLine("-------------------------------------");

//            char continuar = default;
//            do
//            {
//                Console.WriteLine("\n");
//                Console.WriteLine("FÁBRICA DE PUBLICACIONES");
//                Console.WriteLine("------------------------");

//                Console.Write("Solicitar producción de revistas\n" +
//                    "[1] Fabrica IoT,\n" +
//                    "[2] Lenguajes,\n" +
//                    "[3] Programación : ");
//                var fabrica = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("\n");

//                if (oRevista != null)
//                {
//                    switch (fabrica)
//                    {
//                        case 1:
//                            Console.WriteLine(" " +
//                            $"Nueva publicación: {await oRevista.GetNombreRevista()}\n " +
//                            $"Tipo de publicación : {await oRevista.TipoPublicacion()}\n");
//                            break;
//                        default:
//                            Console.WriteLine("Fábrica cerrada...\n");
//                            break;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("No se ha generado la producción...\n");
//                }

//                Console.Write("Desea continuar? Sí(s) / No(n)");
//                continuar = Console.ReadKey().KeyChar;
//                Console.Clear();

//                Console.WriteLine("---------------------------------------");
//                Console.WriteLine(" PATRONES - Factory Method ");
//                Console.WriteLine("---------------------------------------");

//            } while (continuar != 'n');
//        }
//    }
//}
