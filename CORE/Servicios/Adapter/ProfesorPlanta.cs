using CORE.Interfaces.Adapter;

namespace CORE.Servicios.Adapter
{
    public class ProfesorPlanta : ITarget
    {
        public override void Cursos()
        {
            Console.WriteLine("PROCESANDO .... asignación de cursos profesor de PLANTA");
        }

        public override void Salones()
        {
            Console.WriteLine("PROCESANDO .... asignación de salones profesor de PLANTA");
        }

        public override void AgendaHorarios()
        {
            Console.WriteLine("PROCESANDO .... horarios del profesor de PLANTA");
        }

        public override void AtencionEstudiantes()
        {
            Console.WriteLine("PROCESANDO .... Atención a estudiantes del profesor de PLANTA");
        }
    }
}
