using Core.Interfaces.Factory_Method;
using Core.Interfaces.FactoryMethod;

namespace Core.Servicios.FactoryMethod
{
    public class RevistaIngenSoftwareFactory : FactoryMethodBase
    {
        public override IRevistasAcedemicas CrearPublicacion()
        {
            IRevistasAcedemicas oProducto = new InvestigacionSoftware();
            return oProducto;
        }
    }
}
