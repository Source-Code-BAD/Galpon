using System.Collections.Generic;
using System.Linq;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {

    public class RepositoryRol : IRepositoryRol {

        /// <summary>
        /// Referencia al contexto de usuarios
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>

        public RepositoryRol(AppContext appContext) {
            _appContext = appContext;
        }

        Rol IRepositoryRol.AddRol(Rol rol) {

            var rolAdd = _appContext.Roles.Add(rol);
            _appContext.SaveChanges();
            return rolAdd.Entity;

        }

        void IRepositoryRol.DeleteRol(int idRol) {

            var rolSearch = _appContext.Roles.FirstOrDefault(r => r.id==idRol);
            if ( rolSearch == null ) return;
            _appContext.Roles.Remove(rolSearch);
            _appContext.SaveChanges();

        }

        IEnumerable<Rol> IRepositoryRol.GetAllRoles() {

            return _appContext.Roles;

        }

        Rol IRepositoryRol.GetRol(int idRol) {

            return _appContext.Roles.FirstOrDefault(r => r.id==idRol);

        }

        Rol IRepositoryRol.UpdateRol(Rol rol) {

            var rolSearch = _appContext.Roles.FirstOrDefault(r => r.id== rol.id);
            if ( rolSearch != null ) {

                rolSearch.name = rol.name;
                rolSearch.updated_date = rol.updated_date;

                _appContext.SaveChanges();
            }

            return rolSearch;
        }
    }

}