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

        public static void Matrica()
        {
            int[,] matrica = new int[3, 3] { { 1, 2, 3 }, { 4, -5, 6 }, { 7, 8, -9 } };
            int chet = 0;
            int nechet = 0;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrica[i,j] < 0)
                    {
                        nechet++;
                    }
                    else
                    chet++;
                    Console.WriteLine(i+", "+j);
                }
            }
            Console.WriteLine("Количество четных символов >>>" + chet + "\nКоличество нечет символов >>>" + nechet);
        }

        public static void Stroka()
        {
            Console.Write("Введите строку >>> ");
            string stroka = Console.ReadLine();
            char [] code = new char[stroka.Length];
            for (int i = 0; i < stroka.Length; i++)
            {
                code[i]=stroka[i];
            }
            Array.Sort(code);
            Array.Reverse(code);
            string stroka2 = new String(code);

            Console.WriteLine(stroka2);


        }





    }



}
