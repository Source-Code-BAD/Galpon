using System;

namespace Galpon.App.Dominio {

    public class User {

        // Identificador único de cada persona
        public int id { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }

    }

}