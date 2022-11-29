using CORE.Interfaces.Observer;

namespace CORE.Servicios.Observer
{
    public class Observer : IObserver
    {
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
