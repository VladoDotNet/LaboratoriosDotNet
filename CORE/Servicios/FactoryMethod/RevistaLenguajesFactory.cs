using Core.Interfaces.Factory_Method;
using Core.Interfaces.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Servicios.FactoryMethod
{
    public class RevistaLenguajesFactory : AFactoryMethodPublicaciones
    {
        public override IRevistasAcedemicas CrearPublicacion()
        {
            IRevistasAcedemicas oProducto = new InvestigacionLenguajes(); //Instanciación de esta subclase
            return oProducto;
        }
    }
}
