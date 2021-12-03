using System;

namespace STANKOVIC_Adrien_TP1_ST2TRD
{
    class TP1_OUT
    {
        static void Main(string[] args)
        {
            
            //Exercise 1
            Console.WriteLine("--------Exercise 1---------");
            Console.WriteLine();
            
            var ex1 = new Exercise1();
            ex1.Multiplication();
            Console.WriteLine();
            ex1.MultiplicationOdd();
            Console.WriteLine();
            ex1.MultiplicationChoice();
            Console.WriteLine();
            
            //Exercise 2
            Console.WriteLine("--------Exercise 2---------");
            Console.WriteLine();
            
            var ex2 = new Exercise2();
            ex2.Prime();
            Console.WriteLine();
            ex2.Fibonacci();
            Console.WriteLine();
            ex2.Factor();
            Console.WriteLine();
            
            //Exercise 3
            Console.WriteLine("--------Exercise 3---------");
            Console.WriteLine();
            
            var ex3 = new Exercise3();
            ex3.TryCatch();
            Console.WriteLine();
            
            //Exercise 4
            Console.WriteLine("--------Exercise 4---------");
            Console.WriteLine();
            
            var ex4 = new Exercise4();
            ex4.square();
            Console.WriteLine();
            ex4.squareStars();
            Console.WriteLine();
            
            //Exercise 5
            Console.WriteLine("--------Exercise 5---------");
            Console.WriteLine();
            
            var ex5 = new Exercise5();
            ex5.ChristmasTree();
        }
    }
}