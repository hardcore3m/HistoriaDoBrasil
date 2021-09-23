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

        public string QuickList(string shortName,string career, string arrival, string conusion)
        {
            return $"{shortName}\t\t {career} de carreira, presidiu o brasil de {arrival} até {conclusion}";
        }
        public bool Equals(Presidente other)
        {
            if (other == null) return false;
            return (this.shortName.Equals(other.shortName));
        }
        public string ListPresidentes(int order, string shortName, string name,EMandato mandato,ERepublica republica, string arrival, int startYear, string conclusion, int endYear, string born, string death, string career, string consort, string party){
            return $"{shortName}\t\t {career} de carreira, presidiu o brasil de {arrival} até {conclusion}";
        }
    }
}