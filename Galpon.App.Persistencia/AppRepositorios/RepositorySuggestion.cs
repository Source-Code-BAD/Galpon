using System.Collections.Generic;
using System.Linq;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia {

    public class RepositorySuggestion : IRepositorySuggestion {
        private readonly AppContext _appContext;

        public RepositorySuggestion(AppContext appContext) {
            _appContext = appContext;
        }
         Suggestion IRepositorySuggestion.AddSuggestion(Suggestion suggestion) {

            var suggestionAdd = _appContext.Suggestions.Add(suggestion);
            _appContext.SaveChanges();
            return suggestionAdd.Entity;

        }
        void IRepositorySuggestion.DeleteSuggestion(int idSuggestion) {

            var suggestionSearch = _appContext.Suggestions.FirstOrDefault(h => h.id==idSuggestion);
            if ( suggestionSearch == null ) return;
            _appContext.Suggestions.Remove(suggestionSearch);
            _appContext.SaveChanges();

        }
        IEnumerable<Suggestion> IRepositorySuggestion.GetAllSuggestions() {

            return _appContext.Suggestions;

        }
        Suggestion IRepositorySuggestion.GetSuggestion(int idSuggestion) {

            return _appContext.Suggestions.FirstOrDefault(s => s.id==idSuggestion);

        }

        Suggestion IRepositorySuggestion.UpdateSuggestion(Suggestion suggestion) {

            var suggestionSearch = _appContext.Suggestions.FirstOrDefault(h => h.id==suggestion.id);
            if ( suggestionSearch != null ) {

                suggestionSearch.shed=suggestion.shed;
                suggestionSearch.employer=suggestion.employer;
                suggestionSearch.suggestion=suggestion.suggestion;
                suggestionSearch.created_date=suggestion.created_date;
                suggestionSearch.updated_date=suggestion.updated_date;
                

                _appContext.SaveChanges();
            }

            return suggestionSearch;
        }
    
    }


}