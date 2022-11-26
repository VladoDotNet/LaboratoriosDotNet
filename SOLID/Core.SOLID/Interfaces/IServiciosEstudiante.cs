namespace Core.SOLID.Interfaces
{
    public interface IServiciosEstudiante
    {
        Task GestionSalones(int id, string salon, 
            DateTime FechaReserva);

        Task GestionPrestamos(int id, string ISBN, 
            DateTime FechaIni, DateTime FechaFin);

        Task Tutorias(int id, int CodTutor, DateTime FechaTutoria);
    }
}
