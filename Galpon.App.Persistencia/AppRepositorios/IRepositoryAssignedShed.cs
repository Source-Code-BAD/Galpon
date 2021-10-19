using System.Collections.Generic;
using Galpon.App.Dominio; 

namespace Galpon.App.Persistencia {

    public interface IRepositoryAssignedShed {

        IEnumerable<AssignedShed> GetAllAssignedSheds();
        AssignedShed AddAssignedShed(AssignedShed assignedShed);
        AssignedShed UpdateAssignedShed(AssignedShed assignedShed);
        void DeleteAssignedShed(int idAssignedShed);
        AssignedShed GetAssignedShed(int idAssignedShed);
    }

}