using Core.Interfaces.FactoryMethod;

namespace Core.Servicios.FactoryMethod
{
    public class InvestigacionIoT : IRevistasAcedemicas
    {
        public async Task<string> GetNombreRevista()
        {
            Console.WriteLine("PRODUCIENDO . . . \n");
            await Task.Delay(2000);
            return "IoT para la industria domótica";
        }

        public async Task<string> TipoPublicacion()
        {
            await Task.Delay(1000);
            return "Revista de investigación";
        }
    }
}
