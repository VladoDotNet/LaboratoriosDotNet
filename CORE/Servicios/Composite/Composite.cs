using CORE.Interfaces.Composite;

namespace CORE.Servicios.Composite
{
    // The Composite class represents the complex components that may have
    // children. Usually, the Composite objects delegate the actual work to
    // their children and then "sum-up" the result.
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

        // The Composite executes its primary logic in a particular way. It
        // traverses recursively through all its children, collecting and
        // summing their results. Since the composite's children pass these
        // calls to their children and so forth, the whole object tree is
        // traversed as a result.

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
