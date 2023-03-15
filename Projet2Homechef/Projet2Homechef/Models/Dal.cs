
using Projet2Homechef.Models.Prestation;
using Projet2Homechef.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Projet2Homechef.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext;
        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }

        public void Dispose()
        {
            _bddContext.Dispose();
        }


        //Methode Villageois
        public void AjouterVillageois(string userName, string password, string nom, string prenom, DateTime dateDeNaissance, string email, string tel)
        {
            Villageois villageois = new Villageois() { UserName = userName, Password = password, Nom = nom, Prenom = prenom, DateDeNaissance = dateDeNaissance, Email = email, Tel = tel, Role = "Villageois", Valider = 0 };
            _bddContext.Village.Add(villageois);
            _bddContext.SaveChanges();

        }
        public Villageois ObtientUnVillageois(int id)
        {
            Villageois villageois = _bddContext.Village.Find(id);
            return villageois;
        }

        public List<Villageois> ObtientTousLesVillageois()
        {
            return _bddContext.Village.ToList();
        }

        public void SupprimerVillageois(int id)
        {
            Villageois villageois = _bddContext.Village.Find(id);
            if (villageois != null)
            {
                _bddContext.Village.Remove(villageois);
                _bddContext.SaveChanges();
            }
        }

        public void ValiderVillageois(int id)
        {
            Villageois villageois = _bddContext.Village.Find(id);
            if (villageois != null)
            {
                villageois.Valider = 1;

                _bddContext.SaveChanges();
            }
        }

        

        public void ModifierVillageois(int idVillageoisAModifier, string userName, string password, string nom, string prenom, DateTime dateDeNaissance, string email, string tel)
        {
            Villageois villageois = _bddContext.Village.Find(idVillageoisAModifier);
            if (villageois != null)
            {
                villageois.UserName = userName;
                villageois.Password = password;
                villageois.Nom = nom;
                villageois.Prenom = prenom;
                villageois.DateDeNaissance = dateDeNaissance;
                villageois.Email = email;
                villageois.Tel = tel;

                _bddContext.SaveChanges();
            }
        }

        public Villageois Authentifier(string userName, string password)
        {

            Villageois user = this._bddContext.Village.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            return user;
        }


        //Methode Service
        public Service ObtientUnService(int id)
        {
            Service service = _bddContext.Services.Find(id);
            return service;
        }
        public List<Service> ObtientTousLesServices()
        {
            List<Service> listeServices = this._bddContext.Services.ToList();
            return listeServices;
        }
        public void CreerService(string titre, string description, string imagePath, int idChef)
        {
            Villageois villageois = _bddContext.Village.Find(idChef);
            Service serviceToAdd = new Service { Titre = titre, Description = description, Valider = 0, Chef = villageois, ImagePath = imagePath };


            this._bddContext.Services.Add(serviceToAdd);
            this._bddContext.SaveChanges();
        }

        public void SupprimerService(int id)
        {
            Service service = _bddContext.Services.Find(id);
            if (service != null)
            {
                _bddContext.Services.Remove(service);
                _bddContext.SaveChanges();
            }
        }

        public void ValiderService(int id)
        {
            Service service = _bddContext.Services.Find(id);
            if (service != null)
            {
                service.Valider = 1;

                _bddContext.SaveChanges();
            }
        }

        public void ModifierService(int id, string Titre, string Description, int ChefId)
        {
            Service service = _bddContext.Services.Find(id);
            if (service != null)
            {
                service.Titre = Titre;
                service.Description = Description;
                service.Chef = _bddContext.Village.Find(ChefId);

                _bddContext.SaveChanges();
            }
        }


        //Methode Commande

        public Commande ObtientUneCommande(int id)
        {
            Commande commande = _bddContext.Commandes.Find(id);
            return commande;
        }

        public List<Commande> ObtientToutesLesCommandes()
        {
            List<Commande> listeCommandes = this._bddContext.Commandes.Include(c=> c.Service).ToList();
            return listeCommandes;
        }

       public int ObtientIdCommande(int statut)
        {
            int idCommande;
            List<Commande> listeCommandes = this._bddContext.Commandes.ToList();
            int i = 0;
            while (listeCommandes[i].Statut != statut)
            {
                i++;
            }
            idCommande = listeCommandes[i].Id;
            return idCommande;
        }

        public void AjouterPrestation(int idService, int idUser)
        {          
            Commande nouvelleCommande = new Commande();
            nouvelleCommande.Villageois = ObtientUnVillageois(idUser);
            nouvelleCommande.Service = ObtientUnService(idService); 
            _bddContext.Commandes.Add(nouvelleCommande);
            _bddContext.SaveChanges();                       
        }

        public void AjouterDemande(int id, String demande, DateTime datePrestation)
        {
            Commande commande = _bddContext.Commandes.Find(id);
            commande.Demande = demande;
            commande.DatePrestation = datePrestation;
            commande.Statut = 1;
            _bddContext.SaveChanges();
        }

        public void MonterDevis(int id, String devis, double cout)
        {
            Commande commande = _bddContext.Commandes.Find(id);
            commande.Devis = devis;
            commande.Cout = cout;
            commande.Statut = 2;
            _bddContext.SaveChanges();
        }

        public void ConfirmerDevis(int id, String confirmationDevis)
        {
            Commande commande = _bddContext.Commandes.Find(id);
            commande.ConfirmationDevis = confirmationDevis;
            commande.Statut = 3;
            _bddContext.SaveChanges();
        }

        public void ConfirmationPrestation(int id, String confirmationPrestation)
        {
            Commande commande = _bddContext.Commandes.Find(id);
            commande.ConfirmationPrestation = confirmationPrestation;
            commande.Statut = 4;
            _bddContext.SaveChanges();
        }

        public void ConfirmerRetour(int id, String confirmationRetour)
        {
            Commande commande = _bddContext.Commandes.Find(id);
            commande.ConfirmationRetour = confirmationRetour;
            commande.Statut = 5;
            _bddContext.SaveChanges();
        }
    }
}
