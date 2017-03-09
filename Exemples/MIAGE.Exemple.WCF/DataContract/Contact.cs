using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MIAGE.Exemple.WCF.DataContract
{
    [DataContract]
    public class Contact
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Nom { get; set; }

        [DataMember]
        public string Prenom { get; set; }

        [DataMember]
        public string Sexe { get; set; }

        [DataMember]
        public long PaysId { get; set; }

        [DataMember]
        public string CodePostal { get; set; }

        [DataMember]
        public string Telephone { get; set; }
    }
}