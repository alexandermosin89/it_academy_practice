using System;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeEmptyArray();
            MaxValinArray();
            Array3el();
            BoxUnbox();
        }
        static void MakeEmptyArray()
        {
            int[] array1;
        }

        static void MaxValinArray()
        {
            Random rand = new Random();
            int[] array2 = new int[13];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rand.Next(0, 10);
                Console.Write(array2[i] + " ");
            }
            int max = array2[0];
            for (int i = 1; i < array2.Length; i++)
            {
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
            array3[1] = "A";
            array3[2] = "Hello";
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }
            array3[0] = Convert.ToString(Convert.ToInt32(array3[0]) + 10);
            array3[2] = "Hello" + ", guys";
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }
        }
        static void BoxUnbox()
        {
            Console.WriteLine("Введите число");
            short a = Convert.ToInt16(Console.ReadLine());
            object b = a;
            sbyte c = (sbyte)Convert.ToInt16(a);
            Console.WriteLine(b);

        }
        
    }
}
