using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using Projet2Homechef.Models.Prestation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace Projet2Homechef.Controllers
{
    
    public class ServiceController : Controller
    {
        private IWebHostEnvironment _webEnv;
        Dal dal = new Dal();
        public ServiceController(IWebHostEnvironment environment)
        {
            _webEnv = environment;
            
        }
        public ActionResult CreerService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreerService(Service service)
        {
            /*string uploads = Path.Combine(_webEnv.WebRootPath, "images");
            string filePath = Path.Combine(uploads, service.Image.FileName);
            using (Stream fileStream = new FileStream(filePath, FileMode.Create))
            {
                service.Image.CopyTo(fileStream);
            }
            
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int IdChef =Convert.ToInt32(userId);*/
            //dal.CreerService(service.Titre, service.Description, "/images/"+service.Image.FileName, IdChef);
            return Redirect("/home");
        }

        public ActionResult Index()
        {
            List<Service> listeDesServices = dal.ObtientTousLesServices().Where(v => v.Valider == 1).ToList();
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            return View(listeDesServices);
        }

        public ActionResult CatalogueHomechef()
        {          
            List<Service> listeDesServices = dal.ObtientTousLesServices().Where(v => v.Valider == 1).ToList();
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            return View(listeDesServices);
        }

        public ActionResult CatalogueHomechef2()
        {
            List<Service> listeDesServices = dal.ObtientTousLesServices().Where(v => v.Valider == 1).ToList();
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            return View(listeDesServices);
        }

        public ActionResult CatalogueHomechef3()
        {
            List<Service> listeDesServices = dal.ObtientTousLesServices().Where(v => v.Valider == 1).ToList();
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            return View(listeDesServices);
        }

        public ActionResult MonCatalogue()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int IdChef = Convert.ToInt32(userId);
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            List<Service> listeDesServices = dal.ObtientTousLesServices().Where(i => i.Chef.Id == IdChef).ToList();           

            return View(listeDesServices);
        }

        public ActionResult MonCatalogue2()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int IdChef = Convert.ToInt32(userId);
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois();
            List<Service> listeDesServices = dal.ObtientTousLesServices().Where(i => i.Chef.Id == IdChef).ToList();

            return View(listeDesServices);
        }

        //Vers Prestation
        public ActionResult Demander(int idService)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            int idVillageois = Convert.ToInt32(userId);
            dal.AjouterPrestation(idService, idVillageois);
            int idCommande = dal.ObtientIdCommande(0);
            return Redirect("/Prestation/DetailPrestationVillageois/"+idCommande);
        }

    }
}
