using Core.SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Servicios
{
    public class ServiciosBiblioteca : IServiciosBiblioteca
    {
        public async Task GestionPrestamos(int id, string ISBN, 
            DateTime FechaIni, DateTime FechaFin)
        {
            Console.WriteLine("PROCESANDO...Gestionando préstamo\n");
            await Task.Delay(4000);
        }
    }
}
