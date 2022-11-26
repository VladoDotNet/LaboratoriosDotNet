using Core.Interfaces.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Servicios.AbstractFactory
{
    public class ProyectosSociales : IPrySocial
    {
        public string NombreProyecto(string modalidad)
        {
            return "Niños huerfanos Zona sur\n " +
                $"Modalidad : {modalidad}";
        }
    }
}
