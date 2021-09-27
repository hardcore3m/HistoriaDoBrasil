using System;
using System.Collections.Generic;
using PresidentesBr.Model.Enums;
using PresidentesBr.Interface;
namespace PresidentesBr.Model
{
    public class Presidente : IEquatable<Presidente>, IPresidente
    {
        public Presidente(int order, string shortName, string name, EMandato mandato, ERepublica republica, string arrival, int startYear, string conclusion, int endYear, string born, string death, string career, string consort, string party)
        {
            this.order = order;
            this.shortName = shortName;
            this.name = name;
            this.mandato = mandato;
            this.republica = republica;
            this.arrival = arrival;
            this.startYear = startYear;
            this.conclusion = conclusion;
            this.endYear = endYear;
            this.born = born;
            this.death = death;
            this.career = career;
            this.consort = consort;
            this.party = party;
        }

        public int order { get; set; }
        public string shortName { get; set; }
        public string name { get; set; }
        public EMandato mandato { get; set; }
        public ERepublica republica { get; set; }
        public string arrival { get; set; }
        public int startYear { get; set; }
        public string conclusion { get; set; }
        public int endYear { get; set; }
        public string born { get; set; }
        public string death { get; set; }
        public string career { get; set; }
        public string consort { get; set; }
        public string party { get; set; }

        public string QuickList(string shortName, string career, string arrival, string conusion)
        {
            return $"{shortName}\t\t {career} de carreira, presidiu o brasil de {arrival} até {conclusion}";
        }
        public bool Equals(Presidente other)
        {
            if (other == null) return false;
            return (this.shortName.Equals(other.shortName));
        }
        public string sMandato;
        public string sRepublica;
        public void shiftPresidente()
        {
            if (mandato == EMandato.Diretamente)
            {
                this.sMandato = "Eleições diretas";
            }
            else if (mandato == EMandato.Sucessao)
            {
                this.sMandato = "Linha sucessória";
            }
            else if (mandato == EMandato.Indiretamente)
            {
                this.sMandato = "Eleições indiretas, emposse ou golpe";
            }
            else if (mandato == EMandato.Impedimento)
            {
                this.sMandato = "Impedidos ou falecidos antes do empossamento";
            }
            else
            {
                this.sMandato = "...";
            }


            if (republica == ERepublica.Primeira)
            {
                this.sRepublica = "A República Velha (1889 a 1930)";
            }
            else if (republica == ERepublica.Segunda)
            {
                this.sRepublica = "A Segunda República (1930 a 1937)";
            }
            else if (republica == ERepublica.terceira)
            {
                this.sRepublica = "O Estado Novo (1937 a 1946)";
            }
            else if (republica == ERepublica.quarta)
            {
                this.sRepublica = "A Republica Populista (1946 a 1964)";
            }
            else if (republica == ERepublica.quinta)
            {
                this.sRepublica = "A Ditadura Militar (1964 a 1985)";
            }
            else if (republica == ERepublica.sexta)
            {
                this.sRepublica = "A Nova República (1985 a 2022)";
            }
            else
            {
                this.sRepublica = "...";
            }
        }


        public string ListPresidentes(int republicaCount)
        {

            shiftPresidente();

            var underscore = new string('=', shortName.Length);

            return $"{shortName}\n{underscore}\n\n{order}.o(a) Presidente(a) do Brasil\n{republicaCount}o(a). presidente d{sRepublica.ToLower()}\nMandato:\t{arrival} a {conclusion}\n\nEleição:\t{sMandato}\nPartido:\t{party}\n\nNome:\t\t{name}\nNascimento:\t{born}\nMorte:\t\t{death}\nCônjuge:\t{consort}";
        }
        public string SearchPresidente(string SearchPresidente)
        {
            return null;
        }
    }
}