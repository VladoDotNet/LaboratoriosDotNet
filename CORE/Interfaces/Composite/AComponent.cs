namespace CORE.Interfaces.Composite
{
    // La clase de Componente base declara operaciones comunes para
    // objetos simples y complejos.

    public abstract class AComponent
    {
        public AComponent()
        { }

        // El Componente base puede implementar algún comportamiento
        // por defecto o dejarlo a tal cual.
        // las clases concretas declaran el método que contiene el comportamiento.

        public abstract string Operaciones();

        public virtual void Agregar(AComponent aComponent)
        {
            Console.WriteLine("Agregar...");
        }

        public virtual void Remover(AComponent aComponent)
        {
            Console.WriteLine("Remover...");
        }

        // Puede proporcionar un método que permita que
        // el código del cliente descubra si
        // un componente puede tener hijos.
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
