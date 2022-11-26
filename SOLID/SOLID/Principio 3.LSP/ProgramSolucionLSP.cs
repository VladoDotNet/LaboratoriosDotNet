

using static SOLID.Principio_3.LSP.SolucionLSP;

namespace SOLID.Principio_3.LSP
{
    public class ProgramSolucionLSP
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
        //                    Console.WriteLine($"Autorizando descuento para modalidad:  " +
        //                        $"{oModalidadDistancia.Modalidad}\n " +
        //                        $"Bono del -> {oModalidadDistancia.DescuentoModalidad()}%\n\n " +
        //                        $"Precio de la matrícula -> $USD{oModalidadDistancia.PrecioMatriculas}\n " +
        //                        $"Total a a pagar -> $USD{oModalidadDistancia.TotalPago()}\n\n " +
        //                        "El proceso terminó satisfactoriamente!\n");
        //                break;

        //                case 2:
        //                await oModalidadSemiPresencial.ValidarSemi(ID, "SEMIPRESENCIAL");
        //                Console.WriteLine($"Autorizando descuento para modalidad:  " +
        //                    $"{oModalidadSemiPresencial.Modalidad}\n " +
        //                    $"Bono del -> {oModalidadSemiPresencial.DescuentoModalidad()}%\n\n " +
        //                    $"Precio de la matrícula -> $USD{oModalidadSemiPresencial.PrecioMatriculas}\n " +
        //                    $"Total a a pagar -> $USD{oModalidadSemiPresencial.TotalPago()}\n\n " +
        //                    "El proceso terminó satisfactoriamente!\n");
        //                break;

        //                case 3:
        //                await oModalidadPresencial.ValidarPresencial(ID, "PRESENCIAL");
        //                Console.WriteLine($"Autorizando descuento para modalidad ->  " +
        //                    $"{oModalidadPresencial.Modalidad}\n " +
        //                    $"Bono del -> {oModalidadPresencial.DescuentoModalidad()}\n\n " +
        //                    $"Precio de la matrícula -> $USD{oModalidadPresencial.PrecioMatriculas}\n " +
        //                    $"Total a a pagar -> $USD{oModalidadPresencial.TotalPago()}\n\n " +
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
