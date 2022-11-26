using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Entidades
{
    public class TipoInfomes
    {
        public int IDTipoInforme { get; set; }
        public string? NombreTipoInforme { get; set; }

        public IEnumerable<TipoInfomes> ListaTipoInforme()
        {
            List<TipoInfomes> tipoInforme = new List<TipoInfomes>()
            {
                new TipoInfomes
                {
                    IDTipoInforme = 1,
                    NombreTipoInforme="EXCEL"
                },
                new TipoInfomes
                {
                    IDTipoInforme=2,
                    NombreTipoInforme="WORD"
                }
            };
            return tipoInforme; 
        }
    }
}
