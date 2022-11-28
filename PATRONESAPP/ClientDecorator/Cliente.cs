using CORE.Interfaces.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void CodigoCliente(AComponente aComponente)
        {
            Console.WriteLine("DECORACIÓN FINAL --> " + aComponente.Operacion());
        }
    }
}
