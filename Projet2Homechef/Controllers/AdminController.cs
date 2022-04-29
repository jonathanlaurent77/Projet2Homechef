using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using Projet2Homechef.Models.Prestation;
using Projet2Homechef.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Projet2Homechef.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            Dal dal = new Dal();
           
            AdminServicesVillageois asv = new AdminServicesVillageois();
            asv.ListeDesVillageois = dal.ObtientTousLesVillageois().ToList();
            asv.ListeDesServices = dal.ObtientTousLesServices().ToList();
            return View(asv);
        }

        public IActionResult AdminVillageois()
        {
            Dal dal = new Dal();
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois().ToList();
            return View(listeDesVillageois);
        }
        public IActionResult AdminServices()
        {
            Dal dal = new Dal();
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois().ToList();
            List<Service> listeDesServices = dal.ObtientTousLesServices().ToList();
            return View(listeDesServices);
        }
        public IActionResult DeleteVillageois(int id)
        {
            Dal dal = new Dal();
            List<Service> listeDesServices = dal.ObtientTousLesServices().ToList();
            Boolean detientUnService = false;

            foreach (Service s in listeDesServices)
            {
                if (s.Chef.Id == id)
                {
                    detientUnService = true;
                }

            }

            if (detientUnService)
            {
                dal.SupprimerVillageois(id);
                return RedirectToAction("AdminVillageois");
            }

            else
            {
                ViewData["message"] = "Vous ne pouvez pas supprimer un Villageois proposant des services : vous devez d'abord supprimer les services";

                return View("Error");
            }


        }

        public IActionResult DeleteService(int id)
        {
            Dal dal = new Dal();
            dal.SupprimerService(id);
            return RedirectToAction("AdminServices");

        }
            public IActionResult ModifierVillageois(int id)
        {
            if (id != 0)
            {
                using (Dal dal = new Dal())
                {
                    Villageois villageois = dal.ObtientTousLesVillageois().Where(r => r.Id == id).FirstOrDefault();
                    if (villageois == null)
                    {
                        ViewData["message"] = "Ce villageois n'est pas dans la base";
                        return View("Error");
                    }
                    return View(villageois);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult ModifierVillageois(int id, string UserName, string Password, string Nom, string Prenom, DateTime DateDeNaissance, string email, string tel)
        {

            if (id != 0)
            {
                using (Dal dal = new Dal())
                {
                    dal.ModifierVillageois(id, UserName, Password, Nom, Prenom, DateDeNaissance, email, tel);
                    return RedirectToAction("ModifierVillageois", new { @id = id });
                }
            }
            else
            {
                return View("Error");
            }
        }
        public IActionResult ModifierService(int id)
        {
            if (id != 0)
            {
                using (Dal dal = new Dal())
                {
                    Service service = dal.ObtientTousLesServices().Where(r => r.Id == id).FirstOrDefault();
                    if (service == null)
                    {
                        ViewData["message"] = "Ce service n'est pas dans la base";
                        return View("Error");
                    }
                    return View(service);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult ModifierService(int id, string Titre, string Description, int ChefId)
        {

            if (id != 0)
            {
                using (Dal dal = new Dal())
                {
                    dal.ModifierService(id, Titre, Description, ChefId);
                    return RedirectToAction("ModifierService", new { @id = id });
                }
            }
            else
            {
                ViewData["message"] = "ce service n'est pas dans la base";
                return View("Error");
            }
        }
    }
}