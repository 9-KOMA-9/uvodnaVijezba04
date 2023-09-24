using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kraj, vrijednost1, vrijednost2, noviRez;
            vrijednost1 = noviRez = 0;
            vrijednost2 = 1;
            Console.Write("Upisi kraj Fibonaccijevog niza: ");
            kraj = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("");
            Console.WriteLine("Fibonaccijev niz: ");
            for (int i = 1; i <= kraj; ++i)
            {
                if (i == 1)
                {
                    Console.Write(vrijednost1 + " "); 
                }
                if (i == 2)
                {
                    Console.Write(vrijednost2 + " ");
                }
                noviRez = vrijednost1 + vrijednost2; 
                vrijednost1 = vrijednost2; 
                vrijednost2 = noviRez;
                Console.Write(noviRez + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Broj koj je " + kraj + ". po redu u Fibonaccijevom nizu jest: " + noviRez + "."); 


            Console.ReadKey();
        }
    }
}
