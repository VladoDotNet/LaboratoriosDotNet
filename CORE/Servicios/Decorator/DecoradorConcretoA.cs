using CORE.Interfaces.Decorator;

namespace CORE.Servicios.Decorator
{
    //Llama el objeto envuelto y altera su resultado...
    //Los decoradores concretos definen comportamientos adicionales
    //que se pueden agregar a los componentes dinámicamente. 
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
