using CORE.Servicios.Facade;
using PATRONESAPP.ClientFacade;

namespace PATRONESAPP.UIFacade
{
    public class ProgramFacade
    {
        // El código del cliente puede tener ya algunos
        // de los objetos del subsistema creado.
        // En este caso, podría valer la pena inicializar la
        // Fachada con estos objetos en lugar de dejar que la Fachada cree
        // nuevas instancias.

        static  async Task  Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(" PATRONES - Facade ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n");

            RegistroAcademico oRegistroAcademico = new RegistroAcademico();
            SistemaHomologaciones oSistemaHomologaciones = new SistemaHomologaciones();
            GestionFinanciera oGestionFinanciera = new GestionFinanciera();
            GestionMatriculas oGestionMatricula = new GestionMatriculas();

            Facade oFAcade = new Facade(oRegistroAcademico, oSistemaHomologaciones,
                                        oGestionFinanciera, oGestionMatricula);

            Console.WriteLine("Iniciando proceso...\n");
            await Task.Delay(3000);

            Client.CodigoCliente(oFAcade);

            Console.WriteLine("Los subsistemas se inicializaron correctamente!\n");

            Console.ReadLine();
        }
    }
}
