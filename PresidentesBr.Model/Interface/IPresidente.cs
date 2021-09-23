using PresidentesBr.Model.Enums;
namespace PresidentesBr.Interface
{
    public interface IPresidente
    {
         string ListPresidentes(int order, string shortName, string name,EMandato mandato,ERepublica republica, string arrival, int startYear, string conclusion, int endYear, string born, string death, string career, string consort, string party);
         string QuickList(string shortName,string career,string arrival,string conusion);
    }
}