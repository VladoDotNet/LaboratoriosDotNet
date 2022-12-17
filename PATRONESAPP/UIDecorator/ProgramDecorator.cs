using CORE.Servicios.Decorator;
using PATRONESAPP.ClientDecorator;

namespace PATRONESAPP.UIDecorator
{
    internal class ProgramDecorator
    {
        static async Task Main(string[] arg)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(" PATRONES - Decorator  ");
            Console.WriteLine("----------------------------");

            //REQUEST CLIENTE...
            Cliente cliente = new Cliente();
            var compBasico = new ComponenteBasico();
            DecoradorConcretoA concretoA = new DecoradorConcretoA(compBasico);
            DecoradorConcretoB concretoB = new DecoradorConcretoB(concretoA);
            DecoradorConcretoC concretoC = new DecoradorConcretoC(concretoB);

            char continuar = default;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("SERVICIOS DECORACIÓN DE OBJETO BASE ");
                Console.WriteLine("------------------------------------");

                Console.Write("Solicitar decoración con componentes:\n" +
                    "[1] BÁSICO,\n" +
                    "[2] CON CARACTERÍSTICA A,\n" +
                    "[3] CON CARACTERÍSTICAS A Y B,\n" +
                    "[4] CON TODAS LAS CARACTERÍSTICAS...\n" +
                    "Seleccione su decorado : ");

                var decorado = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");

                switch (decorado)
                {
                    case 1:
                        //var compBasico = new ComponenteBase();
                        Console.WriteLine("Solicitud de decorado BÁSICO...\n");
                        await Task.Delay(3000);
                        cliente.CodigoCliente(compBasico);
                        break;

                    case 2:
                        Console.WriteLine("Adicionar al decorado BÁSICO característica A...\n");
                        await Task.Delay(3000);
                        cliente.CodigoCliente(concretoA);
                        break;
                    case 3:
                        Console.WriteLine("Adicionar al decorado las características A y Básico...\n");
                        await Task.Delay(3000);
                        cliente.CodigoCliente(concretoB);
                        break;
                    case 4:
                        Console.WriteLine("Adicionar al decorado TODAS  las características...\n");
                        await Task.Delay(3000);
                        cliente.CodigoCliente(concretoC);
                        break;
                    default:
                        Console.WriteLine("Solicite a la administración las que no estén en listas...\n");
                        break;
                }

                Console.WriteLine("\n");
                Console.Write("Desea continuar? Sí(s) / No(n)");
                continuar = Console.ReadKey().KeyChar;
                Console.Clear();

                Console.WriteLine("--------------------------------");
                Console.WriteLine(" PATRONES - Decorator  ");
                Console.WriteLine("------------------------------\n");

            } while (continuar != 'n');
        }
    }
}
