using CORE.Interfaces.Composite;

namespace CORE.Servicios.Composite
{
    // The Leaf class represents the end objects of a composition. A leaf can't
    // have any children.
    //
    // Usually, it's the Leaf objects that do the actual work, whereas Composite
    // objects only delegate to their sub-components.

    public class Leaf : IComponent
    {
        public int Precio { get; set; }
        public string NombreComponente { get; set; }

        public Leaf(string nombre, int precio)
        {
            Precio = precio;
            NombreComponente = nombre;
        }
        
        public override int Costos()
        {
            Console.WriteLine($"COMPONENTE : {NombreComponente} : USD${Precio}");
            return Precio;
        }

        public override bool IsComposite()
        {
           return false;
        }

    }
}
