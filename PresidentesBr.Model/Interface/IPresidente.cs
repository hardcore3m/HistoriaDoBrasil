using PresidentesBr.Model.Enums;
namespace PresidentesBr.Interface
{
    public interface IPresidente
    {
         string ListPresidentes(int republicaCount);
         string QuickList(string shortName,string career,string arrival,string conusion);
         string SearchPresidente(string SearchPresidente);
         
    }
}