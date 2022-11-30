using CORE.Interfaces.Decorator;

namespace CORE.Servicios.Decorator
{
    /// <summary>
    /// Llama el objeto envuelto y altera su resultado...
    /// </summary>
    public class DecoradorConcretoB : DecoratorBase
    {
        public DecoradorConcretoB(Interfaces.Decorator.ComponenteBase aComponente) : base(aComponente)
        { }

        public override string Operacion()
        {
            return $"DecoradorConcretoB({base.Operacion()})";
        }
    }
}
