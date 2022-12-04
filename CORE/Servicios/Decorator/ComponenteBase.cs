namespace CORE.Servicios.Decorator
{
    //El componente base concreto es una clase de objetos que hace de envoltorio.
    //Define el comportamiento básico, que puede ser alterado por los decoradores.
    public class ComponenteBase : Interfaces.Decorator.ComponenteBase
    {
        public override string Operacion()
        {
            return "Componente BÁSICO!...";
        }
    }
}
