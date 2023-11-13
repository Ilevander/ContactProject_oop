using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactProject
{
    internal class GestionnaireContacts
    {
        private List<Contact> listeContacts;

        public GestionnaireContacts()
        {
            listeContacts = new List<Contact>();
        }

        public void AjouterContact(Contact contact)
        {
            contact.ID = listeContacts.Count + 1;
            listeContacts.Add(contact);
        }

        public void ModifierContact(int id, string nom, string numeroTelephone, string email)
        {
            Contact contact = listeContacts.Find(c => c.ID == id);
            if (contact != null)
            {
                contact.Nom = nom;
                contact.NumeroTelephone = numeroTelephone;
                contact.Email = email;
                Console.WriteLine("Contact modifié avec succès.");
            }
            else
            {
                Console.WriteLine("Contact non trouvé.");
            }
        }

        public void AfficherContacts()
        {
            Console.WriteLine("\nListe des contacts :");
            foreach (var contact in listeContacts)
            {
                Console.WriteLine($"ID: {contact.ID}, Nom: {contact.Nom}, Téléphone: {contact.NumeroTelephone}, Email: {contact.Email}");
            }
        }

        public void SupprimerContact(int id)
        {
            Contact contact = listeContacts.Find(c => c.ID == id);
            if (contact != null)
            {
                listeContacts.Remove(contact);
                Console.WriteLine("Contact supprimé avec succès.");
            }
            else
            {
                Console.WriteLine("Contact non trouvé.");
            }
        }
    }
}
