using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Interfaces
{
    public interface IServiciosBiblioteca
    {
        Task GestionPrestamos(int id, string ISBN,
            DateTime FechaIni, DateTime FechaFin);
    }
}
