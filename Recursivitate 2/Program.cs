using System;

namespace Recursivitate_2
{
    class Program
    {

        public static int Maxim(int[] array, int n, int max)
        {
            if (n == 0)
            {
                if (max >= array[n])
                    return max;
                else
                    return array[n];
            }
            else
            {
                if (max >= array[n])
                    return Maxim(array, n - 1, max);
                else
                    return Maxim(array, n - 1, array[n]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Cate numeri vrei sa citesti de la tastatura?");
            int nrElements = int.Parse(Console.ReadLine());
            int[] array = new int[nrElements];
            for (int i = 0; i < nrElements; i++)
            {
                Console.Write("The " + (i + 1) + ". element = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(Maxim(array, array.Length - 1, int.MinValue));
        }

    }
}
