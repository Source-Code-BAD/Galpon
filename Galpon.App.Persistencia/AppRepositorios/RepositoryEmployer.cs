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

        void IRepositoryEmployer.DeleteEmployer(int idEmployer) {

            var employerSearch = _appContext.Employers.FirstOrDefault(e => e.id==idEmployer);
            if ( employerSearch == null ) return;
            _appContext.Employers.Remove(employerSearch);
            _appContext.SaveChanges();

        }

        IEnumerable<Employer> IRepositoryEmployer.GetAllEmployers() {

            return _appContext.Employers;

        }

        Employer IRepositoryEmployer.GetEmployer(int idUser) {

            return _appContext.Employers.FirstOrDefault(e => e.id==idUser);

        }

        Employer IRepositoryEmployer.UpdateEmployer(Employer employer) {

            var employerSearch = _appContext.Employers.FirstOrDefault(e => e.id== employer.id);
            if ( employerSearch != null ) {

                employerSearch.complete_name = employer.complete_name;
                employerSearch.gender = employer.gender;
                employerSearch.type_doc = employer.type_doc;
                employerSearch.number_doc = employer.number_doc;
                employerSearch.rol = employer.rol;
                employerSearch.phone = employer.phone;
                employerSearch.address = employer.address;
                employerSearch.email = employer.email;
                employerSearch.updated_date = employer.updated_date;

                _appContext.SaveChanges();
            }

            return employerSearch;
        }
    }

}