namespace CORE.Interfaces.Composite
{
    // The base Component class declares common operations for both simple and
    // complex objects of a composition.
    public abstract class AComponent
    {
        public AComponent()
        { }

        // The base Component may implement some default behavior or leave it to
        // concrete classes (by declaring the method containing the behavior as
        // "abstract").
        public abstract string Operaciones();

        // In some cases, it would be beneficial to define the child-management
        // operations right in the base Component class. This way, you won't
        // need to expose any concrete component classes to the client code,
        // even during the object tree assembly. The downside is that these
        // methods will be empty for the leaf-level components.

        public virtual void Agregar(AComponent aComponent)
        {
            Console.WriteLine("Agregar...");
        }

        public virtual void Remover(AComponent aComponent)
        {
            Console.WriteLine("Remover...");
        }

        // You can provide a method that lets the client code figure out whether
        // a component can bear children.
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
