using System;

namespace CORE.Interfaces.Observer
{
    //Editor, Objeto observado, Contiene  mecanísmo de suscripción.
    //Equivale a una lista con referencias al objeto observador suscriber.
    //Sabe qué suscriptores están a la espera de notificaciones.
    public abstract class ISubject
    {
        public abstract void nRecurso();
        public abstract void RegistrarObserver(IObserver observer);
        public abstract void RemoveObservador(IObserver observer);
        public abstract void NotificarObservadores();
    }
}
