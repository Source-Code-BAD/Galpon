using System.Collections.Generic;
using Galpon.App.Dominio; 

namespace Galpon.App.Persistencia
{
    public interface IRepositoryShed
    {
        IEnumerable<Shed> GetAllSheds();
        Shed AddShed(Shed shed);
        Shed UpdateShed(Shed shed);
        void DeleteShed(int idShed);
        Shed GetShed(int idShed);
    }
}