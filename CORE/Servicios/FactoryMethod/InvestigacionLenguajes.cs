using Core.Interfaces.FactoryMethod;

namespace Core.Servicios.FactoryMethod
{
    public class InvestigacionLenguajes : IRevistasAcedemicas
    {
        public async Task<string> GetNombreRevista()
        {
            Console.WriteLine("PRODUCIENDO . . . ");
            await Task.Delay(4000);
            return "Abstracción con C#";
        }

        public async Task<string> TipoPublicacion()
        {
            await Task.Delay(2000);
            return "Revista de investigación";
        }
    }
}
