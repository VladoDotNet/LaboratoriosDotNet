
using Core.SOLID.Entidades;
using SOLID.Principio_2.OCP;
using System;

namespace SOLID
{
    class ProgramCasoLSP
    {
        //static async Task Main(string[] arg)
        //{

        //    CasoOCP oCasoOCP = new CasoOCP();

        //    Console.WriteLine("-------------------------------------------------");
        //    Console.WriteLine("SOLID - Principio N° 2: Open/Close (OCP) ");
        //    Console.WriteLine("--------------------------------------------------");

        //    char continuar = default;
        //    do
        //    {
        //        Console.WriteLine("\n");
        //        Console.Write("Seleccione el tipo de informe [1 = Excel, 2 = Word] : ");
        //        var ID = Convert.ToInt32(Console.ReadLine());
               
        //        TipoInfomes oTipoInforme = new TipoInfomes();
        //        //Matricula oMatricula = new Matricula();

        //        var lstTipos = oTipoInforme.ListaTipoInforme();
        //        var RegTipos = lstTipos.FirstOrDefault(i=> i.IDTipoInforme==ID);

        //        //var lstMatriculas = oMatricula.ListaMatriculas();
        //        var FechaMatriculas = DateTime.Now.ToString("yyyy-MM-dd");

        //        if (RegTipos == null || FechaMatriculas == null)
        //        {
        //            Console.WriteLine("No existe ese tipo de informes...\n");
        //        }
        //        else
        //        {
        //            switch(ID)
        //            {
        //                case 1 : await oCasoOCP.InformeEXCEL();
        //                    Console.WriteLine($"El informe con fecha :{FechaMatriculas}\n" +
        //                        $"en formato -> {RegTipos.NombreTipoInforme}\n" +
        //                        "se ha generado satisfactoriamente!\n");
        //                    break;

        //                case 2 : await oCasoOCP.InformeWord();
        //                    Console.WriteLine($"El informe con fecha :{FechaMatriculas}\n" +
        //                        $"en formato -> {RegTipos.NombreTipoInforme}\n" +
        //                        "se ha generado satisfactoriamente!\n");
        //                    break;

        //                default:
        //                break;
        //            }
        //        }
        //        Console.Write("Desea continuar? Sí(s) / No(n)");
        //        continuar = Console.ReadKey().KeyChar;
        //        Console.Clear();

        //        Console.WriteLine("-------------------------------------------------");
        //        Console.WriteLine("SOLID - Principio N°2: Open/Close (OCP) ");
        //        Console.WriteLine("--------------------------------------------------");

        //    } while (continuar != 'n');
        //}
    }
}

// PRUEBAS ....
//Console.WriteLine("Principios SOLID");
//Console.WriteLine("Cuál es su nombre?");
//var varNombreUser = Console.ReadLine();
//varNombreUser = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(varNombreUser));
//var varFecha = DateTime.Now.ToString("dd/MMMM/yyyy", CultureInfo.InvariantCulture);
//var varHora = DateTime.Now;
//Console.WriteLine($"{Environment.NewLine}" +
//    $"Bienvenido(a) {varNombreUser}! " +
//    $"Su registro fue el:");
//Console.WriteLine($"{Environment.NewLine}" +
//    $"{varFecha:d} " +
//    $"a las  {varHora:t}");

//Console.Write($"{Environment.NewLine}" +
//    $"{varNombreUser}, presiona cualquier tecla para salir...");
//Console.ReadKey(true);
