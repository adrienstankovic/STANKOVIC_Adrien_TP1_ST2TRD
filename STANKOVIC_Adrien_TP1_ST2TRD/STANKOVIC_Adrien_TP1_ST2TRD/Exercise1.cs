using System;

namespace STANKOVIC_Adrien_TP1_ST2TRD
{
    public class Exercise1
    {
        public void Multiplication()
        {
            Console.WriteLine("Multiplication :");
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}*{j} =  {i * j}");
                }
            }
        }

        public void MultiplicationOdd()
        {
            Console.WriteLine("Multiplication Odd");
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i * j % 2 != 0)
                    {
                        Console.WriteLine($"{i}*{j} =  {i * j}");
                    }
                }
            }
        }

        public void MultiplicationChoice()
        {
            Console.WriteLine("Multiplication with user input");
            Console.WriteLine();
            int res = 0;
            while (res <= 0)
            {
                res = AskUserForParameter();
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{res}*{i} =  {res * i}");
            }
            Console.WriteLine();
        }
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
    }
}