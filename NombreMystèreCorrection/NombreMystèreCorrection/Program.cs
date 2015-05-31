using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreMystèreCorrection
{
    class Program
    {
        static void Main(string[] args)
        {

            int randome = new Random().Next(1, 101);

            // l'utilisateur choisis un nombre
            Console.WriteLine("saississez un nombre entre 1 et 100");
            string nombrealeatoire = Console.ReadLine();
            // verifier la validité de la saisie avec Tryparse.
            int nombrealeatoireconverti = Convert.ToInt32(nombrealeatoire);

            while (true)
            {


                if (nombrealeatoireconverti < randome)
                {
                    Console.WriteLine("votre nombre est trop petit");
                }


                else if (nombrealeatoireconverti > randome)
                {
                    Console.WriteLine("votre nombre est trop grand ");

                }


                else if (nombrealeatoireconverti == randome)
                {
                    Console.WriteLine("Bravo vous avec trouver le nombre");

                    // j'avais fait le programme de ce style ci en pythonConsole.WriteLine("Bravo vous avec trouver le nombre");

                    // j'avais fait le programme de ce style ci en python
                }

            }

        }
    }
}
