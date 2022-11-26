using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SOLID.Interfaces
{
    public abstract class ModalidadEstudio
    {
        protected int IDModalidad { get; set; }
        public string? Modalidad { get; set; }
        public double? PrecioMatriculas { get; set; } = 500;

        public abstract string DescuentoModalidad();
        public abstract double TotalPago();
    }
}
