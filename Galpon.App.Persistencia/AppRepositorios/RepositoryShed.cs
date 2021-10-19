using System.Collections.Generic;
using System.Linq;
using Galpon.App.Dominio;

namespace Galpon.App.Persistencia
{
    public class RepositoryShed : IRepositoryShed
    {

        private readonly AppContext _appContext;
        
        public RepositoryShed(AppContext appContext) {
            _appContext = appContext;
        }

        Shed IRepositoryShed.AddShed(Shed shed) {

            var shedAdd = _appContext.Sheds.Add(shed);
            _appContext.SaveChanges();
            return shedAdd.Entity;

        }

        void IRepositoryShed.DeleteShed(int idShed) {

            var shedSearch = _appContext.Sheds.FirstOrDefault(s => s.id==idShed);
            if ( shedSearch == null ) return;
            _appContext.Sheds.Remove(shedSearch);
            _appContext.SaveChanges();

        }

        IEnumerable<Shed> IRepositoryShed.GetAllSheds() {

            return _appContext.Sheds;

        }

        Shed IRepositoryShed.GetShed(int idShed) {

            return _appContext.Sheds.FirstOrDefault(s => s.id==idShed);

        }

        Shed IRepositoryShed.UpdateShed(Shed shed) {

            var shedSearch = _appContext.Sheds.FirstOrDefault(s => s.id== shed.id);
            if ( shedSearch != null ) {

                shedSearch.name = shed.name;
                shedSearch.total_animals = shed.total_animals;
                shedSearch.admission_date = shed.admission_date;
                shedSearch.departure_date = shed.departure_date;
                shedSearch.longitude = shed.longitude;
                shedSearch.latitude = shed.latitude;
                shedSearch.updated_date = shed.updated_date;

                _appContext.SaveChanges();
            }

            return shedSearch;
        }
    }
}