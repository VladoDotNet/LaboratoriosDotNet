using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;
using System;

namespace CORE.Interfaces.Composite
{
    // La clase de Componente base declara operaciones comunes para
    // objetos simples y complejos.

    public abstract class IComposite
    {
        public IComposite()
        { }
        //El contenedor(también conocido como compuesto) es un elemento que tiene subelementos:
        //hojas u otros contenedores.Un contenedor no conoce las clases concretas de sus hijos.
        //Funciona con todos los subelementos solo a través de la interfaz de componentes.
        //Al recibir una solicitud, un contenedor delega el trabajo a sus subelementos,
        //procesa los resultados intermedios y luego devuelve el resultado final al cliente.

        public abstract string Operaciones();
        public virtual void Agregar(IComposite aComponent)
        {
            Console.WriteLine("Agregar...");
        }

        public virtual void Remover(IComposite aComponent)
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
