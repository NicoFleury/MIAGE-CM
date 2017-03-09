using System.Collections.Generic;
using System.Linq;

namespace MIAGE.Exemple.BLL
{
    public class PaysDAL
    {
        private static List<Pays> _pays = new List<Pays>()
        {
            new Pays() { Id = 0, Nom = "France", CodePostalPattern = @"^\d{5}$" },
            new Pays() { Id = 1, Nom = "Etats-Unis", CodePostalPattern = @"^\d{5}(?:[-\s]\d{4})?$" }
        };

        public static IEnumerable<Pays> GetAllPays()
        {
            return _pays.ToArray();
        }
        public static Pays GetPays(long id)
        {
            return _pays.FirstOrDefault(pays => pays.Id == id);
        }
    }
}
