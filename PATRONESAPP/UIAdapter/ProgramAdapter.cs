//using CORE.Servicios.Adapter;

//namespace PATRONESAPP.UIAdapter
//{
//    public class ProgramAdapter
//    {
//        static async Task Main(string[] arg)
//        {
//            ProfesorPlanta ProfesorPlanta = new ProfesorPlanta();
//            AdapterPVirtual adapterPVirtual = new AdapterPVirtual();

//            Console.WriteLine("-----------------------------");
//            Console.WriteLine(" PATRONES - Adapter  ");
//            Console.WriteLine("-----------------------------");

//            char continuar = default;
//            Console.WriteLine("\n");
//            Console.WriteLine("GESTION CARGAS DE PROFESORES");
//            Console.WriteLine("------------------------------");

//            Console.Write("ANTES de insertar el ADAPTEE . . .\n");

//            Console.WriteLine("\n");

//            ProfesorPlanta.Cursos();
//            ProfesorPlanta.Salones();
//            await Task.Delay(3000);
//            ProfesorPlanta.AgendaHorarios();
//            await Task.Delay(3000);
//            ProfesorPlanta.AtencionEstudiantes();
//            await Task.Delay(5000);

//            Console.WriteLine("\n");

//            Console.Write("INSERTANDO el ADAPTEE (PROFESORES VIRTUALES) . . .\n");
//            await Task.Delay(6000);

//            Console.WriteLine("\n");

//            adapterPVirtual.Cursos();
//            adapterPVirtual.Salones();
//            await Task.Delay(3000);
//            adapterPVirtual.AgendaHorarios();
//            adapterPVirtual.AtencionEstudiantes();
//            await Task.Delay(3000);
//            adapterPVirtual.ServiciosVarios();


//        }
//    }
//}
