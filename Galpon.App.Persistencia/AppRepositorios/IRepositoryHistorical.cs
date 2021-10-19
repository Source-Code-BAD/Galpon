using System.Collections.Generic;
using Galpon.App.Dominio; 

namespace Galpon.App.Persistencia {

    public interface IRepositoryHistorical {

        IEnumerable<Historical> GetAllHistoricals();
        Historical AddHistorical(Historical historical);
        Historical UpdateHistorical(Historical historical);
        void DeleteHistorical(int idHistorical);
        Historical GetHistorical(int idHistorical);
    }

}