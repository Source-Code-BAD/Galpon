using System.Collections.Generic;
using Galpon.App.Dominio; 

namespace Galpon.App.Persistencia {

    public interface IRepositoryUser {

        IEnumerable<User> GetAllUsers();
        User AddUser(User user);
        User UpdateUser(User user);
        void DeleteUser(int idUser);
        User GetUser(int idUser);
    }

}