using System;

namespace Якийсь_невнятний_курс
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            Console.WriteLine("How mach are you want numbers: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Ok, write a numbers");
            int j = 0;
            while (j < k)
            {
                int elem = int.Parse(Console.ReadLine());
                for (int i = 2; i < Math.Sqrt(elem); i++)
                {
                    
                    if (elem % i != 0)
                    {
                        count++;
                    }
                }
                j++;
            }
            Console.WriteLine(count);
        }
    }
}
