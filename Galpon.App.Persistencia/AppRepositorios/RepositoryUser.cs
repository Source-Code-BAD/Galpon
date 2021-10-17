using System.Collections.Generic;
using System.Linq;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {

    public class RepositoryUser : IRepositoryUser {

        /// <summary>
        /// Referencia al contexto de usuarios
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>

        public RepositoryUser(AppContext appContext) {
            _appContext = appContext;
        }

        User IRepositoryUser.AddUser(User user) {

            var userAdd = _appContext.Users.Add(user);
            _appContext.SaveChanges();
            return userAdd.Entity;

        }

        void IRepositoryUser.DeleteUser(int idUser) {

            var userSearch = _appContext.Users.FirstOrDefault(u => u.id==idUser);
            if ( userSearch == null ) return;
            _appContext.Users.Remove(userSearch);
            _appContext.SaveChanges();

        }

        IEnumerable<User> IRepositoryUser.GetAllUsers() {

            return _appContext.Users;

        }

        User IRepositoryUser.GetUser(int idUser) {

            return _appContext.Users.FirstOrDefault(u => u.id==idUser);

        }

        User IRepositoryUser.UpdateUser(User user) {

            var userSearch = _appContext.Users.FirstOrDefault(u => u.id== user.id);
            if ( userSearch != null ) {

                userSearch.user = user.user;
                userSearch.pass = user.pass;

                _appContext.SaveChanges();
            }

            return userSearch;
        }
    }

}