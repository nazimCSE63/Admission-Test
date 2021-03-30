using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bre = true;
            while (bre)
            {
                string strr = Console.ReadLine();
                if(strr == "End")
                {
                    bre = false;
                }

            while (strr.Length > 0)
            {
                Console.Write(strr[0] + " ");
                int num = 0;
                for (int j = 0; j < strr.Length; j++)
                {
                    if (strr[0] == strr[j])
                    {
                        num++;
                    }
                }
                Console.WriteLine(num);
                strr = strr.Replace(strr[0].ToString(), string.Empty);
            }
            Console.ReadLine();
            };
        }
    }
}
