using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet2Homechef.Models.Prestation
{
    public class Service
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public int Valider { get; set; }
        public Villageois Chef { get; set; }
        public string ImagePath { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
