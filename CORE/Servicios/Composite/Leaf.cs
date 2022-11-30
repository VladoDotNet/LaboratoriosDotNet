using CORE.Interfaces.Composite;

namespace CORE.Servicios.Composite
{
    // La clase Leaf representa los objetos finales de una composición.
    //Una hoja no puede tener hijos.
    // Por lo general, son los objetos Leaf los que hacen el trabajo real, mientras que 
    //los objetos compuestos solo delegan en sus subcomponentes.

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
