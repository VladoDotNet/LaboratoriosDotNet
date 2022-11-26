using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Interfaces
{
    public interface IGenerarInformes
    {
        Task <bool> NuevoInforme();   
    }
}
