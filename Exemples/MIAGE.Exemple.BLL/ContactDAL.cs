using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MIAGE.Exemple.BLL
{
    public class ContactDAL
    {
        private static List<Contact> _contacts = new List<Contact>()
        {
            new Contact()
            {
                Id = 1,
                Nom = "Dupont",
                Prenom = "Jean",
                CodePostal = "37000",
                Sexe = "M",
                Telephone = "123456789",
                Pays = PaysDAL.GetPays(0)
            },
            new Contact()
            {
                Id = 2,
                Nom = "Durant",
                Prenom = "Claude",
                CodePostal = "45000",
                Sexe = "F",
                Telephone = "987654321",
                Pays = PaysDAL.GetPays(1)
            }
        };

        public static IEnumerable<Contact> GetAllContacts()
        {
            return _contacts.ToArray();
        }
        public static IEnumerable<Contact> GetAllContacts(string sortExpression, string sortDirection)
        {
            if (string.IsNullOrEmpty(sortExpression))
                return GetAllContacts();

            ParameterExpression parameter = Expression.Parameter(typeof(Contact), "contact");
            MemberExpression propertyRead = null;
            foreach (string property in sortExpression.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (propertyRead == null)
                    propertyRead = Expression.Property(parameter, property);
                else
                    propertyRead = Expression.Property(propertyRead, property);
            }
            Expression<Func<Contact, object>> expression = Expression.Lambda<Func<Contact, object>>(propertyRead, parameter);

            if (sortDirection == "ASC")
                return _contacts.OrderBy(expression.Compile()).ToArray();
            else
                return _contacts.OrderByDescending(expression.Compile()).ToArray();
        }

        public static Contact GetContact(long id)
        {
            return _contacts.FirstOrDefault(x => x.Id == id);
        }

        public static long AddContact(Contact contact)
        {
            contact.Id = _contacts.Max(x => x.Id) + 1;
            _contacts.Add(contact);
            return contact.Id;
        }
        public static long UpdateContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException("contact");

            Contact knownContact = GetContact(contact.Id);
            if (knownContact == null)
                throw new InvalidOperationException("Le contact n'est pas connu.");

            knownContact.Nom = contact.Nom;
            knownContact.Prenom = contact.Prenom;
            knownContact.Sexe = contact.Sexe;
            if (contact.Pays == null)
                knownContact.Pays = null;
            else
                knownContact.Pays = PaysDAL.GetPays(contact.Pays.Id);
            knownContact.CodePostal = contact.CodePostal;
            knownContact.Telephone = contact.Telephone;

            return contact.Id;
        }

        public static void Delete(long id)
        {
            Contact knownContact = GetContact(id);
            if (knownContact == null)
                throw new InvalidOperationException("Le contact n'est pas connu.");

            _contacts.Remove(knownContact);
        }
    }
}
