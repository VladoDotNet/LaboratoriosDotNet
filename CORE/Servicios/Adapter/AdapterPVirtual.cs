using CORE.Interfaces.Adapter;
using System.Diagnostics;
using System;
using System.IO;
namespace CORE.Servicios.Adapter
{
    //El adaptador es una clase que puede trabajar
    //tanto con el cliente como con el servicio:
    //implementa la interfaz del cliente,
    //mientras envuelve el objeto de servicio.
    //El adaptador recibe llamadas del cliente
    //a través de la interfaz del adaptador y
    //las traduce en llamadas al objeto de servicio
    //ajustado en un formato que puede entender.

    //Soluciona la incompatibilidad.
    //Debe tener un constructor que crea
    //una instancia de un tipo de requerimiento diferente;
    //instancia de Adaptee

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
