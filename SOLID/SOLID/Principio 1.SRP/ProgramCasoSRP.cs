
using Core.SOLID.Entidades;
using SOLID.Principio_1.SRP;

namespace SOLID
{
    class ProgramCasoSRP
    {
        //static async Task Main(string[] arg)
        //{

        //    CasoSRP casoSRP = new CasoSRP();

        //    Console.WriteLine("-------------------------------------------------");
        //    Console.WriteLine("SOLID - Principio N°1: Single Responsability (SRP) ");
        //    Console.WriteLine("--------------------------------------------------");

        //    char continuar = default;
        //    do
        //    {
        //        Console.WriteLine("\n");
        //        Console.Write("Código del estudiante a matricular: ");
        //        var ID = Convert.ToInt32(Console.ReadLine());

        //        Estudiante estudiante = new Estudiante();

        //        var oEstudiante = estudiante.listaEstudiantes();

        //        var RegEstudiante = oEstudiante.FirstOrDefault(e => e.IDEstudiante == ID);

        //        if (RegEstudiante == null)
        //        {

        //            Console.WriteLine($"El estudiante con código : {ID}, no se halla en la DBS!\n");

        //        }
        //        else
        //        {
        //            await casoSRP.ValidarEstudiante(RegEstudiante);
        //            Console.WriteLine($"El estudiante con código -> {ID}, ha sido verificado...\n");

        //            //Validar pago..
        //            await casoSRP.ValidarPago(ID);
        //            Console.WriteLine($"El pago de {RegEstudiante.NombreEstudiante}, " +
        //                $"es válido\n");

        //            //Registro de matrícula...
        //            await casoSRP.RegMatricula(ID);
        //            Console.WriteLine($"Registro de la matrícula exitoso!...\n");

        //            //Despachando mail con Recibo de pago...
        //            await casoSRP.MailMatricula(ID);
        //            Console.WriteLine($"El despacho del recibo de pago ha sido exitoso!...\n");
        //        }
        //        Console.Write("Desea continuar? Sí(s) / No(n)");
        //        continuar = Console.ReadKey().KeyChar;
        //        Console.Clear();

        //        Console.WriteLine("-------------------------------------------------");
        //        Console.WriteLine("SOLID - Principio N°1: Single Responsability (SRP) ");
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
