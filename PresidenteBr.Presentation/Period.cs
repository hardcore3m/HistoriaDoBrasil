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
            SetAge();
        }

        static void SetAge()
        {
            List<Epocas> epocas = new List<Epocas>();
            epocas.Add(new Epocas(1, "Descobrimento e brasil colonial", "Descoberta ou descobrimento do Brasil refere-se, do ponto de vista dos europeus, à descoberta por europeus do território atualmente conhecido como Brasil. Este momento é muitas vezes entendido como sendo o do avistamento da terra que então denominaram por Ilha da Vera Cruz, nas imediações do Monte Pascoal, pela armada comandada por Pedro Álvares Cabral, ocorrida no dia 22 de abril de 1500.", DateTime.Parse("22/04/1500"), DateTime.Parse("22/04/1600")));
            TimeSpan duration = epocas[0].EndsIn.Subtract(epocas[0].startIn);
            Console.WriteLine($"{epocas[0].age} - {epocas[0].startIn.Date.ToString("dd/MM/yyyy")} a {epocas[0].EndsIn.Date.ToString("dd/MM/yyyy")} ({Convert.ToDouble(duration.Days/365)} anos)\n\n{epocas[0].details}");
        }
    }
}