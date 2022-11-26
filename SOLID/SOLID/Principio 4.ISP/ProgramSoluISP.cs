using Core.SOLID.Entidades;
using Core.SOLID.Interfaces;
using Core.SOLID.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principio_4.ISP
{
    public class ProgramSoluISP
    {
        //static async Task Main(string[] args)
        //{
        //    IServicioSalones oServicioSalones = new ServiciosSalones();
        //    IServiciosBiblioteca oServiciosBiblioteca = new ServiciosBiblioteca();
        //    IServiciosTutorias oServiciosTutorias = new ServiciosTutorias();


        //    Console.WriteLine("----------------------------------------------------");
        //    Console.WriteLine("SOLID - Principio N° 4: Interfaces Segregation (ISP) ");
        //    Console.WriteLine("----------------------------------------------------");

        //    char continuar = default;
        //    do
        //    {
        //        Console.WriteLine("\n");
        //        Console.Write("Seleccione el servicio " +
        //            "[1= Reserva salones, 2= Reserva libros, 3= Tutorias] : ");
        //        var IDServicio = Convert.ToInt32(Console.ReadLine());

        //        Console.Write("Código del estudiante: ");
        //        var IDEstu = Convert.ToInt32(Console.ReadLine());

        //        // VALIDAR EL ESTUDIANTE...
        //        Estudiante estudiante = new Estudiante();
        //        var lstEstudiante = estudiante.listaEstudiantes();

        //        var RegEstudiante = lstEstudiante.FirstOrDefault(
        //            e => e.IDEstudiante == IDEstu);

        //        if (lstEstudiante == null)
        //        {
        //            Console.WriteLine("El estudiante no existe");
        //        }

        //        else
        //        {
        //            DateTime FEntrega = DateTime.Now;
        //            DateTime FPlazo = FEntrega.AddDays(15);
        //            switch (IDServicio)
        //            {
        //                case 1:
        //                    await oServicioSalones.GestionSalones
        //                        (IDEstu, "Salón A", DateTime.Today);
        //                    Console.WriteLine($"Salón reservado para el estudiante: \n " +
        //                        $"Carnet: {RegEstudiante.IDEstudiante}\n " +
        //                        $"Nombre: {RegEstudiante.NombreEstudiante}\n");
        //                    break;

        //                case 2:
        //                    await oServiciosBiblioteca.GestionPrestamos
        //                        (IDEstu, "ISBN:1010-B7",
        //                        DateTime.Today,DateTime.Today);
        //                    Console.WriteLine($"Libro en préstamo reservado para el estudiante: \n " +
        //                        $"Carnet: {RegEstudiante.IDEstudiante}\n " +
        //                        $"Nombre: {RegEstudiante.NombreEstudiante}\n " +
        //                        $"ISBN : ISBN:1010-B7\n " +
        //                        $"Fecha de reserva: {DateTime.Today.ToLongDateString()}\n " +
        //                        $"Fecha de devolución: {FPlazo.ToLongDateString()}\n");
        //                    break;

        //                case 3:
        //                    await oServiciosTutorias.Tutorias
        //                        (IDEstu, 1010,
        //                        DateTime.Today);
        //                    Console.WriteLine($"Tutoría reservada para el estudiante: \n " +
        //                        $"Carnet: {RegEstudiante.IDEstudiante}\n " +
        //                        $"Nombre: {RegEstudiante.NombreEstudiante}\n " +
        //                        $"Fecha de la tutoría: {FPlazo.ToLongDateString()}\n");
        //                    break;

        //                default:
        //                    break;
        //            }
        //        }
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
