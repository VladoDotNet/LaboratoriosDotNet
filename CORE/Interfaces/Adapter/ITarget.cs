namespace CORE.Interfaces.Adapter
{
    //La interfaz de cliente describe un protocolo que otras clases
    //deben seguir para poder colaborar con el código de cliente.
    public abstract class ITarget
    {
        public abstract void Cursos();
        public abstract void Salones();
        public abstract void AgendaHorarios();
        public abstract void AtencionEstudiantes();
        public abstract void ServiciosVarios();

    }
}
