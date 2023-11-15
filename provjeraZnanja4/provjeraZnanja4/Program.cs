using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string recenica;
            string x;
            string y;
            string z;

            Console.WriteLine("Unesite tri stranice pravokutnog trokuta sa razmakom: ");
            recenica = Console.ReadLine();

            x = recenica.Substring(0, recenica.IndexOf(" "));
            y = recenica.Substring(1, recenica.IndexOf(" ") + 1);
            z = recenica.Substring(recenica.LastIndexOf(" ") + 1);


            int x2 = Convert.ToInt32(x);
            int y2 = Convert.ToInt32(y);
            int z2 = Convert.ToInt32(z);

            if(x2*x2 + y2*y2 == z2 * z2)
            {

                Console.WriteLine(x2 + " " + y2 + " " + z2 + "--> DA");

            }
            else
            {

                Console.WriteLine(x2 + " " + y2 + " " + z2 + "--> NE");

            }


            Console.ReadKey();
        }
    }
}
