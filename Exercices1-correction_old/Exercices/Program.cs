using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresPremier
{
	class Program
	{
		static void Main(string[] args)
		{
            int n;
			Console.Write("Combien de nombres premiers : "); // Ecrit à la suite de ce qui est déjà écrit dans 
                                                             // la console par opposition à WriteLine ou on passe à la ligne.
			n = Int32.Parse(System.Console.ReadLine()); // On récupère une variable de type string au clavier et
                                                        // on la convertit en entier pour la stocker dans n
            CalculerNbPremier(n);
            Console.ReadKey();
		}

        static void CalculerNbPremier(int nbPremier)
        {
            int divis, nbr, cptPremier = 0; // compt initiallisé à 0.
            bool estPremier;
            Console.WriteLine(2); // On affiche le premier nombre premier cad 2.
            nbr = 3;
            while (cptPremier < nbPremier - 1)
            {
                divis = 2;
                estPremier = true;
                do // On commence un do ... while (jusqu'à).
                {
                    if (nbr % divis == 0) estPremier = false;
                    else divis = divis + 1;
                }
                while ((divis <= nbr / 2) && (estPremier == true)); // On finit en réalité le do (jusqu'à).
                if (estPremier)
                {
                    cptPremier++;
                    System.Console.WriteLine(nbr);
                }
                nbr++;
            }
        }
	}
}
