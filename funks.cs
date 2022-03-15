using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valikud__Kordused__Massivid_Variaant_4
{
    public class funks
    {
        public static void Palidrom() 
        {
            string slovop;
            int s4et = 0;
            slovop = Console.ReadLine();
            string[] polin = new string[slovop.Length];
            for (int i = 0; i < slovop.Length; i++)
            {
                if (slovop[i] == ' ')
                {

                }
                else
                {
                    polin[i] = slovop[i].ToString().ToLower();
                }

            }

            for (int i = 0; i < polin.Length; i++)
            {
                if (polin[i] == polin[polin.Length - 1 - i])
                {
                    s4et++;
                }
            }
            if (s4et == polin.Length)
            {
                Console.WriteLine("Это палиндром");
            }
            else
            {
                Console.WriteLine("Это не палиндром");
            }
        }
    }
}
