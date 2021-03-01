using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_compte_et_client
{
    class Compte
    {
        private int rib;
        private double solde;
        private Client titulaire;
        private static int cmpt = 0;

      
        public Compte(Client titulaire , double solde)
        {
            cmpt++;
            this.rib = cmpt;
            this.solde = solde;
            this.titulaire = titulaire;
        }

        public void Crediter(double somme)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if(somme >0)
            {
                 this.solde += somme;
                 Console.WriteLine("Vous avez ajouté une somme de " + somme + " MAD à votre compte ", Console.ForegroundColor);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("La somme doit être positive" , Console.ForegroundColor);
            }
           
        }


        public void Debiter(double somme)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if (this.solde >= somme)
            {
                this.solde -= somme;
                Console.WriteLine("Vous avez retiré une somme de " + somme + " MAD ", Console.ForegroundColor);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Solde insuffisant" , Console.ForegroundColor);
            }
                
        }

       
        public void Afficher()
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Numéro du Compte : \t " + this.rib);
            Console.WriteLine("Solde du compte : \t" + this.solde + " MAD");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Titulaire du compte : \t ");
            Console.ForegroundColor = ConsoleColor.Gray;

            titulaire.Afficher();     
        }

      
    }
}
