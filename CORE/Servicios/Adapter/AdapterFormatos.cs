using CORE.Interfaces.Adapter;

namespace CORE.Servicios.Adapter
{
    public class AdapterFormatos : ITargetBase
    {
        private readonly AdapteeFormatosServicio _adapatee;

        public AdapterFormatos(AdapteeFormatosServicio adapateeServicio) //<-- Constructor
        {
            _adapatee = adapateeServicio;
        }
        
        public async Task PrecesarFormatosEscuela(string formato)
        {
            switch (formato)
            {
                case string s when s == "XML" || s == "JSON" || s == "TEXTO PLANO":
                    Console.WriteLine("PROCESANDO . . .  Formatos de la Escuela\n ");
                    await Task.Delay(3000);
                    Console.WriteLine($"Formateo a {formato} exitoso!\n ");
                    break;
                default:
                    Console.WriteLine("PROCESANDO . . .  Formatos especiales\n ");
                    var ConversionOtro =  await _adapatee.ProcesarRequerimientos(formato);
                    Console.WriteLine(ConversionOtro);
                    break;
            }
        }
    }
}
