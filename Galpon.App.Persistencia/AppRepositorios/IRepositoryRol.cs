using System.Collections.Generic;
using Galpon.App.Dominio; 

namespace Galpon.App.Persistencia {

    public interface IRepositoryRol {

        IEnumerable<Rol> GetAllRoles();
        Rol AddRol(Rol rol);
        Rol UpdateRol(Rol rol);
        void DeleteRol(int idRol);
        Rol GetRol(int idRol);
    }

}