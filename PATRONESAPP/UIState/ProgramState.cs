using CORE.Servicios.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRONESAPP.UIState
{
    public class ProgramState
    {
        static async Task Main(string[] arg)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine(" PATRONES - State ");
            Console.WriteLine("------------------------");

            char continuar = default;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("PROCESO DE MATRÍCULA ");
                Console.WriteLine("------------------------");

                //Console.Write("Solicitar xxxxx\n" +
                //    "[1] xxxx,\n" +
                //    "[2] xxxx,\n" +
                //    "[3] xxxx : ");
                //var opcion = Convert.ToInt32(Console.ReadLine());

                EstadoContext estadoContext = new EstadoContext(new EstadoSolicitud());
                estadoContext.Request();
                await Task.Delay(4000);

                estadoContext.Request();
                await Task.Delay(4000);

                estadoContext.Request();
                await Task.Delay(4000);

                estadoContext.Request();
                await Task.Delay(4000);


                Console.WriteLine("\n");


                Console.Write("Desea continuar? Sí(s) / No(n)");
                continuar = Console.ReadKey().KeyChar;
                Console.Clear();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine(" PATRONES - xxxxx ");
                Console.WriteLine("---------------------------------------");

            } while (continuar != 'n');
        }
    }
}
