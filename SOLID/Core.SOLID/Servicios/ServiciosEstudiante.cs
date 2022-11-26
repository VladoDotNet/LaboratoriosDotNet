using Core.SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Servicios
{
    public class ServiciosEstudiante : IServiciosEstudiante
    {
        public async Task GestionSalones(int id, string salon, 
            DateTime FechaReserva)
        {
            throw new NotImplementedException();
        }

        public async Task GestionPrestamos(int id, string ISBN,
            DateTime FechaIni, DateTime FechaFin)
        {
            throw new NotImplementedException();
        }

        public async Task Tutorias(int id, int CodTutor, 
            DateTime FechaTutoria)
        {
            throw new NotImplementedException();
        }
    }
}
