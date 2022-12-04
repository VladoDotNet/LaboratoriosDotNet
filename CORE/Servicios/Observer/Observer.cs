using CORE.Interfaces.Observer;
using System.Diagnostics;

namespace CORE.Servicios.Observer
{
    public class Observer : IObserver
    {
        //Los suscriptores concretos realizan algunas acciones
        //en respuesta a las notificaciones emitidas por el editor.
        //Todas estas clases deben implementar la misma interfaz
        //para que el editor no esté acoplado a clases concretas.
        public string NombreSuscriptor { get; set; }

        //Asocia el suscriptor con el subjet (objeto de interes)
        public Observer(string nombreSuscriptor, ISubject subject )
        {
            NombreSuscriptor = nombreSuscriptor;
            subject.RegistrarObserver(this);
        }
        public void Update(string disponiblidad)
        {
            Console.WriteLine("Hola " + NombreSuscriptor + "\n" +
                "El recursos se encuentra en estado : "
                + disponiblidad +"\n");
        }
    }
}
