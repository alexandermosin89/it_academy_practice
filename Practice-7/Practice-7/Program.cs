using System;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeEmptyArray();
            MaxValinArray();
        }
        static void MakeEmptyArray()
        {
            int[] array1;
        }

        static void MaxValinArray()
        {
            Random rand = new Random();
            int[] array2 = new int[13];
            int max = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rand.Next(0,10);
                Console.Write(array2[i] + " ");
                if (array2[i] > max)
                    max = array2[i];
            }
            Console.WriteLine();
            Console.WriteLine("max value = " + max);
        }
        static void Array3el()
        {
            string[] array3 = new string[3];
            array3[0] = "32";

            
        }
    }
}
