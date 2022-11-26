namespace SOLID.Principio_5.IoC
{
    public class ProgramCasoIoC
    {
        //static async Task Main(string[] args)
        //{
        //    RegistroIngresos oRegistroIngresos = new RegistroIngresos();


        //    Console.WriteLine("----------------------------------------------------");
        //    Console.WriteLine("SOLID - Principio N° 5: Inversion of Control (IoC) ");
        //    Console.WriteLine("----------------------------------------------------");

        //    char continuar = default;
        //    do
        //    {
        //        Console.WriteLine("\n");
        //        Console.WriteLine("Caputarando datos biométricos del estudiante..." );
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
        //            DateTime FechaIngreso = Convert.ToDateTime(
        //                DateTime.Now.ToString("T"));

        //            Console.WriteLine("\n");
        //            Console.WriteLine($"PROCESANDO....registro biométrico");
        //            oRegistroIngresos.RegistrarIngreso(IDEstu, 
        //                FechaIngreso);
        //            await Task.Delay(4000);

        //            Console.WriteLine("Registro exitoso...\n" +
        //                $"Estudiante : {RegEstudiante.NombreEstudiante}\n " +
        //                $"Fecha de ingreso : {FechaIngreso}\n ");

        //        }
        //        Console.Write("Desea continuar? Sí(s) / No(n)");
        //        continuar = Console.ReadKey().KeyChar;
        //        Console.Clear();

        //        Console.WriteLine("----------------------------------------------------");
        //        Console.WriteLine("SOLID - Principio N° 5: Inversion of Control (IoC) ");
        //        Console.WriteLine("----------------------------------------------------");

        //    } while (continuar != 'n');
        //}

    }
}
