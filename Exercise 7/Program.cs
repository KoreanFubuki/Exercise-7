using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        static void Main(string[] args)
        {
            WhileLoop();
            Console.WriteLine("\n");
            ForLoop();

            Console.Read();
        }
        public static void ForLoop()
        {
            for (int num = -3; num <= 3; num++)
            {
                Console.WriteLine(num);
            }
        } 

        public static void WhileLoop()
        {
            int numm = 3;
            while (numm >= -3)
            {
                Console.WriteLine(numm);
                numm--;
            }
        }
    }
}

