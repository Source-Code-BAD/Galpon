using System.Collections.Generic;
using System.Linq;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {

    public class RepositoryHistorical : IRepositoryHistorical {
        /// <summary>
        /// Referencia al contexto de usuarios
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        
        public RepositoryHistorical(AppContext appContext) {
            _appContext = appContext;
        }

        Historical IRepositoryHistorical.AddHistorical(Historical historical) {

            var historicalAdd = _appContext.Historicals.Add(historical);
            _appContext.SaveChanges();
            return historicalAdd.Entity;

        }
        void IRepositoryHistorical.DeleteHistorical(int idHistorical) {

            var historicalSearch = _appContext.Historicals.FirstOrDefault(h => h.id==idHistorical);
            if ( historicalSearch == null ) return;
            _appContext.Historicals.Remove(historicalSearch);
            _appContext.SaveChanges();

        }

        IEnumerable<Historical> IRepositoryHistorical.GetAllHistoricals() {

            return _appContext.Historicals;

        }
        Historical IRepositoryHistorical.GetHistorical(int idHistorical) {

            return _appContext.Historicals.FirstOrDefault(h => h.id==idHistorical);

        }

        Historical IRepositoryHistorical.UpdateHistorical(Historical historical) {

            var historicalSearch = _appContext.Historicals.FirstOrDefault(h => h.id==historical.id);
            if ( historicalSearch != null ) {

                historicalSearch.temperature=historical.temperature;
                historicalSearch.water=historical.water;
                historicalSearch.food=historical.food;
                historicalSearch.sick_chickens=historical.sick_chickens;
                historicalSearch.quantity_eggs=historical.quantity_eggs;
                historicalSearch.created_date=historical.created_date;
                historicalSearch.updated_date=historical.updated_date;

                _appContext.SaveChanges();
            }

            return historicalSearch;
        }

    }    
}