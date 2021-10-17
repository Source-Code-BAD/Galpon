using System;

namespace Galpon.App.Dominio {

    public class Historical {

        // Identificador único de cada persona
       
        public int id { get; set; }
        public Shed shed { get; set; }
        public Employer employer { get; set; }
        public int temperature { get; set; }
        public int water { get; set; }
        public string food { get; set; }
        public string sick_chickens { get; set; }
        public int quantity_eggs { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }

    }

}