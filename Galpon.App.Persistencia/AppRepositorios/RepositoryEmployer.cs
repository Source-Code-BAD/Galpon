using System.Collections.Generic;
using System.Linq;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {
    
    public class RepositoryEmployer : IRepositoryEmployer {

        /// <summary>
        /// Referencia al contexto de usuarios
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>

        public RepositoryEmployer(AppContext appContext) {
            _appContext = appContext;
        }

        Employer IRepositoryEmployer.AddEmployer(Employer employer) {

            var employerAdd = _appContext.Employers.Add(employer);
            _appContext.SaveChanges();
            return employerAdd.Entity;

        }
    }

}