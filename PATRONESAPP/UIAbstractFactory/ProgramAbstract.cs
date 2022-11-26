


//using Core.Servicios.AbstractFactory;
//using PATRONES.ClientAbtractFactory;

//public class ProgramAbstract
//{
//    static async Task Main(String[] arg)
//    {
//        Cliente oSedeSur;
//        Cliente oSedeNorte;

//        Console.WriteLine("-------------------------------------------");
//        Console.WriteLine(" PATRONES - Abstract Factory Pattern ");
//        Console.WriteLine("-------------------------------------------");

//        char continuar = default;
//        do
//        {
//            Console.WriteLine("\n");
//            Console.WriteLine("FÁBRICA DE PROYECTOS PARA SEDES");
//            Console.WriteLine("--------------------------------");

//            Console.Write("Modalidad: Presencial, Remoto : ");
//            var modalidad = Console.ReadLine();

//            Console.Write("Sede: Sur, Norte : ");
//            var sede = Console.ReadLine();

//            Console.WriteLine("\n");

//            //FÁBRICAS DE PRODUCTOS : PROYECTOS
//            switch (sede)
//            {
//                case "Sur":
//                    oSedeSur = new Cliente(new SedeSur(), modalidad);
//                    Console.WriteLine($"Proyecto creado! \n " +
//                        $"Nombre : {await oSedeSur.CrearProyectosSeminarios(modalidad)}\n " +
//                        $"Modalidad : {modalidad}\n " +
//                        $"Sede : {sede}\n");
//                    break;

//                case "Norte":
//                    {
//                        oSedeNorte = new Cliente(new SedeNorte(), modalidad);
//                        Console.WriteLine($"Proyecto creado! \n " +
//                            $"Nombre : {await oSedeNorte.CrearProyectosInvestigacion(modalidad)}\n " +
//                            $"Modalidad : {modalidad}\n " +
//                            $"Sede : {sede}\n");
//                    }
//                    break;

//                default:
//                    break;
//            }
//            Console.Write("Desea continuar? Sí(s) / No(n)");
//            continuar = Console.ReadKey().KeyChar;
//            Console.Clear();

//            Console.WriteLine("-------------------------------------------");
//            Console.WriteLine(" PATRONES - Abstract Factory Pattern ");
//            Console.WriteLine("-------------------------------------------");

//        } while (continuar != 'n');
//    }
//}
