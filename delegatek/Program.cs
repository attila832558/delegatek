using System;
using static System.Console;

namespace delegatek
{
    class Program
    {
        /*delegate*/
        internal delegate double matekozas(double szam);
        public static double negyzet(double szam)
        {
            return szam * szam;
        }
        public static double negyzetgyok(double szam)
        {
            return Math.Sqrt(szam);
        }
        public static double logaritmus(double szam)
        {
            return Math.Log10(szam);
        }
       
        public static double Szamol(double szam, matekozas matek)
        {
            return matek(szam);
        }
        /*main*/
        static void Main(string[] args)
        {
            matekozas matek = negyzet;
            WriteLine(Szamol(5, matek));
            matek = negyzetgyok;
            WriteLine(Szamol(25, matek));
            matek = logaritmus;
            WriteLine(Szamol(100, matek));
        }
        

    }
}