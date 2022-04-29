using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2Homechef.Models
{
    
    public class Villageois
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [Column(TypeName="date")]
        public DateTime DateDeNaissance { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Role { get; set; }
        public int Valider { get; set; }

    }
}
