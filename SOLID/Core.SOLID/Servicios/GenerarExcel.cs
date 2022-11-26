using Core.SOLID.Interfaces;

namespace Core.SOLID.Servicios
{
    public class GenerarExcel : IGenerarInformes
    {
        public async Task<bool> NuevoInforme()
        {
            Console.WriteLine("\n");
            Console.WriteLine("EN PROCESO... Generando informe\n");
            //Aqui proceso de conversión al formato EXCEL...
            await Task.Delay(3000);
            return true;
        }
    }
}
