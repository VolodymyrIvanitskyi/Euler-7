using System;

namespace Euler_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int k = 2;
            while(true)
            {
                if (IsSimple(k))
                {
                    if (number == 10001)
                    {
                        Console.WriteLine($"The number {k} is a 10001 prime number");
                        return;
                    }
                    number++;
                }
                ++k;
                
            }
        }

        static bool IsSimple(int number)
        {
            for(int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
