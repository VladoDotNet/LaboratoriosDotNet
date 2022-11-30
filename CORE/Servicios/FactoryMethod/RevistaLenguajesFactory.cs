using Core.Interfaces.Factory_Method;
using Core.Interfaces.FactoryMethod;

namespace Core.Servicios.FactoryMethod
{
    public class RevistaLenguajesFactory : FactoryMethodBase
    {
        public override IRevistasAcedemicas CrearPublicacion()
        {
            IRevistasAcedemicas oProducto = new InvestigacionLenguajes(); //Instanciación de esta subclase
            return oProducto;
        }
    }
}
