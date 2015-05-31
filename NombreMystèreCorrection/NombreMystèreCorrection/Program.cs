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
            int nombrealeatoireconverti = Convert.ToInt32(nombrealeatoire);
            while (randome != nombrealeatoireconverti)
            {
                if (nombrealeatoireconverti < randome)
                {
                    Console.WriteLine("votre nombre est trop petit");
                    nombrealeatoire = Console.ReadLine();
                    nombrealeatoireconverti = Convert.ToInt32(nombrealeatoire);
                }
                else if (nombrealeatoireconverti > randome)
                {
                    Console.WriteLine("votre nombre est trop grand ");
                    nombrealeatoire = Console.ReadLine();
                    nombrealeatoireconverti = Convert.ToInt32(nombrealeatoire);
                }
            }
            if (randome == nombrealeatoireconverti)
            {                
                Console.WriteLine("Bravo vous avec trouver le nombre");
                Console.ReadKey();
            }

        }
    }
}
