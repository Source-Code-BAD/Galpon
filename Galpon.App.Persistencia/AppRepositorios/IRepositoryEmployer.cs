using System.Collections.Generic;
using Galpon.App.Dominio; 

namespace Galpon.App.Persistencia {

    public interface IRepositoryEmployer {

        IEnumerable<Employer> GetAllEmployers();
        Employer AddEmployer(Employer employer);
        Employer UpdateEmployer(Employer employer);
        void DeleteEmployer(int idEmployer);
        Employer GetEmployer(int idEmployer);
    }

}