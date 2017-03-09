using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MIAGE.Exemple.WCF.DataContract;

namespace MIAGE.Exemple.WCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ContactService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ContactService.svc ou ContactService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ContactService : IContactService
    {
        public List<Contact> GetAllContacts()
        {
            var entities = BLL.ContactDAL.GetAllContacts();
            return AutoMapper.Mapper.Map<IEnumerable<Contact>>(entities).ToList();
        }

        public Contact GetContactById(long id)
        {
            var entity = BLL.ContactDAL.GetContact(id);
            return AutoMapper.Mapper.Map<Contact>(entity);
        }

        public long SaveContact(Contact contact)
        {
            var entity = AutoMapper.Mapper.Map<BLL.Contact>(contact);
            entity.Pays = BLL.PaysDAL.GetPays(contact.PaysId);

            if (entity.Id == 0)
            {
                return BLL.ContactDAL.AddContact(entity);
            }

            return BLL.ContactDAL.UpdateContact(entity);
        }
    }
}
