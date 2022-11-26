using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Interfaces.Adapter
{
    /// <summary>
    /// Clase con método para implementar por el ADAPTER
    /// El CLIENTE hace uso de este método para procesar el formato
    /// </summary>
    public interface ITarget
    {
        Task PrecesarFormatosEscuela (string formato);
    }
}
