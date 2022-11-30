using CORE.Interfaces.Composite;

namespace CORE.Servicios.Composite
{
    // La clase Composite representa los componentes complejos que pueden tener
    // hijos (hojas, Objetos Leaf).
    // Por lo general, los objetos compuestos delegan el trabajo real a
    // sus hijos y luego proceden a consolidar el resultado.

    public class Composite : IComponent
    {
        public string Nombre { get; set; }
        public int TotalCostos { get; set; }

        public Composite(string nombre)
        {
            Nombre = nombre;
        }

        protected List<IComponent> lstComponents = new List<IComponent>();

        public virtual void Agregar(IComponent componente)
        {
            lstComponents.Add(componente);
        }

        public virtual void Remover(IComponent componente)
        {
            lstComponents.Remove(componente);
        }

        // El Composite ejecuta su lógica primaria de una manera particular.
        // Es un proceso recursivo a través de todos sus hijos,
        // recopilando y agrupando sus resultados.
        // Los hijos de un objeto compuesto llaman a sus hijos y así sucesivamente,
        // todo el árbol de objetos representa el resultado final.

        public override int Costos()
        {
            Console.WriteLine($"Costos y Componentes  del curso : {Nombre} :\n");
            foreach (var item in lstComponents)
            {
               TotalCostos= TotalCostos + item.Costos();
            }
            return TotalCostos;
        }
    }
}
