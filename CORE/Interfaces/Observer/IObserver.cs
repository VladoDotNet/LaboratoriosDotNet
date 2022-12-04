namespace CORE.Interfaces.Observer
{
    //    Suscriptores, usuarios.
    //Con un método de notificación específico
    //que recibe la notificación del editor.
    //Pueden abandonar la lista del editor.

    public interface IObserver
    {
        //ACTUALIZA LA DISPONIBILIDAD DEL SUBJET...
        void Update(string disponiblidad);
    }
}
