using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.AbstractFactory
{
    public abstract class ProyectoFactory
    {
        //protected int SedeID { get; set; }
        //public string? NombreSede { get; set; }
        //public string? EquipoProyecto { get; set; }

        public abstract IPrySeminarios CrearProyectoSeminarios();
        public abstract IPryInvestigacion CrearProyectosInvestigacion();
        public abstract IPrySocial CrearProyectoSocial();
    }
}
