using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MIAGE.Exemple.WCF.DataContract
{
    [DataContract]
    public class Pays
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string  Nom { get; set; }
    }
}