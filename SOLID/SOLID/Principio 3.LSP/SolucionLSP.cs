using Core.SOLID.Interfaces;

namespace SOLID.Principio_3.LSP
{
    public class SolucionLSP
    { 
        public class ModalidadDistancia : BaseModalidad, IModalidad
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

        public class ModalidadSemiPresencial : BaseModalidad, IModalidad
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

        public class ModalidadPresencial : BaseModalidad, IModalidad
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
                return "... 0.0%\n " +
                    "Esta modalidad no tiene descuentos especiales";
            }

            public override double TotalPago()
            {
                double TotalDcto = Convert.ToDouble( PrecioMatriculas * 0.0);
                double TotalAPagar = Convert.ToDouble(PrecioMatriculas - TotalDcto);
                return TotalAPagar;
            }
        }
    }
}
