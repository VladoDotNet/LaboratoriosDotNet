using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Entidades
{
    public class Matricula
    {
        public int IDListaMatricula { get; set; }
        public DateTime? FechaReg { get; set; }
        public decimal? PrecioSemestre { get; set; }

        public IEnumerable<Matricula> ListaMatriculas()
        {
            List<Matricula> matriculas = new List<Matricula>()
            {
                new Matricula
                {
                    IDListaMatricula = 1010,
                    FechaReg= Convert.ToDateTime("2023/01/15"),
                    PrecioSemestre = 999.99M
                }
            };
            return matriculas;
        }
    }
}
