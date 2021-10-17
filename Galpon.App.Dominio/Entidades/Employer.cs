using System;

namespace Galpon.App.Dominio {

    public class Employer {

        // Identificador único de cada persona
        public int id { get; set; }
        public User user { get; set; }
        public string complete_name { get; set; }
        public Gender gender { get; set; }
        public TypeDoc type_doc { get; set; }
        public string number_doc { get; set; }
        public Rol rol { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }

    }

}