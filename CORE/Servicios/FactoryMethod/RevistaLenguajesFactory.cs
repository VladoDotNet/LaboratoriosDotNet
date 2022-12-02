using Core.Interfaces.Factory_Method;
using Core.Interfaces.FactoryMethod;

namespace Core.Servicios.FactoryMethod
{
    public class RevistaLenguajesFactory : FactoryMethodBase
    {
        //Instanciación de esta subclase
        public override IRevistasAcedemicas CrearPublicacion()
        {
            IRevistasAcedemicas oProducto = new InvestigacionLenguajes(); 
            return oProducto;
        }
    }
}
