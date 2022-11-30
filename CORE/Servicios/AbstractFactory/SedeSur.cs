using Core.Interfaces.AbstractFactory;

namespace Core.Servicios.AbstractFactory
{
    public class SedeSur : BaseAbstractFactory
    {

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
