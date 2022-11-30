using CORE.Interfaces.Decorator;

namespace CORE.Servicios.Decorator
{
    /// <summary>
    /// Llama el objeto envuelto y altera su resultado...
    /// </summary>
    public class DecoradorConcretoA : DecoratorBase
    {
        public DecoradorConcretoA(Interfaces.Decorator.ComponenteBase aComponente) : base(aComponente)
        { }

        public override string Operacion()
        {
            return $"DecoradorConcretoA,(incluye {base.Operacion()})";
        }
    }
}
