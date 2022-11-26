using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Servicios.Adapter
{
    public class AdapteeServicio
    {
        /// <summary>
        /// Clase especializada en procesar los formatos 
        /// definidos por la Escuela 
        /// </summary>
        /// <param name="formato"></param>
        /// <returns></returns>
        /// 
        public async Task<string> ProcesarRequerimientos(string formato)
        {
            await Task.Delay(3000);
            return $"conversión de formato especial --> {formato}... Exitoso!\n";
        }
    }
}
