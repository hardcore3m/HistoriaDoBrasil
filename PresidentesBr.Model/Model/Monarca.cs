using System;
using System.Collections.Generic;
using PresidentesBr.Model.Enums;
namespace PresidentesBr.Model
{
    public class Monarca : IEquatable<Monarca>
    {
        public Monarca(string name, string nickName, string arrival, int startYear, string conclusion, int endYear, string born, string death, Dinastia dinastia, Reinado reinado)
        {
            this.name = name;
            this.nickName = nickName;
            this.arrival = arrival;
            this.startYear = startYear;
            this.conclusion = conclusion;
            this.endYear = endYear;
            this.born = born;
            this.death = death;
            this.dinastia = dinastia;
            this.reinado = reinado;

        }
        public string name { get; set; }
        public string nickName { get; set; }
        public string arrival { get; set; }
        public int startYear { get; set; }
        public string conclusion { get; set; }
        public int endYear { get; set; }
        public string born { get; set; }
        public string death { get; set; }
        public Dinastia dinastia { get; set; }
        public Reinado reinado { get; set; }
        public string sDinastia;
        public string sReinado;
        public override string ToString()
        {

            if (dinastia == Dinastia.Avis)
            {
                this.sDinastia = "Avis";
            }
            else if (dinastia == Dinastia.Bragança)
            {
                this.sDinastia = "Bragança";
            }
            else if (dinastia == Dinastia.habsburgo)
            {
                this.sDinastia = "Habsburgo";
            }
            else
            {
                this.sDinastia = "alguma família portuguesa";
            }


            if (reinado == Reinado.Colonial)
            {
                this.sReinado = "O reino de Portugal e Algarves";
            }
            else if(reinado==Reinado.UniaoIberica)
            {
                this.sReinado = "A União Ibérica";
            }
            else if(reinado==Reinado.Restauracao)
            {
                this.sReinado = "A restauração da Indepêndencia de portugal";
            }
            else if(reinado==Reinado.ReinoUnido)
            {
                this.sReinado = "O Reino Unido de Portugal, Brasil e Algarves";
            }
            else if(reinado==Reinado.BrasilImperio)
            {
                this.sReinado = "O Brasil Império";
            }

            return $"\n{name}, {nickName}, da dinastia de {sDinastia}, reinou o Brasil entre {arrival} e {conclusion}, durante o periodo conhecido como '{sReinado}'. Nasceu em {born} e Morreu em {death}.\n";
        }
        public bool Equals(Monarca other)
        {
            if (other == null) return false;
            return (this.name.Equals(other.name));
        }
    }
}