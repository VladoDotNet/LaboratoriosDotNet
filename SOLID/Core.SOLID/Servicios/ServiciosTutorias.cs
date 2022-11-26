using Core.SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Servicios
{
    public class ServiciosTutorias : IServiciosTutorias
    {
        public async Task Tutorias(int id, int CodTutor, DateTime FechaTutoria)
        {
            Console.WriteLine("PROCESANDO...Agenda de tutorías\n");
            await Task.Delay(4000);
        }
    }
}
