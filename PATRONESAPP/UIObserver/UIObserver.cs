using CORE.Servicios.Observer;

namespace PATRONESAPP.UIObserver
{
    public class UIObserver
    {
        static async Task Main(string[] arg)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(" PATRONES - Observer ");
            Console.WriteLine("----------------------------");

            Console.WriteLine("\n");
            Console.WriteLine("SERVICIO DE RECURSOS ");
            Console.WriteLine("----------------------\n");

            //Simulación recursos...
            Console.WriteLine("PROCESANDO.... creando el recurso...\n");
            Subject recursoPublicacion = new Subject("Blazor desde cero!", 79.99, "Agotado");
            await Task.Delay(3000);

            Console.WriteLine("RECURSOS.... recurso creado :");
            recursoPublicacion.nRecurso();
            Console.WriteLine("");

            //Simulación para REGISTRO de suscriptores (Observadores, usuarios)
            Console.WriteLine("PROCESANDO.... registrando los suscripciones :\n");
            Observer observer1 = new Observer("Verónica", recursoPublicacion);
            await Task.Delay(2000);
            Observer observer2 = new Observer("Astrid", recursoPublicacion);
            await Task.Delay(2000);
            Observer observer3 = new Observer("César", recursoPublicacion);
            await Task.Delay(7000);

            Console.WriteLine();

            Console.WriteLine("ESTADO ACTUAL DEL RECURSO : ");
                recursoPublicacion.nRecurso(); 
                recursoPublicacion.GetEstadoDisponible();
            await Task.Delay(2000);

            Console.WriteLine();

            //Simulacion de NOTIFICCIÓN MASIVA...
            recursoPublicacion.setEstadoDisponible("Disponible!");
            await Task.Delay(3000);

            Console.Read();
        }
    }
}
