//using CORE.Interfaces.Adapter;
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
//            ProfesorPlanta.AgendaHorarios();
//            ProfesorPlanta.AtencionEstudiantes();
//            await Task.Delay(5000);

//            Console.WriteLine("\n");

//            Console.Write("INSERTANDO el ADAPTEE . . .\n");
//            await Task.Delay(3000);
//            adapterPVirtual.Cursos();
//            adapterPVirtual.Salones();
//            adapterPVirtual.AgendaHorarios();
//            adapterPVirtual.AtencionEstudiantes();
//        }
//    }
//}
