using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());
            int rowNumber = (input / 2) + 1;
            for (int i = 0; i <= rowNumber; i++)
            {
                for (int j = 1; j <= rowNumber - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (int i = rowNumber - 1; i >= 1; i--)
            {
                for (int j = 1; j <= rowNumber - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
