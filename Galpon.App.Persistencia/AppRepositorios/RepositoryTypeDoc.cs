using System.Collections.Generic;
using System.Linq;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {

    public class RepositoryTypeDoc : IRepositoryTypeDoc {

        /// <summary>
        /// Referencia al contexto de usuarios
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>

        public RepositoryTypeDoc(AppContext appContext) {
            _appContext = appContext;
        }

        TypeDoc IRepositoryTypeDoc.AddTypeDoc(TypeDoc typeDoc) {

            var typeDocAdd = _appContext.TypeDocs.Add(typeDoc);
            _appContext.SaveChanges();
            return typeDocAdd.Entity;

        }

        void IRepositoryTypeDoc.DeleteTypeDoc(int idTypeDoc) {

            var typeDocSearch = _appContext.TypeDocs.FirstOrDefault(u => u.id==idTypeDoc);
            if ( typeDocSearch == null ) return;
            _appContext.TypeDocs.Remove(typeDocSearch);
            _appContext.SaveChanges();

        }

        IEnumerable<TypeDoc> IRepositoryTypeDoc.GetAllTypeDocs() {

            return _appContext.TypeDocs;

        }

        TypeDoc IRepositoryTypeDoc.GetTypeDoc(int idTypeDoc) {

            return _appContext.TypeDocs.FirstOrDefault(u => u.id==idTypeDoc);

        }

        TypeDoc IRepositoryTypeDoc.UpdateTypeDoc(TypeDoc typeDoc) {

            var typeDocSearch = _appContext.TypeDocs.FirstOrDefault(u => u.id== typeDoc.id);
            if ( typeDocSearch != null ) {

                typeDocSearch.name = typeDoc.name;
                typeDocSearch.updated_date = typeDoc.updated_date;

                _appContext.SaveChanges();
            }

            return typeDocSearch;
        }
    }

}