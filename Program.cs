using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikud__Kordused__Massivid_Variaant_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("1 >>> Palindrom\n2 >>> Matrica\n3 >>> stroka");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    funks.Palidrom();
                }
                if (choice == 2)
                {
                    funks.Palidrom();
                }
                if (choice == 3)
                {
                    funks.Palidrom();
                }

            }

            

        }
    }
}
