using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet2Homechef.Models.Prestation
{
    public class Commande
    {
        public int Id { get; set; }
        public Service Service { get; set; }
        public int Statut { get; set; }
        //Pour la demande de service
        public Villageois Villageois { get; set; }
        public string Demande { get; set; }
        [Column(TypeName = "date")]
        public DateTime DatePrestation { get; set; }
        //Pour monter le devis
        public string Devis { get; set; }
        public double Cout { get; set; }
        //Pour confirmer le devis
        public string ConfirmationDevis { get; set; }
        //Pour confirmer la prestation
        public string ConfirmationPrestation { get; set; }
        //Pour confirmer le retour du materiel
        public string ConfirmationRetour { get; set; }
        //Reclamation
        public int StatutReclamation { get; set; }
        public string ReclamationVillageois { get; set; }
        public string ReclamationChef { get; set; }
        public string ReponseGestionnaire { get; set; }
    }
}


//Statut d'une presatation
/*
Statut = 1
Demande de Service Villageois
Avec date
Statut = 2
Creation du devis Chef
Statut = 3
Confirmation du devis Villageois
Accès aux informations entre Chef et villageois
Simulation de bloquage d'argent du Villageois
Statut = 4
Confirmation de la prestation Villageois
Simulation de bloquage d'argent du Villageois
Statut = 5
Confirmation du retour du materiel Chef

 */