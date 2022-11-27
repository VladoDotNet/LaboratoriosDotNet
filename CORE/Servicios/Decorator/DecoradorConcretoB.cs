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
    public class DecoradorConcretoB : ADecorator
    {
        public DecoradorConcretoB(AComponente aComponente) : base(aComponente)
        {

        }

        public override string Operacion()
        {
            return $"DecoradorConcretoB({base.Operacion()})";
        }
    }
}
