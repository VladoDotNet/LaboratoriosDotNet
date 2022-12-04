using Core.Interfaces.AbstractFactory;

namespace Core.Servicios.AbstractFactory
{
    public class ProyectosInvestigacion : IPryInvestigacion
    {
        public ProyectosInvestigacion(string modalidad)
        {
        }
        public string? strNombre { get; set; }
        public string CrearProyecto(string modalidad)
        {
            if (modalidad == "Presencial")
            {
                strNombre = "Necesidades educativas Zona Centro";
            }
            else
            {
                strNombre = "Problematica familiar madres solteras";
            }
            return strNombre;
        }
    }
}
