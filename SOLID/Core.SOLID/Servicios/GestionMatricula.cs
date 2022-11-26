using Core.SOLID.Entidades;
using Core.SOLID.Interfaces;

namespace Core.SOLID.Servicios
{
    public class GestionMatricula : IGestionMatricula
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

        public async Task<bool> MailMatricula(int ID, string toAdress, string subject)
        {
            Console.WriteLine("DESPACHANDO ... correo con recibo de pago.\n");
            await Task.Delay(8000);
            return true;
        }
    }
}
