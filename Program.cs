using System;

namespace nombre_magique
{
    class Program
    {
        //FONCTION DEMANDEZ NOMBRE

        static int demanderNombre(int min, int max)
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

            demanderNombre( nombre_min, nombre_max);

        }
    }
}
