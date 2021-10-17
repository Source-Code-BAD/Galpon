using System;

namespace Galpon.App.Dominio {

    public class AssignedShed {

        // Identificador único de cada persona
       
        public int id { get; set; }
        public Shed shed { get; set; }
        public Employer employer { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }

    }

}