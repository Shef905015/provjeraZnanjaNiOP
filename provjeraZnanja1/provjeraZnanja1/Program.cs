using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string rijec;

            Console.WriteLine("Unesite neki niz znakova: ");
            rijec = Convert.ToString(Console.ReadLine());

            Console.WriteLine(rijec.Replace(" ", "_"));


            Console.ReadKey();

        }
    }
}
