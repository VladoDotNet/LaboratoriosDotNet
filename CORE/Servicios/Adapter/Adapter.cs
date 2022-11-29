﻿using CORE.Interfaces.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Servicios.Adapter
{
    public class Adapter : ITarget
    {
        private readonly AdapteeServicio _adapatee;

        public Adapter(AdapteeServicio adapateeServicio) //<-- Constructor
        {
            _adapatee = adapateeServicio;
        }
        
        public async Task PrecesarFormatosEscuela(string formato)
        {
            switch (formato)
            {
                case string s when s == "XML" || s == "JSON" || s == "TEXTO PLANO":
                    Console.WriteLine("PROCESANDO . . .  Formatos de la Escuela\n ");
                    await Task.Delay(3000);
                    Console.WriteLine($"Formateo a {formato} exitoso!\n ");
                    break;
                default:
                    Console.WriteLine("PROCESANDO . . .  Formatos especiales\n ");
                    var ConversionOtro =  await _adapatee.ProcesarRequerimientos(formato);
                    Console.WriteLine(ConversionOtro);
                    break;
            }
        }
    }
}