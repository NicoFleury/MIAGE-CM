using MIAGE.Exemple.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MIAGE.Exemple.WebAPI.Controllers
{
    public class ContactController : ApiController
    {
        // GET: api/Contact
        public IEnumerable<ContactModel> Get()
        {
            return BLL.ContactDAL.GetAllContacts().Select(x => new ContactModel()
            {
                Id = x.Id,
                Nom = x.Nom,
                Prenom = x.Prenom,
                CodePostal = x.CodePostal,
                Pays = x.Pays.Id,
                Sexe = x.Sexe,
                Telephone = x.Telephone,
            });
        }

        // GET: api/Contact/5
        public ContactModel Get(long id)
        {
            var entity = BLL.ContactDAL.GetContact(id);
            return new ContactModel()
            {
                Id = entity.Id,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                CodePostal = entity.CodePostal,
                Pays = entity.Pays.Id,
                Sexe = entity.Sexe,
                Telephone = entity.Telephone,
            };
        }

        // POST: api/Contact
        public void Post([FromBody]ContactModel model)
        {
            var contact = new BLL.Contact()
            {
                Id = model.Id,
                Nom = model.Nom,
                Prenom = model.Prenom,
                CodePostal = model.CodePostal,
                Pays = BLL.PaysDAL.GetPays(model.Pays),
                Sexe = model.Sexe,
                Telephone = model.Telephone,
            };
            BLL.ContactDAL.AddContact(contact);
        }

        // PUT: api/Contact/5
        public void Put([FromBody]ContactModel model)
        {
            var contact = new BLL.Contact()
            {
                Id = model.Id,
                Nom = model.Nom,
                Prenom = model.Prenom,
                CodePostal = model.CodePostal,
                Pays = BLL.PaysDAL.GetPays(model.Pays),
                Sexe = model.Sexe,
                Telephone = model.Telephone,
            };
            BLL.ContactDAL.UpdateContact(contact);
        }

        // DELETE: api/Contact/5
        public void Delete(int id)
        {
            BLL.ContactDAL.Delete(id);
        }
    }
}
