using Projet2Homechef.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet2Homechef.Models.Prestation;

namespace Projet2Homechef.Models
{
    public class BddContext : DbContext

    {
        public DbSet<Villageois> Village { get; set; }
        
        public DbSet<Service> Services { get; set; }

        public DbSet<Commande> Commandes { get; set; }
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.Village.AddRange(

                new Villageois
                {
                    Id = 1,
                    UserName = "PastaMaestro",
                    Password = "azerty",
                    Nom = "Bucharati",
                    Prenom = "Luigi",
                    DateDeNaissance = new DateTime(1990, 03, 02),
                    Email = "lbucharati@hotmail.com",
                    Tel = "0123456789",
                    Role = "Villageois",
                    Valider = 1
                },
              new Villageois
              {
                  Id = 2,
                  UserName = "UnitedKate",
                  Password = "azerty",
                  Nom = "Morgan",
                  Prenom = "Kathie",
                  DateDeNaissance = new DateTime(1990, 03, 02),
                  Email = "morgan@hotmail.com",
                  Tel = "0123456789",
                  Role = "Villageois",
                  Valider = 1

              },

                new Villageois
                {
                    Id = 3,
                    UserName = "Gourmand",
                    Password = "azerty",
                    Nom = "Lalane",
                    Prenom = "Francis",
                    DateDeNaissance = new DateTime(1990, 03, 02),
                    Email = "fralala@hotmail.com",
                    Tel = "0123456789",
                    Role = "Villageois",
                    Valider = 1

                },
                  new Villageois
                  {
                      Id = 4,
                      UserName = "Maximal",
                      Password = "azerty",
                      Nom = "Reno",
                      Prenom = "Maxine",
                      DateDeNaissance = new DateTime(1990, 03, 02),
                      Email = "aa@hotmail.com",
                      Tel = "0123456789",
                      Role = "Villageois",
                      Valider = 0

                  },
                    new Villageois
                    {
                        Id = 5,
                        UserName = "Alexia",
                        Password = "azerty",
                        Nom = "Alberta",
                        Prenom = "Alexandra",
                        DateDeNaissance = new DateTime(1990, 03, 02),
                        Email = "alexandraalberta@hotmail.com",
                        Tel = "0123456789",
                        Role = "Villageois",
                        Valider = 0

                    },
                      new Villageois
                      {
                          Id = 6,
                          UserName = "ViolinTanya",
                          Password = "azerty",
                          Nom = "Turner",
                          Prenom = "Tatyana",
                          DateDeNaissance = new DateTime(1990, 03, 02),
                          Email = "aa@hotmail.com",
                          Tel = "0123456789",
                          Role = "Villageois",
                          Valider = 0

                      }

            );
           

            Villageois villageoisA = this.Village.Find(1);
            Villageois villageoisB = this.Village.Find(2);
            Villageois villageoisC = this.Village.Find(3);
            Villageois villageoisD = this.Village.Find(4);

            this.Services.AddRange(

                new Service
                {
                    Id = 1,
                    Titre = "Gateau au chocolat",
                    Description = "Une femme dira toujours oui à du au chocolat",
                    Valider = 1,
                    Chef = villageoisB,
                    ImagePath = "/images/gateauchoco.jpg"
                },
                new Service
                {
                    Id = 2,
                    Titre = "Brownies",
                    Description = "Du chocolat portant le goût de l'amérique",
                    Valider = 1,
                    Chef = villageoisB,
                    ImagePath = "/images/brownie.jpg"
                },               
                new Service
                {
                    Id = 3,
                    Titre = "Tarte aux cocombre",
                    Description = "Un challenge accepté, un challenge complété",
                    Valider = 1,
                    Chef = villageoisB,
                    ImagePath = "/images/tartecocombre.jpg"
                },
                new Service
                {
                    Id = 4,
                    Titre = "Tarte aux citrons",
                    Description = "Avec cette tarte le citron redevient à la mode",
                    Valider = 1,
                    Chef = villageoisB,
                    ImagePath = "/images/tartecitron.jpg"
                },
               
                new Service
                {
                    Id = 5,
                    Titre = "Four à pain",
                    Description = "Faites cuir votre pain tous les dimanche matin",
                    Valider = 1,
                    Chef = villageoisA,
                    ImagePath = "/images/fourapain.jpg"
                },
                new Service
                {
                    Id = 6,
                    Titre = "Machine à pain",
                    Description = "Prêt d'une machine à pain",
                    Valider = 1,
                    Chef = villageoisA,
                    ImagePath = "/images/machineapain.jpg"
                },
                new Service
                {
                    Id = 7,
                    Titre = "Pate à pain",
                    Description = "Prête à mettre au four",
                    Valider = 1,
                    Chef = villageoisA,
                    ImagePath = "/images/pateapain.jpg"
                },
                new Service
                {
                    Id = 8,
                    Titre = "Autentique tagliatelle",
                    Description = "A gouter pour comprendre l'engouement",
                    Valider = 1,
                    Chef = villageoisA,
                    ImagePath = "/images/patefraiche.jpg"
                },
                new Service
               {
                   Id = 9,
                   Titre = "Tondeuse à gazon",
                   Description = "Pour la pelouse et les barbus",
                   Valider = 0,
                   Chef = villageoisD,
                   ImagePath = "/images/tondeuse.jpg"
               }
            );

            Service ServiceA = this.Services.Find(1);
            Service ServiceB = this.Services.Find(2);
            Service ServiceE = this.Services.Find(5);


            this.Commandes.AddRange(

                new Commande
                {
                    Id = 1,
                    Service = ServiceA,
                    Statut = 1,
                    Villageois = villageoisA,
                    Demande = "1 J'aime les gateau au chocolat, pour mardi prochain",
                    DatePrestation = DateTime.Now
                },

                new Commande
                {
                    Id = 2,
                    Service = ServiceA,
                    Statut = 2,
                    Villageois = villageoisC,
                    Demande = "2 J'aime les gateau au chocolat, pour mardi prochain",
                    DatePrestation = DateTime.Now,
                    Devis = "5 euro et un sourire!",
                    Cout = 5
                },

                /*new Commande
                {
                    Id = 3,
                    Service = ServiceA,
                    Statut = 3,
                    Villageois = villageoisB,
                    Demande = "3 J'aime les gateau au chocolat, pour mardi prochain",
                    DatePrestation = DateTime.Now,
                    Devis = "5 euro et un sourire!",
                    Cout = 5,
                    ConfirmationDevis = "Cela me convient sauf pour le sourire!"
                },

                new Commande
                {
                    Id = 4,
                    Service = ServiceA,
                    Statut = 4,
                    Villageois = villageoisB,
                    Demande = "4 J'aime les gateau au chocolat, pour mardi prochain",
                    DatePrestation = DateTime.Now,
                    Devis = "5 euro et un sourire!",
                    Cout = 5,
                    ConfirmationDevis = "Cela me convient sauf pour le sourire!",
                    ConfirmationPrestation = "Je l'ai apprécié ce gateau"
                },*/

                new Commande
                {
                    Id = 5,
                    Service = ServiceE,
                    Statut = 3,
                    Villageois = villageoisB,
                    Demande = "Je souhaite utiliser votre four pour me faire des petits pains",
                    DatePrestation = DateTime.Now,
                    Devis = "Avec plaisir, la première fois c'est offert!",
                    Cout = 0,
                    ConfirmationDevis = "J'en ferai en supplément et je vous ferai gouter!"
                    

                },

                new Commande
                {
                    Id = 6,
                    Service = ServiceA,
                    Statut = 5,
                    Villageois = villageoisD,
                    Demande = "5 J'aime les gateau au chocolat, pour mardi prochain",
                    DatePrestation = DateTime.Now,
                    Devis = "5 euro et un sourire!",
                    Cout = 5,
                    ConfirmationDevis = "Cela me convient sauf pour le sourire!",
                    ConfirmationPrestation = "Je l'ai apprécié ce gateau",
                    ConfirmationRetour = "Merci de me retourner le plat!"

                }

            );

            this.SaveChanges();

 


            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=homechef");
        }
    }
}
