using CORE.Servicios.Decorator;
using PATRONESAPP.ClientDecorator;

namespace PATRONESAPP.UIDecorator
{
    internal class ProgramDecorator
    {
        static void Main(string[] arg)
        {
            //Atender la solicitud incompatible...
            Cliente cliente = new Cliente();

            var compBasico = new ComponenteConcreto();
            Console.WriteLine("Solicitud de componente básico...");
            cliente.CódigoCliente(compBasico);
            Console.WriteLine();

            DecoradorConcretoA concretoA = new DecoradorConcretoA(compBasico);
            DecoradorConcretoB concretoB = new DecoradorConcretoB(concretoA);
            Console.WriteLine("Solicitud de componente con decoración adicional");
            cliente.CódigoCliente(concretoB);


            ////Objeto tipo interface para pasar al
            //// Adaptador el objeto tipo servicio incompatible...
            //ITarget target = new Adapter(adapteeServicio);

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine(" PATRONES - Adapter Pattern ");
            //Console.WriteLine("-------------------------------------");

            //char continuar = default;
            //do
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("SERVICIOS DE CONVERSIÓN DE FORMATOS");
            //    Console.WriteLine("-----------------------------------");

            //    Console.Write("Solicitar producción de revistas en formato:\n" +
            //        "[1] XML,\n" +
            //        "[2] JSON,\n" +
            //        "[3] TEXTO PLANO,\n" +
            //        "[4] OTRO...\n" +
            //        "Seleccione un formato : ");
            //    var formato = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("\n");

            //    switch (formato)
            //    {
            //        case 1:
            //            Console.WriteLine("Solicitando servicio de formateo...");
            //            await target.PrecesarFormatosEscuela("XML");
            //            break;

            //        case 2:
            //            Console.WriteLine("Solicitando servicio de formateo...");
            //            await target.PrecesarFormatosEscuela("JSON");
            //            break;
            //        case 3:
            //            Console.WriteLine("Solicitando servicio de formateo...");
            //            await target.PrecesarFormatosEscuela("TEXTO PLANO");
            //            break;
            //        default:
            //            Console.WriteLine("Se procede a solucionar servicio incompatible...");
            //            await target.PrecesarFormatosEscuela("OTRO");
            //            break;
            //    }

            //    Console.Write("Desea continuar? Sí(s) / No(n)");
            //    continuar = Console.ReadKey().KeyChar;
            //    Console.Clear();

            //    Console.WriteLine("---------------------------------------");
            //    Console.WriteLine(" PATRONES - Factory Method ");
            //    Console.WriteLine("---------------------------------------");

            //} while (continuar != 'n');
        }
    }
}
