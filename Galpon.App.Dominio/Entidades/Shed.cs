using System;

namespace Galpon.App.Dominio {

    public class Shed {

        // Identificador único de cada persona
        public int id { get; set; }
        public string name { get; set; }
        public int total_animals { get; set; }
        public DateTime admission_date { get; set; }
        public DateTime departure_date { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }

    }

}