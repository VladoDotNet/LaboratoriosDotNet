namespace Core.Interfaces.AbstractFactory
{
    public abstract class AProyectoFactory
    {
        public abstract IPrySeminarios CrearProyectoSeminarios(string modalidad);
        public abstract IPryInvestigacion CrearProyectosInvestigacion(string modalidad);
    }
}
