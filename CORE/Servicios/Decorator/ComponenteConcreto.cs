namespace CORE.Servicios.Decorator
{
    public class ComponenteConcreto : Interfaces.Decorator.ComponenteBase
    {
        public override string Operacion()
        {
            return "Componente concreto...";
        }
    }
}
