using Core.Interfaces.AbstractFactory;

namespace Core.Servicios.AbstractFactory
{
    public class SedeSur : BaseProyectosAFactory
    {
        // Las Fábricas de objetos Concretos producen una familia de productos
        // que pertenecen a una sola variante.
        // La fábrica garantiza que los productos resultantes sean compatibles.
        
        public override IPrySeminarios CrearProyectoSeminarios(string modalidad)
        {
            return new ProyectosSeminarios(modalidad);
        }

        public override IPryInvestigacion CrearProyectosInvestigacion(string modalidad)
        {
            return new ProyectosInvestigacion(modalidad);
        }
    }
}
