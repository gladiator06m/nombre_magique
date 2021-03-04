using System;

namespace nombre_magique
{
    class Program
    {
        //FONCTION DEMANDEZ NOMBRE

        static int demanderNombre(int min, int max, int magique)
        {
            
           int chiffre = 0;
         

            while ((chiffre < min) || (chiffre > max))
            {
                Console.Write("Veuillez rentrer un nombre entre " + min + " et " + max + " : " );
                string reponse = Console.ReadLine();
            
                try
                {
                    chiffre = int.Parse(reponse);
                    Console.WriteLine("Vous avez rentré le nombre  " + chiffre);

                    if (chiffre > max)
                    {
                        Console.WriteLine("Erreur vous devez rentrer un nombre de 1 à 10");
                    }

                    else if (magique < chiffre)
	                {
                        Console.WriteLine("Trop grand");
                        chiffre = 0;
	                }

                    else if (magique > chiffre)
	                {
                        Console.WriteLine("trop petit");
                        chiffre = 0;
	                }

                    else
	                {
                        Console.WriteLine("BRAVO VOUS AVEZ GAGNÉ, LE NOMBRE MAGIQUE ÉTAIT " + magique);
	                }
                }

                catch
                {
                    Console.WriteLine("Erreur vous devez rentrer un nombre valide");  
                }

            }
            return chiffre;
        }

        static void Main(string[] args)
        {

            const int nombre_min = 1;
            const int nombre_max = 10;
            const int nombre_magique = 5;

            demanderNombre( nombre_min, nombre_max, nombre_magique);

        }
    }
}
