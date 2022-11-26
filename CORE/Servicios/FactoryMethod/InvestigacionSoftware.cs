using Core.Interfaces.FactoryMethod;

namespace Core.Servicios.FactoryMethod
{
    public class InvestigacionSoftware : IRevistasAcedemicas
    {
       
        public async Task<string> GetNombreRevista()
        {
            Console.WriteLine("PRODUCIENDO . . . ");
            await Task.Delay(4000);
            return "Patrones de diseño aplicados a realidad virtual";
        }

        public async Task<string> TipoPublicacion()
        {
            await Task.Delay(2000);
            return "Revista de investigación";
        }
    }
}
