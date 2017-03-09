using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MIAGE.Exemple.WCF.DataContract;

namespace MIAGE.Exemple.WCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PaysService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez PaysService.svc ou PaysService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class PaysService : IPaysService
    {
        public List<Pays> GetAllPAys()
        {
            var entities = BLL.PaysDAL.GetAllPays();
            return AutoMapper.Mapper.Map<IEnumerable<Pays>>(entities).ToList();
        }

        public Pays GetPaysById(long id)
        {
            var entity = BLL.PaysDAL.GetPays(id);
            if (entity == null)
                throw new ArgumentNullException("Le pays demandé n'existe pas");

            return AutoMapper.Mapper.Map<Pays>(entity);
        }
    }
}
