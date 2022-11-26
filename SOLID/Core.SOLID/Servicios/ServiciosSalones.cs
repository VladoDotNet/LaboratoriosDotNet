using Core.SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Servicios
{
    public class ServiciosSalones : IServicioSalones
    {
        public async Task GestionSalones(int id, string salon, DateTime FechaReserva)
        {
            Console.WriteLine("PROCESANDO...Gestionando préstamo\n");
            await Task.Delay(4000);
        }
    }
}
