using System.ComponentModel;

namespace CORE.Servicios.Decorator
{
    //Los decoradores concretos definen comportamientos adicionales
    //que se pueden agregar a los componentes dinámicamente.
    //Y anulan los métodos del decorador base
    //al ejecutan su comportamiento
    //antes o después de llamar al método padre.
    public class ComponenteConcreto : Interfaces.Decorator.ComponenteBase
    {
        public override string Operacion()
        {
            return "Componente concreto...";
        }
    }
}
