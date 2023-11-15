using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int rezultat = 0;
            Console.Write("Unesite željeni broj Fibonaccijevog niza: ");
            n = Convert.ToInt32(Console.ReadLine());
            List<int> privremeni = new List<int>();

            privremeni.Add(0);
            privremeni.Add(1);
            for (int i = 0; i < n; i++)
            {
                rezultat = rezultat + privremeni[i];
                privremeni.Add(rezultat);

            }


            Console.WriteLine(n + ". broj Fibonaccijevog niza je " + rezultat);



            Console.ReadKey();
        }
    }
}
