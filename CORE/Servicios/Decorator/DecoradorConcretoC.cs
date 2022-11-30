using CORE.Interfaces.Decorator;

namespace CORE.Servicios.Decorator
{
    /// <summary>
    /// Llama el objeto envuelto y altera su resultado...
    /// </summary>
    public class DecoradorConcretoC : DecoratorBase
    {
        public DecoradorConcretoC(Interfaces.Decorator.ComponenteBase aComponente) : base(aComponente)
        { }

        public override string Operacion()
        {
            return $"DecoradorConcretoC({base.Operacion()})";
        }
    }
}
