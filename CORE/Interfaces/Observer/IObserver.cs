namespace CORE.Interfaces.Observer
{
    //   SUSCRIPTOR, USUARIO

    //Con un método de notificación específico
    //que recibe la notificación del editor.
    //Pueden abandonar la lista del editor.

    public interface IObserver
    {
        //ACTUALIZA LA DISPONIBILIDAD DEL SUBJET...
        void Update(string disponiblidad);
    }
}
