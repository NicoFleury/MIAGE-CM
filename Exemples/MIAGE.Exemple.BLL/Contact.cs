namespace MIAGE.Exemple.BLL
{
    public class Contact
    {
        public long Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Sexe { get; set; }

        public Pays Pays { get; set; }

        public string CodePostal { get; set; }

        public string Telephone { get; set; }
    }
}
