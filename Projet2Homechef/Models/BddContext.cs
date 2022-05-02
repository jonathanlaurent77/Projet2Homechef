using Projet2Homechef.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet2Homechef.Models.Prestation;
using Microsoft.Extensions.Configuration;

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
                    UserName = "111",
                    Password = "azerty",
                    Nom = "Bucharati",
                    Prenom = "Luigi",
                    DateDeNaissance = new DateTime(1990, 03, 02),
                    Email = "aa@hotmail.com",
                    Tel = "0123456789",
                    Role = "Villageois",
                    Valider = 0
                },
              new Villageois
              {
                  Id = 2,
                  UserName = "333",
                  Password = "azerty",
                  Nom = "Gloup",
                  Prenom = "Luigi",
                  DateDeNaissance = new DateTime(1990, 03, 02),
                  Email = "aa@hotmail.com",
                  Tel = "0123456789",
                  Role = "Villageois",
                  Valider = 0

              },

                new Villageois
                {
                    Id = 3,
                    UserName = "444",
                    Password = "azerty",
                    Nom = "Fra ncois",
                    Prenom = "Luigi",
                    DateDeNaissance = new DateTime(1990, 03, 02),
                    Email = "aa@hotmail.com",
                    Tel = "0123456789",
                    Role = "Villageois",
                    Valider = 0

                },
                  new Villageois
                  {
                      Id = 4,
                      UserName = "555",
                      Password = "azerty",
                      Nom = "FFF",
                      Prenom = "Luigi",
                      DateDeNaissance = new DateTime(1990, 03, 02),
                      Email = "aa@hotmail.com",
                      Tel = "0123456789",
                      Role = "Villageois",
                      Valider = 0

                  },
                    new Villageois
                    {
                        Id = 5,
                        UserName = "3EE",
                        Password = "azerty",
                        Nom = "prrr",
                        Prenom = "Luigi",
                        DateDeNaissance = new DateTime(1990, 03, 02),
                        Email = "aa@hotmail.com",
                        Tel = "0123456789",
                        Role = "Villageois",
                        Valider = 0

                    },
                      new Villageois
                      {
                          Id = 6,
                          UserName = "4gg4",
                          Password = "azerty",
                          Nom = "FFF",
                          Prenom = "Luigi",
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
                    Description = "Faire un gateau au chocolat",
                    Valider = 1,
                    Chef = villageoisA,
                    ImagePath = "/images/gateauchoco.jpg"
                },
                new Service
                {
                    Id = 2,
                    Titre = "Machine à pain",
                    Description = "Prêt d'une machine à pain",
                    Valider = 1,
                    Chef = villageoisB,
                    ImagePath = "/images/machinepain.jpg"
                },
                new Service
                {
                    Id = 3,
                    Titre = "Tarte aux cocombre",
                    Description = "C'est bon les tartes aux cocombres",
                    Valider = 0,
                    Chef = villageoisC,
                    ImagePath = "/images/tartecocombre.jpg"
                },
                new Service
                {
                    Id = 4,
                    Titre = "Tondeuse à gazon",
                    Description = "Pour la pelouse et les barbus",
                    Valider = 0,
                    Chef = villageoisD,
                    ImagePath = "/images/tondeuse.jpg"
                },
                new Service
                {
                    Id = 5,
                    Titre = "Tarte aux cocombre",
                    Description = "C'est bon les tartes aux cocombres",
                    Valider = 0,
                    Chef = villageoisA,
                    ImagePath = "/images/tartecocombre.jpg"
                },
                new Service
                {
                    Id = 6,
                    Titre = "Machine à pain",
                    Description = "Prêt d'une machine à pain",
                    Valider = 1,
                    Chef = villageoisB,
                    ImagePath = "/images/machinepain.jpg"
                }
            );

            Service ServiceA = this.Services.Find(1);

            this.Commandes.AddRange(

                new Commande
                {
                    Id = 1,
                    Service = ServiceA,
                    Statut = 1,
                    Villageois = villageoisB,
                    Demande = "1 J'aime les gateau au chocolat, pour mardi prochain",
                    DatePrestation = DateTime.Now
                },

                new Commande
                {
                    Id = 2,
                    Service = ServiceA,
                    Statut = 2,
                    Villageois = villageoisB,
                    Demande = "2 J'aime les gateau au chocolat, pour mardi prochain",
                    DatePrestation = DateTime.Now,
                    Devis = "5 euro et un sourire!",
                    Cout = 5
                },

                new Commande
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
                },

                new Commande
                {
                    Id = 5,
                    Service = ServiceA,
                    Statut = 5,
                    Villageois = villageoisB,
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

            if (System.Diagnostics.Debugger.IsAttached)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=homechef"); ;
            }
            else
            {
                IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
                optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"));
            }


        }
    }
}
