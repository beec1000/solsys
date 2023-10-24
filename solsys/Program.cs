using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace solsys
{
    class Program
    {
        static void Main(string[] args)
        {
            var bolygoAdatok = new List<Solsys>();

            using var sr = new StreamReader(@"..\..\..\src\solsys.txt");
            while (!sr.EndOfStream)
            {
                bolygoAdatok.Add(new Solsys(sr.ReadLine()));
            }

            Console.WriteLine("3.1 feladat");
            Console.WriteLine($"{bolygoAdatok.Count} bolygó van a naprendszerben");

            Console.WriteLine("3.2 feladat");
            var holdAtlag = bolygoAdatok.Average(d => d.HoldjainakSzama);
            Console.WriteLine($"A naprendszerben egy bolgyónak átlagosan {holdAtlag} holdja van");

            Console.WriteLine("3.3 feladat");
            var legnagyobbTerfogatu = bolygoAdatok.OrderByDescending(d => d.TerfogataAFoldhozKepest).First();
            Console.WriteLine($"A legnagyobb térfogatú bolygó a {legnagyobbTerfogatu.BolygoNeve}");

            Console.WriteLine("3.4 feladat");
            Console.WriteLine("Írd be a keresett bolygó nevét:");
            var bolygoKereso = Console.ReadLine();
            foreach (var i in bolygoAdatok)
            {
                if (i.BolygoNeve == bolygoKereso)
                {
                    Console.WriteLine("Van ilyen nevű bolygó a naprendszerünkben!");
                }
                else
                {
                    Console.WriteLine("Sajnos nincs ilyen nevű bolygó a naprendszerünkben!");
                }
            }
            Console.WriteLine("3.5 feladat");
            Console.WriteLine("Írj be egy egész számot: ");
            var egeszSzam = int.Parse(Console.ReadLine());
            var tobbHolduBolygok = bolygoAdatok.Where(d => d.HoldjainakSzama > egeszSzam);
            Console.WriteLine($"A következő bolygóknak van {egeszSzam}-nál/nél több holdja:");
            foreach (var i in tobbHolduBolygok)
            {
                Console.WriteLine(i.BolygoNeve);
            }
            
        }
    }
}
