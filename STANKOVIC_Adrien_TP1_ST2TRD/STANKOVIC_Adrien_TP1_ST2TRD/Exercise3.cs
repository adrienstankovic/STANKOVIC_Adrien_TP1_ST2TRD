using System;

namespace STANKOVIC_Adrien_TP1_ST2TRD
{
    public class Exercise3
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }
        
        public void TryCatch()
        {
            Console.WriteLine("Try Catch");
            Console.WriteLine();
            int n = 0;
            for (int i = -3; i <= 3; i++)
            {
                try
                {
                    n = (10 / PowerFunction(i));
                    Console.WriteLine(n);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("division by  0");
                }
            }
        }
    }
}