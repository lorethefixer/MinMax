using System;
using System.Collections.Generic;

namespace MaxMinOrdinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 9, 10 };
            //prova
            Console.Write("Numero massimo: " + Max(numList));
            Console.Write("\nNumero minimo: " + Min(numList));

            Console.Read();
        }

        public static int Max(List<int> numList)
        {
            int max = 0;

            foreach (var item in numList)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            return max;
        }

        public static int Min(List<int> numList)
        {
            int min = numList[0];

            foreach (var item in numList)
            {
                if (min > item)
                {
                    min = item;
                }
            }

            return min;
        }
    }
}
