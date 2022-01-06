using System;

namespace Шось_з_найменшим
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть чисел:");
            int qual = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть числа:");
            int elem1 = int.Parse(Console.ReadLine());
            int minN = elem1;
            for (int i = 1; i < qual; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                if (SumOfNum(elem) < SumOfNum(minN))
                {
                    minN = elem;
                }
            }
            Console.WriteLine("Число з найменшим добутком цифр:\t" + minN);
        }
        static int SumOfNum(int n)
        {
            int sum = 0;
            while (Math.Abs(n) > 0)
            {
                sum *= n % 10;
                n /= 10;
            }
            return sum;
        }
    }
}
