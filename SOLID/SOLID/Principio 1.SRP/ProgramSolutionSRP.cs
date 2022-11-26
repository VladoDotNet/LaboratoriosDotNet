using Core.SOLID.Entidades;
using Core.SOLID.Interfaces;
using Core.SOLID.Servicios;

namespace SOLID.Principio_1.SRP
{
    public class ProgramSolutionSRP
    {
    //    static async Task Main(string[] arg)
    //    {
    //        IGestionMatricula gestionMatricula = new GestionMatricula();

    //        Console.WriteLine("---------------------------------------------------");
    //        Console.WriteLine(" SOLID - Principio N°1: Single Responsability (SRP) ");
    //        Console.WriteLine("---------------------------------------------------");

    //        char continuar = default;
    //        do
    //        {
    //            Console.WriteLine("\n");
    //            Console.Write("Código del estudiante a matricular: ");
    //            var ID = Convert.ToInt32(Console.ReadLine());

    //            Estudiante estudiante = new Estudiante();

    //            var oEstudiante = estudiante.listaEstudiantes();

    //            var RegEstudiante = oEstudiante.FirstOrDefault(e => e.IDEstudiante == ID);

    //            if (RegEstudiante == null)
    //            {
    //                Console.WriteLine($"El estudiante con código: [{ID}] no se halla en la DBS!\n");
    //            }
    //            else
    //            {
    //                await gestionMatricula.ValidarEstudiante(RegEstudiante);
    //                Console.WriteLine($"El estudiante con código: [{ID}] ha sido verificado...\n");

    //                //Validar pago..
    //                await gestionMatricula.ValidarPago(ID);
    //                Console.WriteLine($"El pago del estudiante [{RegEstudiante.NombreEstudiante}], " +
    //                    $"es válido\n");

    //                //Registro de matrícula...
    //                await gestionMatricula.RegMatricula(ID);
    //                Console.WriteLine($"Registro de la matrícula exitoso!...\n");

    //                //Despachando mail con Recibo de pago...
    //                await gestionMatricula.MailMatricula(ID, "@Buzon", "Asunto");
    //                Console.WriteLine(
    //                    $"RESUMEN DEL DESPACHO:\n " +
    //                    $"Estudiante: {RegEstudiante.CorreoEstudiante}\n " +
    //                    $"Asunto: {RegEstudiante.AsuntoMailEstudiante}\n " +
    //                    $"Adjunto: Invoice\n\n" +
    //                    $"El despacho ha sido exitoso!...\n");
    //            }
    //            Console.Write("Desea continuar? Sí(s) / No(n)");
    //            continuar = Console.ReadKey().KeyChar;
    //            Console.Clear();

    //            Console.WriteLine("-------------------------------------------------");
    //            Console.WriteLine("SOLID - Principio N°1: Single Responsability (SRP) ");
    //            Console.WriteLine("--------------------------------------------------");

    //        } while (continuar != 'n');
    //    }
    }
}
