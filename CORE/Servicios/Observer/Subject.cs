using CORE.Interfaces.Observer;

namespace CORE.Servicios.Observer
{
    public class Subject : ISubject
    {
        private List<IObserver> lstObservers = new List<IObserver>();
        private string? NombreRecurso { get; set; }
        private double PrecioRecurso { get; set; }
        private string? EstadoDisponible { get; set; }

        public Subject(string nombreRecurso, 
            double precioRecurso, string estadoDisponible)
        {
            NombreRecurso= nombreRecurso;
            PrecioRecurso=precioRecurso;
            EstadoDisponible=estadoDisponible;
        }
        
        public string GetEstadoDisponible()
        {
            return EstadoDisponible;
        }
        
        public void setEstadoDisponible(string estadoDisponible)
        {
            EstadoDisponible = estadoDisponible;
            Console.WriteLine("Estado disponible modificado...");
            NotificarObservadores();
        }

        public override void NotificarObservadores()
        {
            Console.WriteLine("NOTIFICACIÓN MASIVA... \n" +
                NombreRecurso + "," + PrecioRecurso + "" + "se encuentra disponible!");

            //Notificación a todos los OBSERVADORES registrados...
            Console.WriteLine();
            foreach (IObserver observer in lstObservers)
            {
                Console.WriteLine();
                observer.Update(EstadoDisponible);
            }
        }

        public override void RegistrarObserver(IObserver observer)
        {
            Console.WriteLine("Suscriptor registrado : " +
                    ((Observer)observer).NombreSuscriptor);
            
            lstObservers.Add(observer);
        }

        public override void RemoveObservador(IObserver observer)
        {
            Console.WriteLine("Suscriptor eliminado : " +
                    ((Observer)observer).NombreSuscriptor);

            lstObservers.Remove(observer);
        }

        public override void nRecurso()
        {
            Console.WriteLine(NombreRecurso);
        }
    }
}
