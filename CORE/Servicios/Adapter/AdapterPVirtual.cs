using CORE.Interfaces.Adapter;

namespace CORE.Servicios.Adapter
{
    public class AdapterPVirtual : ITarget
    {
        //ASOCIACIÓN al Adaptee (el incompatible a adaptar)

        ProfesorVirtual _profesorVirtual = new ProfesorVirtual();
        
        public override void AgendaHorarios()
        {
            //Puede equivaler a las firmas del Adapter  o ITarget
            _profesorVirtual.GestionProgreso();
        }

        //Tareas que pueden equivaler a varias del Adaptee...
        public override void AtencionEstudiantes()
        {
            _profesorVirtual.GestionBlogs();
            _profesorVirtual.AtencionComunidad();
        }

        public override void Cursos()
        {
            _profesorVirtual.CargarCursos();
        }

        public override void Salones()
        {
            _profesorVirtual.PaginasClases();
        }

        //OTRAS TAREAS PROPIAS DEL ADAPTEE...
        //Se gestionan directamente en este...
    }
}
