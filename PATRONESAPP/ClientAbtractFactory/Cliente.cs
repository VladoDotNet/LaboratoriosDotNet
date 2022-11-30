using Core.Interfaces.AbstractFactory;

namespace PATRONES.ClientAbtractFactory
{
    public class Cliente
    {
        private readonly IPrySeminarios _prySeminarios;
        private readonly IPryInvestigacion _pryInvestigacion;
        //private readonly IPrySocial _prySocial;

        public Cliente(BaseAbstractFactory factory, string modalidad)
        {
            _prySeminarios = factory.CrearProyectoSeminarios(modalidad);
            _pryInvestigacion = factory.CrearProyectosInvestigacion(modalidad);
            //_prySocial = factory.CrearProyectoSocial(modalidad);
        }

        public async Task<string> CrearProyectosSeminarios(string modalidad)
        {
            Console.WriteLine("CREANDO PROYECTO...\n");
            await Task.Delay(4000);
            return _prySeminarios.CrearProyecto(modalidad);

        }

        public async Task<string> CrearProyectosInvestigacion(string modalidad)
        {
            Console.WriteLine("CREANDO PROYECTO...\n");
            await Task.Delay(4000);
            return _pryInvestigacion.CrearProyecto(modalidad);

        }

    }
}
