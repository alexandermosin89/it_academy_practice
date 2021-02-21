using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    num = num + 1;
                }
            }
            Console.WriteLine("Количество букв равно {0}", num);
            Console.ReadKey();
        }
    }
}
