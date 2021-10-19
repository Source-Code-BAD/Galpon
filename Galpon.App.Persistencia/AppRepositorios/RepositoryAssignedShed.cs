using System.Collections.Generic;
using System.Linq;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {

    public class RepositoryAssignedShed : IRepositoryAssignedShed {

        /// <summary>
        /// Referencia al contexto de usuarios
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>

        public RepositoryAssignedShed(AppContext appContext) {
            _appContext = appContext;
        }

        AssignedShed IRepositoryAssignedShed.AddAssignedShed(AssignedShed assignedShed) {

            var assignedShedAdd = _appContext.AssignedSheds.Add(assignedShed);
            _appContext.SaveChanges();
            return assignedShedAdd.Entity;

        }

        void IRepositoryAssignedShed.DeleteAssignedShed(int idAssignedShed) {

            var assignedShedSearch = _appContext.AssignedSheds.FirstOrDefault(a => a.id==idAssignedShed);
            if ( assignedShedSearch == null ) return;
            _appContext.AssignedSheds.Remove(assignedShedSearch);
            _appContext.SaveChanges();

        }

        IEnumerable<AssignedShed> IRepositoryAssignedShed.GetAllAssignedSheds() {

            return _appContext.AssignedSheds;

        }

        AssignedShed IRepositoryAssignedShed.GetAssignedShed(int idAssignedShed) {

            return _appContext.AssignedSheds.FirstOrDefault(a => a.id==idAssignedShed);

        }

        AssignedShed IRepositoryAssignedShed.UpdateAssignedShed(AssignedShed assignedShed) {

            var assignedShedSearch = _appContext.AssignedSheds.FirstOrDefault(a => a.id== assignedShed.id);
            if ( assignedShedSearch != null ) {

                assignedShedSearch.shed = assignedShed.shed;
                assignedShedSearch.employer = assignedShed.employer;
                assignedShedSearch.updated_date = assignedShed.updated_date;

                _appContext.SaveChanges();
            }

            return assignedShedSearch;
        }
    }

}