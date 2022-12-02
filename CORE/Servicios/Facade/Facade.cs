namespace CORE.Servicios.Facade
{
    public class Facade
    {
        // ES por igual un tipo de cliente.
        // La clase Fachada proporciona una interfaz simple a la lógica compleja de una
        // o varios subsistemas. La Fachada delega las solicitudes del cliente a los
        // objetos apropiados dentro del subsistema.
        // Este patrón también es responsable
        // para gestionar los ciclos de vida.
        // Todo esto protege al cliente de la complejidad no deseada del subsistema.

        private RegistroAcademico _registroAcademico;
        private SistemaHomologaciones _sistemaHomologaciones;
        private GestionFinanciera _gestionFinanciera;
        private GestionMatriculas _gestionMatriculas;

        public Facade(RegistroAcademico registroAcademico,
                      SistemaHomologaciones sistemaHomologaciones,
                      GestionFinanciera gestionFinanciera,
                      GestionMatriculas gestionMatriculas)
        {
            _registroAcademico = registroAcademico;
            _sistemaHomologaciones = sistemaHomologaciones;
            _gestionFinanciera = gestionFinanciera;
            _gestionMatriculas = gestionMatriculas;
        }

        // Los métodos de Facade son atajos convenientes para la compleja
        // funcionalidad de los subsistemas.
        
        public string CargandoSubsistemas()
        {
            string cargados="";

            cargados += _registroAcademico.RegistrarCandidatos();
            cargados += _registroAcademico.CargarDocumentacion();

            cargados += _sistemaHomologaciones.RegistroSoportes();
            cargados += _sistemaHomologaciones.MatrizHomologaciones();

            cargados += _gestionFinanciera.GenerarReciboPago();
            cargados += _gestionFinanciera.PasarelasPago();
            cargados += _gestionFinanciera.InvoicePagos();

            cargados += _gestionMatriculas.Prematricula();
            cargados += _gestionMatriculas.CargaAcademicaEstudiante();

            return cargados;
        }
    }
}
