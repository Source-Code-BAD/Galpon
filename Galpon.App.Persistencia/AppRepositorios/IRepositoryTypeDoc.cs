using System.Collections.Generic;
using Galpon.App.Dominio; 

namespace Galpon.App.Persistencia {

    public interface IRepositoryTypeDoc {

        IEnumerable<TypeDoc> GetAllTypeDocs();
        TypeDoc AddTypeDoc(TypeDoc typeDoc);
        TypeDoc UpdateTypeDoc(TypeDoc typeDoc);
        void DeleteTypeDoc(int idTypeDoc);
        TypeDoc GetTypeDoc(int idTypeDoc);
    }

}