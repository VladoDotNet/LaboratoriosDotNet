using Core.SOLID.Entidades;
using Core.SOLID.Interfaces;

namespace SOLID.Principio_2.OCP
{
    public class SolucionOCP
    {
        private readonly IGenerarInformes _generarInformes;

        public SolucionOCP(IGenerarInformes generarInformes)
        {
            _generarInformes = generarInformes;
        }
        
        public async Task<bool> CrearInforme()
        {
            await _generarInformes.NuevoInforme();
            return true;    

        }
    }
}
