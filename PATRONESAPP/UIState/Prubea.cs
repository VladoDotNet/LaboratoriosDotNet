using System;
using System.Linq;
using CORE.Servicios.State;

namespace PATRONESAPP.UIState
{
    public class DEMO
    {
        static async Task Main(string[] arg)
        {
            string mama = "Mi mama me mima";

            var result = mama.Reverse();
            Console.Write(string.Join("", result));

            //var arreglo = mama.ToCharArray();
            //for (int y = arreglo.Length -1; y >= 0; y--)
            //{
            //    Console.Write(arreglo[y]);

            //}
            Console.ReadLine();

            // 

            //}
            //string mama = "Mi mama me mima";
            //var arreglo = mama.ToCharArray();
            //for (int i = arreglo.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arreglo[i]);
            //}
        }
    }
}
