using System;

namespace STANKOVIC_Adrien_TP1_ST2TRD
{
    public class Exercise5
    {
        public void ChristmasTree()
        {
            Console.WriteLine("Christmas Tree");
            Console.WriteLine();
            int size = 0;
            
            while (size < 3 || size > 20)
            {
                size = AskUserForParameter();
            }

            Console.WriteLine();
            Console.WriteLine("Regular Tree");
            Console.WriteLine();
            
            //space is the number of space on the first line
            int space = size-1;
            
            for (int i = 1; i <= size; i++)
            {
                for (int j = space; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                space--;
            }
            //trunks
            Console.WriteLine(new string(' ', size - 2) + "| |");
            
            Console.WriteLine();
            Console.WriteLine("Do you want to decorate it ?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.WriteLine();

            int choice = 0;

            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Please write a number and press enter :");
                int.TryParse(Console.ReadLine(), out int result);
                choice = result;
            }

            if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Decorated Tree");
                Console.WriteLine();
                
                //space is the number of space on the first line
                space = size-1;
                
                for (int i = 1; i <= size; i++)
                {
                    for (int j = space; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    space--;
                }
                //trunks
                Console.WriteLine(new string(' ', size - 2) + "| |");
            }
        }
        
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number between 3 and 20 and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
    }
}