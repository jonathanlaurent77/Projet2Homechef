using Projet2Homechef.Models;
using Projet2Homechef.Models.Prestation;
using System;
using System.Collections.Generic;

namespace Projet2Homechef.ViewModels
{
    public class HomeViewModel
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public List<Service> ListeDesServices { get; set; }
        public List<Service> ListeDesServices2 { get; set; }

        public List<Villageois> ListeDesVillageois { get; set; }    
        public List<Commande> ListeDesCommandes { get; set; }
        public Villageois VillageoisConnected { get; set;  }

        //
        public VillageoisViewModel VVM { get; set; }
        


    }
}
