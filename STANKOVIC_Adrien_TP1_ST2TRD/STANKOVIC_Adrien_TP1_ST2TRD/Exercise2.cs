using System;

namespace STANKOVIC_Adrien_TP1_ST2TRD
{
    public class Exercise2
    {
        public void Prime()
        {
            Console.WriteLine("Prime");
            Console.WriteLine();
            
            int max = 1000;
            for (int i = 1; i <= max; i++)
            {
                int n = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        n++;
                    }
                }
                if (n == 0 && i != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Fibonacci()
        {
            Console.WriteLine("Fibonacci");
            Console.WriteLine();
            int inp = 0;
            while (inp < 2)
            {
                inp = AskUserForParameter();
            }
            if (inp == 0)
            {
                Console.WriteLine($"F({inp}) = 0");
            }

            if (inp == 1)
            {
                Console.WriteLine($"F({inp}) = 1");
            }

            if (inp > 1)
            {
                int[] fibonacci = new int[inp+1];
                
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 2; i <= inp; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                Console.WriteLine($"F({inp}) = {fibonacci[inp]}");
            }
        }

        public void Factor()
        {
            Console.WriteLine("Factor");
            Console.WriteLine();
            int inp = 0;
            while (inp <= 0)
            {
                inp = AskUserForParameter();
            }
            int n = inp; 
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            Console.WriteLine($"{inp}! = {n}");
        }
        
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
    }
}