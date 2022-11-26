using Core.SOLID.Entidades;

namespace SOLID.Principio_2.OCP
{
    public class CasoOCP
    {
        public async Task<Matricula> CrearInforme(
            Matricula oMatricula, int ID)
        {
            if(ID == 0)
            {
                InformeEXCEL();
            }
            else if(ID == 1)
            {
                InformeWord();
            }

            return oMatricula;
        }

        public async Task  InformeEXCEL()
        {
            Console.WriteLine("\n");
            Console.WriteLine("EN PROCESO... Generando informe\n");
            await Task.Delay(3000);
        }

        public async Task InformeWord()
        {
            Console.WriteLine("\n");
            Console.WriteLine("EN PROCESO... Generando informe\n");
            await Task.Delay(5000);
        }
    }
}
