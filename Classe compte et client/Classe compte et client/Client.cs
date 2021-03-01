using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_compte_et_client
{
    class Client
    {
        private readonly string nom;
        private readonly string prenom;
        private readonly string adresse;

        public Client(string nom, string prenom, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }

        
        public void Afficher()
        {
            Console.WriteLine("Le nom du client : \t " + this.nom);
            Console.WriteLine("Le prénom du client : \t " + this.prenom);
            Console.WriteLine("Votre adresse : \t " + this.adresse);
        }
    }
    
}
