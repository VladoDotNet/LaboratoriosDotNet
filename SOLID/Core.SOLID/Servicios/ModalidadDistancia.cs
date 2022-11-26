using Core.SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Servicios
{
    public class ModalidadDistancia :BaseModalidad, IModalidadDistancia
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
}
