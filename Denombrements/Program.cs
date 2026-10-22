using System;
namespace Denombrements
{
    class Program
    {



        static long Factorielle2(int n, int t)
        {
            long r = 1;
            for (int k = n; k <= t; k++)

                r *= k;

            return r ;
        }

                   /// <summary>
                   /// Saisit un nombre entier à partir d'un message d'invite
                   /// </summary>
                   /// <param name="message1">recoit le message d'invite</param>
                   /// <returns>la valeur saisie</returns>
        static int Saisienombres(string message1)
        {

            Console.Write(message1); // le nombre d'éléments à gérer
             int t = int.Parse(Console.ReadLine()); // saisir le nombre

            return t;
        }
      
        /// <summary>
        /// permet de calculer les permutations, arrangements et combinaisons et daficher les résultats
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) 
                {
                    Environment.Exit(0); 
                }

                if (c == 1)
                {
                    int n = Saisienombres("nombre d'éléments à gérer = "); // saisie le nombre d'éléments à gérer
                    long r = 1;
                    r = Factorielle2(1, n); // calcul de r
                    Console.WriteLine(n + "! = " + r);
                }
                else 
                {
                    if (c == 2)
                    {
                        int t = Saisienombres("nombre total d'éléments à gérer = "); // saisie du  nombre d'éléments à gérer
                        int n = Saisienombres("nombre d'éléments dans le sous ensemble = "); // saisie du nombre d'éléments dans le sous ensemble
                        long r = 1; // calcul de r
                        r = Factorielle2(t - n + 1, t);
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);// affichage du résultat
                    }
                    else
                    {
                        int t = Saisienombres("nombre total d'éléments à gérer = "); 
                        int n = Saisienombres("nombre d'éléments dans le sous ensemble = ");                    
                        long r1 = 1; // calcul de r1
                        r1 = Factorielle2(t - n + 1, t);

                        long r2 = 1; // calcul de r2
                        r2 = Factorielle2(1, n);

                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));//aficahe du résultat
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
