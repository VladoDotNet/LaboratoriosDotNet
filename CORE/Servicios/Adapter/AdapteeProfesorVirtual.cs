namespace CORE.Servicios.Adapter
{
    public class AdapteeProfesorVirtual
    {
        //EL ADAPTEE ! Servicio a adaptar...

        //El Servicio es una clase útil(generalmente 3rd-party o legacy).
        //El cliente no puede usar esta clase directamente
        //porque tiene una interfaz incompatible.
        public void CargarCursos()
        {
            Console.WriteLine("PROCESANDO .... cursos profesor de VIRTUAL");
        }
        public void PaginasClases()
        {
            Console.WriteLine("PROCESANDO .... páginas clases profesor de VIRTUAL");
        }
        public void GestionProgreso()
        {
            Console.WriteLine("PROCESANDO .... asesorias progresos, profesor de VIRTUAL");
        }
        public void AtencionComunidad()
        {
            Console.WriteLine("PROCESANDO .... Comunidad, profesor de VIRTUAL");
        }
        public void GestionBlogs()
        {
            Console.WriteLine("PROCESANDO .... Blogs profesor de VIRTUAL (TAREA PROPIA DE ADAPTEE)");
        }
        public  void ClasesVirtualesExtras()
        {
              Console.WriteLine("PROCESANDO .... soporte virtual profesor de VIRTUAL (TAREA PROPIA DE ADAPTEE)");
        }
    }
}
