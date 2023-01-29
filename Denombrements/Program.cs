using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                switch(choix)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                    // le nombre d'éléments à gérer
                    Console.Write("nombre total d'éléments à gérer = ");
                    // saisir le nombre
                    int nombreElt = int.Parse(Console.ReadLine());
                    // calcul de r                                       
                    long r = 1;
                    for (int k = 1; k <= nombreElt; k++)
                        r *= k;
                    Console.WriteLine(nombreElt + "! = " + r);

                        break;

                    case 2:
                        // le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        // saisir le nombre
                        int nombreEltTotal = int.Parse(Console.ReadLine());
                        // le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        // saisir le nombre
                        nombreElt = int.Parse(Console.ReadLine()); 
                        // calcul de r
                        r = 1;
                        for (int k = (nombreElt - nombreEltTotal + 1); k <= nombreElt; k++)
                            r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + nombreElt + "/" + nombreEltTotal + ") = " + r);

                        break;

                    default:
                      // le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        // saisir le nombre
                        nombreElt = int.Parse(Console.ReadLine());
                        // le sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        // saisir le nombre
                        int nombreEnsemble = int.Parse(Console.ReadLine()); 
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (nombreElt - nombreEnsemble + 1); k <= nombreElt; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= nombreEnsemble; k++)
                            r2 *= k;
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + nombreElt + "/" + nombreEnsemble + ") = " + (r1 / r2));
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
