using System;
using System.Collections.Generic;
using PresidentesBr.Model.Enums;
using PresidentesBr.Interface;

namespace PresidentesBr.Model
{
    
    public class Epocas : IEquatable<Epocas>, IEpocas
    {
        public Epocas(int id, string age, string details, DateTime startIn, DateTime endsIn)
        {
            this.id = id;
            this.age = age;
            this.period = Periodos.periodList[id];
            this.details = details;
            this.startIn = startIn;
            this.EndsIn = endsIn;
        }

        public int id { get; set; }
        public string age { get; set; }
        public string period {get;set;}
        public string details{get;set;}
        public DateTime startIn {get;set;}
        public DateTime EndsIn {get;set;}

        public bool Equals(Epocas other)
        {
            if (other == null) return false;
            return (this.age.Equals(other.age));
        }
       
    }
    public class Periodos : IEquatable<Periodos>
    {
        public static Dictionary<int, string> periodList = new Dictionary<int, string>();
        public static void setPeriodos()
        {
            int i = 0;
            foreach (var item in Enum.GetNames(typeof(Reinado)))
            {
                periodList.Add(i, item);
                i++;
            }
            foreach (var item in Enum.GetNames(typeof(ERepublica)))
            {
                periodList.Add(i, item);
                i++;
            }
        }
        public bool Equals(Periodos other)
        {
            if (other == null) return false;
            return (this.Equals(other));
        }
        public static void ListPeriodos()
        {            
            foreach (KeyValuePair<int, string> period in periodList)
            {
                Console.WriteLine(period);
            }
        }
    }

}