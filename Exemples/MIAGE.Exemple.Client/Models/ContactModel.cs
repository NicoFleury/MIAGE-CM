using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIAGE.Exemple.Client.Models
{
    public class ContactModel
    {
        [Key]
        public long Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Sexe { get; set; } = "M";

        public long PaysId { get; set; }

        [Display(Name = "Pays")]
        public string PaysLibelle { get; set; }

        [Display(Name = "Code Postal")]
        public string CodePostal { get; set; }

        public string Telephone { get; set; }
    }
}