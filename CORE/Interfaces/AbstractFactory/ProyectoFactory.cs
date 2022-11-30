namespace Core.Interfaces.AbstractFactory
{
    public abstract class ProyectoFactory
    {
        public abstract IPrySeminarios CrearProyectoSeminarios();
        public abstract IPryInvestigacion CrearProyectosInvestigacion();
        public abstract IPrySocial CrearProyectoSocial();
    }
}
