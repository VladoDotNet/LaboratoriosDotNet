using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.Principio_3.LSP.CasoLSP;

namespace SOLID.Principio_3.LSP
{
    public class ProgramCasoLSP
    {
        //static async Task Main(string[] args)
        //{
        //    ModalidadDistancia oModalidadDistancia = new ModalidadDistancia();
        //    ModalidadSemiPresencial oModalidadSemiPresencial = new ModalidadSemiPresencial();
        //    ModalidadPresencial oModalidadPresencial = new ModalidadPresencial();


        //    Console.WriteLine("-------------------------------------------------");
        //    Console.WriteLine("SOLID - Principio N° 3: Liskov (LSP) ");
        //    Console.WriteLine("--------------------------------------------------");

        //    char continuar = default;
        //    do
        //    {
        //        Console.WriteLine("\n");
        //        Console.Write("Seleccione la modalidad " +
        //            "[1= Distancia, 2= Semipresencial, 3= Presencial] : ");
        //        var ID = Convert.ToInt32(Console.ReadLine());

        //            switch (ID)
        //            {
        //                case 1:
        //                await oModalidadDistancia.ValidarDistancia(ID, "DISTANCIA");
        //                    Console.WriteLine($"Autorizando descuento para modalidad:\n " +
        //                        $"{oModalidadDistancia.Modalidad}\n " +
        //                        $"Bono del -> {oModalidadDistancia.DescuentoModalidad()}%\n\n" +
        //                        "El proceso terminó satisfactoriamente!\n");
        //                    break;

        //                case 2:
        //                await oModalidadSemiPresencial.ValidarSemi(ID, "SEMIPRESENCIAL");
        //                Console.WriteLine($"Autorizando descuento para modalidad:\n " +
        //                    $"{oModalidadSemiPresencial.Modalidad}\n " +
        //                    $"Bono del -> {oModalidadSemiPresencial.DescuentoModalidad()}%\n\n" +
        //                    "El proceso terminó satisfactoriamente!\n");
        //                break;

        //                case 3:
        //                await oModalidadPresencial.ValidarPresencial(ID, "PRESENCIAL");
        //                Console.WriteLine($"Autorizando descuento para modalidad:\n " +
        //                    $"{oModalidadPresencial.Modalidad}\n " +
        //                    $"Bono del -> {oModalidadPresencial.DescuentoModalidad()}%\n\n" +
        //                    "El proceso terminó satisfactoriamente!\n");
        //                break;

        //            default:
        //                    break;
        //            }
        //        Console.Write("Desea continuar? Sí(s) / No(n)");
        //        continuar = Console.ReadKey().KeyChar;
        //        Console.Clear();

        //        Console.WriteLine("-------------------------------------------------");
        //        Console.WriteLine("SOLID - Principio N° 3: Liskov (LSP) ");
        //        Console.WriteLine("--------------------------------------------------");

        //    } while (continuar != 'n');
        //}

    }
}
