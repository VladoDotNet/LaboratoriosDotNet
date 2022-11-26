using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Interfaces
{
    public interface IModalidadPresencial
    {
        Task ValidarPresencial(int id, string Nombre);
    }
}
