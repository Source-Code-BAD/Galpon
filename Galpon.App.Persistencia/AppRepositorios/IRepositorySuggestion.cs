using System.Collections.Generic;
using Galpon.App.Dominio; 

namespace Galpon.App.Persistencia {

    public interface IRepositorySuggestion {

        IEnumerable<Suggestion> GetAllSuggestions();
        Suggestion AddSuggestion(Suggestion suggestion);
        Suggestion UpdateSuggestion(Suggestion suggestion);
        void DeleteSuggestion(int idSuggestionr);
        Suggestion GetSuggestion(int idSuggestion);
    }

}