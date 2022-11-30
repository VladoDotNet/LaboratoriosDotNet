using CORE.Interfaces.Decorator;

namespace PATRONESAPP.ClientDecorator
{
    /// <summary>
    /// Trabaja con todos los objetos 
    /// haciendo uso de la clase abstracta AComponente.
    /// Se mantiene la independencia de las clases concretas
    /// y los componentes que trabajan con estas
    /// </summary>
    public class Cliente
    {
        public void CodigoCliente(ComponenteBase aComponente)
        {
            Console.WriteLine("DECORACIÓN FINAL --> " + aComponente.Operacion());
        }
    }
}
