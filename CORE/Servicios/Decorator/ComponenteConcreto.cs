using CORE.Interfaces.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Servicios.Decorator
{
    public class ComponenteConcreto : AComponente
    {
        public override string Operacion()
        {
            return "Componente concreto...";
        }
    }
}
