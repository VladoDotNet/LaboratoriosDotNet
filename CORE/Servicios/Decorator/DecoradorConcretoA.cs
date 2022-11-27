using CORE.Interfaces.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Servicios.Decorator
{
    /// <summary>
    /// Llama el objeto envuelto y altera su resultado...
    /// </summary>
    public class DecoradorConcretoA : ADecorator
    {
        public DecoradorConcretoA(AComponente aComponente) : base(aComponente)
        {

        }

        public override string Operacion()
        {
            return $"DecoradorConcretoA({base.Operacion()})";
        }
    }
}
