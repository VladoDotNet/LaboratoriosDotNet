using Core.SOLID.Entidades;
using Core.SOLID.Interfaces;

namespace SOLID.Principio_1
{
    public class SolucionSRP
    {
        private readonly IGestionMatricula _GestionMatricula;

        public SolucionSRP(IGestionMatricula gestionMatricula)
        {
            _GestionMatricula = gestionMatricula;
        }

        public async Task<bool> ValidarEstudiante(Estudiante oEStudiante)
        {
            await _GestionMatricula.ValidarEstudiante(oEStudiante);
            return true;
        }

        public async Task<bool> ValidarPago(int ID)
        {
            await _GestionMatricula.ValidarPago(ID);
            return true;
        }

        public async Task<bool> RegMatricula(int ID)
        {
            await _GestionMatricula.RegMatricula(ID);
            return true;
        }

        public async Task<bool> MailMatricula(int ID, string toAdress, string subject)
        {
            await _GestionMatricula.MailMatricula(ID, toAdress, subject);
            return true;
        }
    }
}


//public void GestionMatricula(Estudiante oEstudiante,
//    int IDPago, int IDMatricula)

//{
//    try
//    {
//        File.WriteAllTextAsync(@"c:\TransacMatricula.txt", "Mensaje");
//    }
//    catch (Exception e)
//    {
//        File.WriteAllTextAsync(@"e:\ErrMatricula", e.Message);
//    }
//}