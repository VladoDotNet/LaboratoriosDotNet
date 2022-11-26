using Core.SOLID.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Interfaces
{
    public interface IGestionMatricula
    {
        Task<bool> ValidarEstudiante(Estudiante oEStudiante);
        Task<bool> ValidarPago(int ID);
        Task<bool> RegMatricula(int ID);
        Task<bool> MailMatricula(int ID, string toAdress, string subject );
    }
}
