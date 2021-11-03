using System;

namespace Tashoglo._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i <= 1000; i++)
                {
                    int sum = 0;
                    for (int a = 1; a <= i; a++)
                    {
                        int x = i % a;
                        if (x == 0)
                            sum++;
                    }
                    if (sum == 5)
                        Console.WriteLine(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
    }
}
