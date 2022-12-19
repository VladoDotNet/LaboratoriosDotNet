using System.ComponentModel;

namespace CORE.Interfaces.Composite
{
    // La clase de Componente base declara operaciones
    // comunes para ambos componentes:
    // objetos simple y
    // objetos complejos.
    public abstract class IComponent
    {
        //La interfaz Component describe las operaciones que son comunes
        //a los elementos simples y complejos del árbol.
        public IComponent()
        { }

        // El componente base puede implementar algún comportamiento predeterminado o no.
        // Las clases concretas declaran el método que contiene el comportamiento
        public abstract int Costos();

        // Puede proporcionar un método que permita
        // que el código del cliente realice configuraciones del composición.
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
