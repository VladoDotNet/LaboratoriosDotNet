using Core.Interfaces.Factory_Method;
using Core.Interfaces.FactoryMethod;

namespace Core.Servicios.FactoryMethod
{
    public class RevistasIoTFactory : AFactoryMethodPublicaciones
    {
        public override IRevistasAcedemicas CrearPublicacion()
        {
            IRevistasAcedemicas oProducto = new InvestigacionIoT();
            return oProducto;
        }
    }
}
