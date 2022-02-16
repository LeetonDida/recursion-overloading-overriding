using System;

namespace Method_overloading_and_overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleOfNumberRecursive(5);
        }

        static void TriangleOfNumberRecursive(int n)
        {
            if(n < 1) 
            {
            
                return;
            };


            TriangleOfNumberRecursive(n - 1);

            for (int j = 0; j < n; ++j)
            {
                Console.Write(n);
            }
            Console.WriteLine("\n");
        }


        static void TriangleOfNumber(int n)
        {
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write(i);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
