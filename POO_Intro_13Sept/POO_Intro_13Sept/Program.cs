using POO_Intro_13Sept;
using System;

namespace POO_Intro 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans notre refuge");
            Console.WriteLine();

            Chien[] mesChiens = new Chien[3];
            mesChiens[0] = new Chien("Rox", "Canniche", 4);
            mesChiens[1] = new Chien("Rox", "Canniche", 4);
            mesChiens[2] = new Chien("Rox", "Canniche", 4);
            float moyenneChien = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Quel est le nom de votre chien ?");
                mesChiens[i].Nom = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Quel est la race de votre chien ?");
                mesChiens[i].Race = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Quel est l'age de votre chien ?");
                mesChiens[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine();

                mesChiens[i] = new Chien(mesChiens[i].Nom, mesChiens[i].Race, mesChiens[i].Age);
                Console.WriteLine(mesChiens[i].afficheCaracteristique());

                moyenneChien = moyenneChien + mesChiens[i].Age;
            }
            Console.WriteLine();
            Console.WriteLine("la moyenne d'age est de " + moyenneChien/3);

            mesChiens[0].Age += 10;
            mesChiens[1].Age += 10;
            mesChiens[2].Age += 10;

            Console.WriteLine();
            Console.WriteLine(mesChiens[1].Age);    

        }
    }
}