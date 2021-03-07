using System;

namespace nombre_magique
{
    class Program
    {
        //FONCTION DEMANDEZ NOMBRE

        static int demanderNombre(int min, int max, int magique)
        {
            
           int chiffre = 0;
           int nbVies = 4;

            while ((nbVies > 0))
            {
                Console.WriteLine("");
                Console.WriteLine("Vie restantes : " + nbVies);
                Console.Write("Veuillez rentrer un nombre entre " + min + " et " + max + " : " );
                string reponse = Console.ReadLine();
            
                try
                {
                    chiffre = int.Parse(reponse);
                    Console.WriteLine("Vous avez rentré le nombre  " + chiffre);

                    if (chiffre == magique)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Bravo vous avez gagné ! Le nombre magique était " + magique);
                        nbVies = 0;
                    }

                    else if (chiffre > max)
                    {
                        Console.WriteLine("Erreur vous devez rentrer un nombre de 1 à 10");
                    }

                    else if (magique < chiffre)
	                {
                        Console.WriteLine("Trop grand");
                        chiffre = 0; // Force à revenir à zéro à chaque tour pour recommencer la boucle
                        nbVies--;
	                }

                    else if (magique > chiffre)
	                {
                        Console.WriteLine("trop petit");
                        chiffre = 0; // Force à revenir à zéro à chaque tour pour recommencer la boucle
                        nbVies--;
                    }

                }

                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Erreur vous devez rentrer un nombre valide");  
                }

            }

            // Au dernier tour nbVies sera égale à zéro, et vue que chiffre se réinitialise à chaque tours donc ils seront forcément égaux.
            if (nbVies == chiffre)
            {
                Console.WriteLine("");
                Console.WriteLine("Vous avez perdu le nombre magique était : " + magique);
            }

            return chiffre;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            const int nombre_min = 1;
            const int nombre_max = 10;
            int nombre_magique = rand.Next(nombre_min, nombre_max+1);

            demanderNombre( nombre_min, nombre_max, nombre_magique);

        }
    }
}
