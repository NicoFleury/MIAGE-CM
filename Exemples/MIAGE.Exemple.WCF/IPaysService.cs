using MIAGE.Exemple.WCF.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MIAGE.Exemple.WCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IPaysService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IPaysService
    {
        [OperationContract]
        List<Pays> GetAllPAys();

        [OperationContract]
        Pays GetPaysById(long id);
    }
}
