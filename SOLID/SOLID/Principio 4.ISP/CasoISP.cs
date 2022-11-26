using Core.SOLID.Interfaces;

namespace SOLID.Principio_4.ISP
{
    public class CasoISP : IServiciosEstudiante
    {
        public async Task GestionSalones(int id, string salon, 
            DateTime FechaReserva)
        {
            Console.WriteLine("PROCESANDO...Gestionando préstamo\n");
            await Task.Delay(4000);
        }

        public async Task GestionPrestamos(int id, string ISBN, 
            DateTime FechaIni, DateTime FechaFin)
        {
            Console.WriteLine("PROCESANDO...Gestionando préstamo\n");
            await Task.Delay(4000);
        }

        public async Task Tutorias(int id, int CodTutor, 
            DateTime FechaTutoria)
        {
            Console.WriteLine("PROCESANDO...Agenda de tutorías\n");
            await Task.Delay(4000);
        }
    }
}
