namespace CORE.Interfaces.Observer
{
    public abstract class ISubject
    {
        public abstract void nRecurso();
        public abstract void RegistrarObserver(IObserver observer);
        public abstract void RemoveObservador(IObserver observer);
        public abstract void NotificarObservadores();
    }
}
