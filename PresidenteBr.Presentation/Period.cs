using System;
using System.Collections.Generic;
using PresidentesBr.Interface;
using PresidentesBr.Model;
using PresidentesBr.Model.Enums;

namespace PresidenteBr.Presentation
{
    public class Period
    {
        public static void DisplayPeriod()
        {
            Periodos.setPeriodos();
            Periodos.ListPeriodos();
        }
        
    }
}