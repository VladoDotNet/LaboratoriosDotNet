using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Interfaces.Decorator
{
    public abstract class ADecorator : AComponente
    {
        protected AComponente _aComponente;

        public ADecorator(AComponente aComponente)
        {
            _aComponente = aComponente;
        }

        public void SetComponente(AComponente aComponente)
        {
            _aComponente = aComponente;
        }

        // El DECORADOR DELEGA todo el trabajo al componente wrapped...
        public override string Operacion()
        {
            if(_aComponente != null)
            {
                return _aComponente.Operacion();
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
