using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using Projet2Homechef.Models.Prestation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Projet2Homechef.Controllers
{
    public class PrestationController : Controller
    {
        private IWebHostEnvironment _webEnv;
        Dal dal = new Dal();
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult PrestationChef()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int IdChef = Convert.ToInt32(userId);
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            List<Service> listeDesServices = dal.ObtientTousLesServices();
            List<Commande> listeDesCommandes = dal.ObtientToutesLesCommandes().Where(i => i.Service.Chef.Id == IdChef).ToList();
            
            return View(listeDesCommandes);
        }


        public ActionResult PrestationVillageois()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int IdVillageois = Convert.ToInt32(userId);
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            List<Service> listeDesServices = dal.ObtientTousLesServices();
            List<Commande> listeDesCommandes = dal.ObtientToutesLesCommandes().Where(i => i.Villageois.Id == IdVillageois).ToList();

            return View(listeDesCommandes);
        }

       /* public ActionResult DetailPrestation(int id)
        {
            
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            List<Service> listeDesServices = dal.ObtientTousLesServices();
            List<Commande> listeDesCommandes = dal.ObtientToutesLesCommandes().Where(i => i.Id == id).ToList();

            return View(listeDesCommandes);
        }*/

        public ActionResult DetailPrestationVillageois(int id)
        {

            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            List<Service> listeDesServices = dal.ObtientTousLesServices();
            List<Commande> listeDesCommandes = dal.ObtientToutesLesCommandes().Where(i => i.Id == id).ToList();

            return View(listeDesCommandes);
        }

        public ActionResult DetailPrestationChef(int id)
        {

            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            List<Service> listeDesServices = dal.ObtientTousLesServices();
            List<Commande> listeDesCommandes = dal.ObtientToutesLesCommandes().Where(i => i.Id == id).ToList();

            return View(listeDesCommandes);
        }

        public ActionResult CreerPrestation(int id)
        {

            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            List<Service> listeDesServices = dal.ObtientTousLesServices();
            List<Commande> listeDesCommandes = dal.ObtientToutesLesCommandes().Where(i => i.Id == id).ToList();

            return View(listeDesCommandes);
        }

        [HttpPost]
        public ActionResult AjouterDemande(int Id, String Demande, DateTime DatePrestation)
        {
            
            dal.AjouterDemande(Id, Demande, DatePrestation);

            /*return Redirect("PrestationVillageois");*/
            return Redirect("/home");
        }

        [HttpPost]
        public ActionResult MonterDevis(int Id, String Devis, double Cout)
        {

            dal.MonterDevis(Id, Devis, Cout);
            return Redirect("/home");
            /*return Redirect("PrestationChef");*/
        }

        [HttpPost]
        public ActionResult ConfirmerDevis(int Id, String ConfirmationDevis)
        {

            dal.ConfirmerDevis(Id, ConfirmationDevis);
            return Redirect("/home");
            /*return Redirect("PrestationVillageois");*/
        }

        [HttpPost]
        public ActionResult ConfirmerPrestation(int Id, String ConfirmationPrestation)
        {

            dal.ConfirmationPrestation(Id, ConfirmationPrestation);
            return Redirect("/home");
            /*return Redirect("PrestationVillageois");*/
        }

        [HttpPost]
        public ActionResult ConfirmerRetour(int Id, String ConfirmationRetour)
        {

            dal.ConfirmerRetour(Id, ConfirmationRetour);
            return Redirect("/home");
            /*return Redirect("PrestationChef");*/
        }
    }
}
