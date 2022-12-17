using CORE.Interfaces.Adapter;
namespace CORE.Servicios.Adapter
{
    //Soluciona la incompatibilidad.
    //Debe tener un constructor que crea
    //una instancia de un tipo de requerimiento diferente;
    //instancia de Adaptee

    public class AdapterPVirtual : ITarget
    {
        //ASOCIACIÓN al Adaptee (el incompatible a adaptar)

        AdapteeProfesorVirtual _profesorVirtual = new AdapteeProfesorVirtual();

        public override void Cursos()
        {
            _profesorVirtual.CargarCursos();
        }

        public override void Salones()
        {
            _profesorVirtual.PaginasClases();
        }

        public override void AgendaHorarios()
        {
            //Puede equivaler a las firmas del Adapter  o ITarget
            _profesorVirtual.GestionProgreso();
        }

        //Tareas que pueden equivaler a varias del Adaptee...
        public override void AtencionEstudiantes()
        {
            _profesorVirtual.AtencionComunidad();
            _profesorVirtual.GestionBlogs();
        }
        public override void ServiciosVarios()
        {
            _profesorVirtual.ClasesVirtualesExtras();
        }
    }
}
