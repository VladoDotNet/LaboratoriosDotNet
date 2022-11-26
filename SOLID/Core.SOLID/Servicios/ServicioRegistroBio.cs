using Core.SOLID.Entidades;
using Core.SOLID.Interfaces;

namespace Core.SOLID.Servicios
{
    public class ServicioRegistroBio : IServicioRegistroBio
    {
        
        public void RegistrosBIO(int idEstu, DateTime FechaReg)
        {
            var RegIngresos = new ControlIngresos()
            {
                IDIngreso = 1,
                IDEstudiante = idEstu,
                FechaReg = FechaReg
            };
        }
    }
}
