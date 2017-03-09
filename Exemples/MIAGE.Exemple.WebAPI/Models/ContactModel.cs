using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIAGE.Exemple.WebAPI.Models
{
    public class ContactModel
    {
        public long Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Sexe { get; set; }

        public long Pays { get; set; }

        public string CodePostal { get; set; }

        public string Telephone { get; set; }
    }
}