using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Entidades
{
    public class Estudiante
    {
        public int IDEstudiante { get; set; }
        public string? NombreEstudiante { get; set; }
        public string CorreoEstudiante { get; set; }
        public string AsuntoMailEstudiante { get; set; }

        public IEnumerable<Estudiante> listaEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>()
            {
                new Estudiante
                {
                    IDEstudiante = 1,
                    NombreEstudiante="Veronica",
                    CorreoEstudiante="veronica@outlook.es",
                    AsuntoMailEstudiante="Pago del semestre"

                },
                new Estudiante
                {
                    IDEstudiante= 2,
                    NombreEstudiante="Astrid Carolina",
                    CorreoEstudiante="astrid@gmail.com",
                    AsuntoMailEstudiante="Pago del semestre"
                }
            };
            return estudiantes;
        }
    }

    
}
