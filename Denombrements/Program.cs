using System;

namespace Denombrements
{
    class Program
    {
        static int saisie(string message)
        {
            int nombre = 0;
            bool correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write(message);
                    nombre = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : entrez un nombre entier");
                }
            }
            return nombre;
        }

        static int saisieBornee(string message, int min, int max)
        {
            int nombre = saisie(message);
            while (nombre < min || nombre > max)
            {
                Console.WriteLine("Entrez un nombre entre " + min + " et " + max);
                nombre = saisie(message);
            }
            return nombre;
        }
        static void Main(string[] args)
        {
            int c = -1;
            string message1 = "nombre total d'éléments à gérer = ";
            string message2 = "nombre d'éléments dans le sous ensemble = ";
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                c = saisieBornee("Choix :                            ", 0, 3);

                if (c == 1)
                {
                    int n = saisie(message1);
                    // calcul de r
                    int r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }
                if (c == 2)
                {
                    int t = saisie(message1);
                    int n = saisie(message2);
                    // calcul de r
                    int r = 1;
                    for (int k = (t - n + 1); k <= t; k++)
                        r *= k;
                    Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                }
                if (c == 3)
                {
                    int t = saisie(message1);
                    int n = saisie(message2);
                    // calcul de r1
                    int r1 = 1;
                    for (int k = (t - n + 1); k <= t; k++)
                        r1 *= k;
                    // calcul de r2
                    int r2 = 1;
                    for (int k = 1; k <= n; k++)
                        r2 *= k;
                    // calcul de r3
                    Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                }
            }
        }
    }
}
