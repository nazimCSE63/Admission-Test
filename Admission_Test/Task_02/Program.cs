using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine()); ;
            Factor(input);
        }
        public static void Factor(int number)
        {

            while (number % 2 == 0)
            {
                Console.Write($"{2} ");
                number = number / 2;
            }
            for (int i = 3; i <= Math.Sqrt(number); i = i + 2)
            {

                while (number % i == 0)
                {
                    Console.Write($"{i} ");
                    number = number / i;
                }
            }
            if (number > 2)
                Console.Write(number);
        }
    }
}
