using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = { };
            string[] s2 = { };
            int n1;
            int n2;

            Console.WriteLine("Koliko rijeci zelite u prvom stringu?");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Koliko rijeci zelite u drugom stringu?");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite riječi u prvi string: ");
            for(int i = 0; i < n1; i++)
            {

                s1[i] = Convert.ToString(Console.ReadLine());

            }
            Console.WriteLine("Unesite riječi u drugi string: ");
            for (int i = 0; i < n2; i++)
            {

                s2[i] = Convert.ToString(Console.ReadLine());

            }

            Array.Sort(s1, s2);

            Console.ReadKey();
        }
    }
}
