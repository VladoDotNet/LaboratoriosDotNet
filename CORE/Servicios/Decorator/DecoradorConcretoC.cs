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
    public class DecoradorConcretoC : ADecorator
    {
        public DecoradorConcretoC(AComponente aComponente) : base(aComponente)
        {

        }

        public override string Operacion()
        {
            return $"DecoradorConcretoC({base.Operacion()})";
        }
    }
}
