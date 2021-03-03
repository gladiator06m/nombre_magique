using System;

namespace nombre_magique
{
    class Program
    {
        //FONCTION DEMANDEZ NOMBRE

        static int demanderNombre()
        {
            
           int chiffre = 0;
         

            while (chiffre <= 0)
            {
                Console.Write("Veuillez rentrer un nombre entre 1 et 10 : ");
                string reponse = Console.ReadLine();

            
                try
                {
                    chiffre = int.Parse(reponse);
                    Console.WriteLine("Vous avez rentré le nombre  " + chiffre);
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
            demanderNombre();

        }
    }
}
