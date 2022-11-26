using Core.SOLID.Entidades;

namespace SOLID.Principio_1.SRP
{
    /// <summary>
    /// CASO: SOLID #1: SINGLE RESPONSIBILITY PRINCIPLE
    /// </summary>
    public class CasoSRP
    {
        public async Task<bool> ValidarEstudiante(Estudiante oEStudiante)
        {
            Console.WriteLine("\n");
            Console.WriteLine("PROCESANDO...Validando estudiante\n");
            await Task.Delay(2000);
            return true;
        }

        public async Task<bool> ValidarPago(int ID)
        {
            Console.WriteLine("PROCESANDO ...Consignación del pago\n");
            await Task.Delay(8000);
            return true;
        }

        public async Task<bool> RegMatricula(int ID)
        {
            Console.WriteLine("PROCESANDO ...generación del Invoice y " +
                "registro de la matrícula\n");
            await Task.Delay(4000);
            return true;
        }

        public async Task<bool> MailMatricula(int ID)
        {
            Console.WriteLine("DESPACHANDO ... correo con recibo de pago...\n");
            await Task.Delay(8000);
            return true;
        }
    }
}
