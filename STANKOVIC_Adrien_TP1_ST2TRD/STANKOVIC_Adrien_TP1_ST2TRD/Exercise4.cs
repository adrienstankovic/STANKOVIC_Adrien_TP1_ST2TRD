using System;

namespace STANKOVIC_Adrien_TP1_ST2TRD
{
    public class Exercise4
    {
        private static int[] AskUserForParameter()
        {
            Console.WriteLine("Please write two numbers n and m separated by a coma and press enter :");
            string choice = Console.ReadLine();
            try
            {
                int.TryParse(choice.Split(',')[0], out int first);
                int.TryParse(choice.Split(',')[1], out int second);
                int[] result = new int[2] {first, second};
                return result;
            }
            catch (Exception e)
            {
                return AskUserForParameter();
            }
        }
        
        public void square()
        {
            Console.WriteLine("Square");
            Console.WriteLine();
            
            //n is for the horizontal length
            //m is for the vertical length
            
            int n = 0;
            int m = 0;

            while ((n < 1 || n > 1000) || (m < 1 || m > 1000))
            {
                var input = AskUserForParameter();
                n = input[0];
                m = input[1];
            }
            Console.WriteLine();
            Console.WriteLine("Square : ");
            Console.WriteLine();
        
            //case for (1,1) : 0
            if (n == 1 && m == 1)
            {
                Console.WriteLine("0");
            }
            //case for (n,1) : 0----0
            if (n > 1 && m == 1)
            {
                Console.WriteLine("0" + new string('-', n - 2) + "0");
            }
            //case for (1,m) : 0||||0 (vertical)
            if (n == 1 && m > 1)
            {
                Console.WriteLine("0");
                for (int i = 2; i < m; i++)
                {
                    Console.WriteLine("|");
                }
                Console.WriteLine("0");
            }
        
            //case for (n,m)
            if (n > 1 && m > 1)
            {
                Console.WriteLine("0" + new string('-', n - 2) + "0");

                for (int j = 2; j < m; j++)
                {
                    Console.WriteLine("|" + new string(' ', n - 2) + "|");
                }
            
                Console.WriteLine("0" + new string('-', n - 2) + "0");
            }
        }
        
        public void squareStars()
        {
            Console.WriteLine("Square with stars");
            Console.WriteLine();
            
            //n is for the horizontal length
            //m is for the vertical length
            
            int n = 0;
            int m = 0;
            
            while ((n < 1 || n > 1000) || (m < 1 || m > 1000))
            {
                var input = AskUserForParameter();
                n = input[0];
                m = input[1];
            }

            Console.WriteLine();
            Console.WriteLine("Square : ");
            Console.WriteLine();
            
            //case for (1,1) : 0
            if (n == 1 && m == 1)
            {
                Console.WriteLine("0");
            }
            //case for (n,1) : 0----0
            if (n > 1 && m == 1)
            {
                Console.WriteLine("0" + new string('-', n - 2) + "0");
            }
            //case for (1,m) : 0||||0 (vertical)
            if (n == 1 && m > 1)
            {
                Console.WriteLine("0");
                for (int i = 2; i < m; i++)
                {
                    Console.WriteLine("|");
                }
                Console.WriteLine("0");
            }
            
            //case for (n,m)
            if (n > 1 && m > 1)
            {
                Console.WriteLine("0" + new string('-', n - 2) + "0");
                for (int j = 2; j < m; j++)
                {
                    Console.Write("|");
                    int s = 0;
                    s = j % 3;
                    for (int k = 2; k < n; k++)
                    {
                        if (k % 3 == s)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
                Console.WriteLine("0" + new string('-', n - 2) + "0");
            }
        }
    }
}