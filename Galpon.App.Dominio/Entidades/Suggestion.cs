using System;

namespace Galpon.App.Dominio {

    public class Suggestion {

        // Identificador único de cada persona
       
        public int id { get; set; }
        public Shed shed_id { get; set; }
        public Employer employer_id { get; set; }
        public string suggestion { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }

    }

}