using CORE.Interfaces.Composite;
using CORE.Servicios.Composite;
using PATRONESAPP.ClientComposite;

namespace PATRONESAPP.UIComposite
{
    public class ProgramComposite
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("------------------------------");
            Console.WriteLine(" PATRONES - Composite ");
            Console.WriteLine("------------------------------");

            char continuar = default;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("CURSOS : MÓDULO DE COSTOS");
                Console.WriteLine("--------------------------\n");

                Console.WriteLine("Creando componentes CORE para cursos...\n");
                await Task.Delay(4000);

                //Objetos compuestos (Composite)
                Composite cCurso = new Composite("Especialización en .Net");
                Composite cEscuela = new Composite("Escuela de Ingeniería");

                Console.WriteLine("Creando componentes LEAD del curso...");
                await Task.Delay(3000);
                //Objetos simples (Leads)
                IComponent lTitular = new Leaf("Profesor titular", 3500);
                IComponent lCatedra = new Leaf("Profesor cátedra", 2000);
                IComponent lCoordinadora = new Leaf("Coordinadora académica", 800);
                IComponent lDirector = new Leaf("Director", 3000);
                IComponent lEstudiantes = new Leaf("Listado de estudiantes", 0);

                Console.WriteLine("Agregando componentes LEAD al Core...");
                await Task.Delay(3000);

                //Estructura, árbol
                cCurso.Agregar(lTitular);
                cCurso.Agregar(lCatedra);
                cCurso.Agregar(lCoordinadora);
                cCurso.Agregar(lDirector);
                cCurso.Agregar(lEstudiantes);

                Console.WriteLine($"Creando el CURSO... {cCurso.Nombre}");
                await Task.Delay(3000);
                cEscuela.Agregar(cCurso);


                Console.WriteLine($"Calculando COSTOS totales...");
                await Task.Delay(3000);

                Console.WriteLine("\n");
                Console.WriteLine($"Costo total de curso : {cCurso.Costos()}\n");

                Console.Write("Desea continuar? Sí(s) / No(n)");
                continuar = Console.ReadKey().KeyChar;
                Console.Clear();

                Console.WriteLine("------------------------------");
                Console.WriteLine(" PATRONES - Composite ");
                Console.WriteLine("------------------------------");

            } while (continuar != 'n');

            


            

           



        }
    }
}
