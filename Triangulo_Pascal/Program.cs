using System;
using System.Diagnostics;

namespace Traingulo_Pascal
{
    class Program
    {
        static void Main(string[] arg)
        {
            int pisos = 5;
            int[] array = new int[1];
            Console.WriteLine("ingrese el numero de pisos");
            pisos = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < pisos; i++)
            {
                int[] pascal = new int[i];
                for (int j = pisos; j < i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        pascal[k] = array[k] + array[k - 1];
                    }
                    Console.Write("[ " + pascal[k] + "]");
                }
                array = pascal;

                Console.WriteLine(" ");
            }

            Console.ReadLine();
        }
    }
}