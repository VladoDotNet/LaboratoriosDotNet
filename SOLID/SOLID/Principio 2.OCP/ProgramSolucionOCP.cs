
using Core.SOLID.Entidades;
using Core.SOLID.Interfaces;
using Core.SOLID.Servicios;
using SOLID.Principio_2.OCP;
using System;

namespace SOLID
{
    class ProgramSoluciónOCP
    {
        //static async Task Main(string[] arg)
        //{

        //    IGenerarInformes oExcel = new GenerarExcel();
        //    IGenerarInformes oWord = new GenerarWord();

        //    Console.WriteLine("-------------------------------------------------");
        //    Console.WriteLine("SOLID - Principio N° 2: Open/Close (OCP) ");
        //    Console.WriteLine("--------------------------------------------------");

        //    char continuar = default;
        //    do
        //    {
        //        Console.WriteLine("\n");
        //        Console.Write("Seleccione el tipo de informe [1 = Excel, 2 = Word] : ");
        //        var Selected = Convert.ToInt32(Console.ReadLine());
               
        //        TipoInfomes oTipoInforme = new TipoInfomes();

        //        var lstTipos = oTipoInforme.ListaTipoInforme();
        //        var RegTipos = lstTipos.FirstOrDefault(i=> i.IDTipoInforme==Selected);

        //        var FechaMatriculas = DateTime.Now.ToString("yyyy-MM-dd");

        //        if (RegTipos == null || FechaMatriculas == null)
        //        {
        //            Console.WriteLine("No existe ese tipo de informes...\n");
        //        }
        //        else
        //        {
        //            switch(Selected)
        //            {
        //                case 1 : await oExcel.NuevoInforme();
        //                    Console.WriteLine($"El informe con fecha :{FechaMatriculas}\n" +
        //                        $"en formato -> {RegTipos.NombreTipoInforme}\n" +
        //                        "se ha generado satisfactoriamente!\n");
        //                    break;

        //                case 2 : await oWord.NuevoInforme();
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
