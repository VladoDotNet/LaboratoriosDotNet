using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Interfaces
{
    public interface IModalidadSemipresencial
    {
        Task ValidarSemipresencial(int id, string Nombre);
    }
}
