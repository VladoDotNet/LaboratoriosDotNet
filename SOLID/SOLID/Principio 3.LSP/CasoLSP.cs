using Core.SOLID.Interfaces;

namespace SOLID.Principio_3.LSP
{
    public class CasoLSP
    { 
        public class ModalidadDistancia : ModalidadEstudio
        {
            public async Task ValidarDistancia(int id, string Nombre)
            {
                IDModalidad = id;
                Modalidad = Nombre;
                Console.WriteLine("\n");
                Console.WriteLine("EN PROCESO... Verificando bono\n");
                await Task.Delay(4000);
            }

            public override string DescuentoModalidad()
            {
                return "0.25";
            }

            public override double TotalPago()
            {
                double TotalDcto = Convert.ToDouble(PrecioMatriculas * 0.25);
                double TotalAPagar = Convert.ToDouble(PrecioMatriculas - TotalDcto);
                return TotalAPagar;
            }
        }

        public class ModalidadSemiPresencial : ModalidadEstudio
        {
            public async Task ValidarSemi(int id, string Nombre)
            {
                IDModalidad = id;
                Modalidad = Nombre;
                Console.WriteLine("\n");
                Console.WriteLine("EN PROCESO... Verificando bono\n");
                await Task.Delay(4000);
            }

            public override string DescuentoModalidad()
            {
                return "0.15";
            }

            public override double TotalPago()
            {
                double TotalDcto = Convert.ToDouble(PrecioMatriculas * 0.15);
                double TotalAPagar = Convert.ToDouble(PrecioMatriculas - TotalDcto);
                return TotalAPagar;
            }
        }

        public class ModalidadPresencial : ModalidadEstudio
        {
            public async Task ValidarPresencial(int id, string Nombre)
            {
                IDModalidad = id;
                Modalidad = Nombre;
                Console.WriteLine("\n");
                Console.WriteLine("EN PROCESO... Verificando bono\n");
                await Task.Delay(4000);
            }
            public override string DescuentoModalidad()
            {
                throw new NotImplementedException("No aplica para esta modalidad");
            }

            public override double TotalPago()
            {
                double TotalDcto = Convert.ToDouble(PrecioMatriculas * 0.0);
                double TotalAPagar = Convert.ToDouble(PrecioMatriculas - TotalDcto);
                return TotalAPagar;
            }
        }
    }
}
