using Core.Interfaces.Factory_Method;
using Core.Interfaces.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Servicios.FactoryMethod
{
    public class RevistaIngenSoftwareFactory : AFactoryMethodPublicaciones
    {
        public override IRevistasAcedemicas CrearPublicacion()
        {
            IRevistasAcedemicas oProducto = new InvestigacionSoftware();
            return oProducto;
        }
    }
}
