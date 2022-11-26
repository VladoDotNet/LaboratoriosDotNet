using Core.Interfaces.AbstractFactory;

namespace Core.Servicios.AbstractFactory
{
    public class ProyectosSeminarios : IPrySeminarios
    {
        public string strNombre { get; set; }

        public ProyectosSeminarios(string modalidad)
        { }

        public string CrearProyecto(string modalidad)
        {
            if (modalidad == "Presencial")
            {
                strNombre = "Seminario API REST aplicando Abstract Factory pattern";
            }
            else
            {
                strNombre = "Seminario BLAZOR, despliegue de una Tienda Online";
            }
            return strNombre;
        }
    }
}
