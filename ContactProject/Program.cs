using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionnaireContacts gestionnaire = new GestionnaireContacts();

            int choix;

            do
            {
                Console.WriteLine("\nMenu :");
                Console.WriteLine("1. Ajouter un contact");
                Console.WriteLine("2. Afficher les contacts");
                Console.WriteLine("3. Modifier un contact");
                Console.WriteLine("4. Supprimer un contact");
                Console.WriteLine("5. Quitter");
                Console.Write("Entrez votre choix (1-5) : ");

                if (int.TryParse(Console.ReadLine(), out choix))
                {
                    switch (choix)
                    {
                        case 1:
                            Console.Write("Nom : ");
                            string nom = Console.ReadLine();

                            Console.Write("Numéro de téléphone : ");
                            string numeroTelephone = Console.ReadLine();

                            Console.Write("Email : ");
                            string email = Console.ReadLine();

                            gestionnaire.AjouterContact(new Contact { Nom = nom, NumeroTelephone = numeroTelephone, Email = email });
                            break;

                        case 2:
                            gestionnaire.AfficherContacts();
                            break;

                        case 3:
                            Console.Write("ID du contact à modifier : ");
                            int idModifier;
                            if (int.TryParse(Console.ReadLine(), out idModifier))
                            {
                                Console.Write("Nouveau nom : ");
                                string nouveauNom = Console.ReadLine();

                                Console.Write("Nouveau numéro de téléphone : ");
                                string nouveauNumero = Console.ReadLine();

                                Console.Write("Nouvel email : ");
                                string nouvelEmail = Console.ReadLine();

                                gestionnaire.ModifierContact(idModifier, nouveauNom, nouveauNumero, nouvelEmail);
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer un ID valide.");
                            }
                            break;

                        case 4:
                            Console.Write("ID du contact à supprimer : ");
                            int idSupprimer;
                            if (int.TryParse(Console.ReadLine(), out idSupprimer))
                            {
                                gestionnaire.SupprimerContact(idSupprimer);
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer un ID valide.");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Fin du programme.");
                            break;

                        default:
                            Console.WriteLine("Choix non valide. Veuillez réessayer.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre valide.");
                }

            } while (choix != 5);
        }
    }
}
