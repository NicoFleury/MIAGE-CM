using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIAGE.Exemple.Client
{
    public static class Utils
    {
        private static IEnumerable<PaysService.Pays> pays;
        public static IEnumerable<PaysService.Pays> Pays
        {
            get
            {
                if (pays == null)
                {
                    PaysService.PaysServiceClient client = new PaysService.PaysServiceClient();
                    pays = client.GetAllPAys();
                    client.Close();
                }

                return pays;
            }
        }
    }
}