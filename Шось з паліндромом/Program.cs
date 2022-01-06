using System;

namespace Шось_з_паліндромом
{
    class Program
    {
        static int ReverseNumber(int num)
        {
            int s = 0;
            while (num > 0)
            {
                s = s * 10 + num % 10;
                num /= 10;
            }
            return s;
        }
        static bool IsReverse(int a)
        {
            return ReverseNumber(a) == a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть кiлькiсть чисел:");
            int length = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("Введiть числа:");
            for (int i = 0; i < length; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                if (IsReverse(elem))
                {
                    count++;
                }
            }
            Console.WriteLine("Палiндромiв у цiй послідовностi:\t" + 
                count);
        }
    }
}
