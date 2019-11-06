using System;

namespace BubbleSort
{
    class Program
    {

        static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1,31);
            Console.WriteLine("unsorted array:");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();
            int lastunsorted = array.Length - 1;
            bool flag = false;
            while (!flag)
            {
                flag = true;
                for (int i = 0; i < lastunsorted; i++)
                    if (array[i] > array[i + 1])
                    {
                        swap(array, i, i + 1);
                        flag = false;
                    }
                lastunsorted--;
            }
            Console.WriteLine("sorted array:");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
