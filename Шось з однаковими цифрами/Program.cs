using System;

namespace Шось_з_однаковими_цифрами
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
            string nw = a.ToString();
            string kk = ReverseNumber(a).ToString();
            if (nw[0] == kk[0])
            {
                return true;
            }
            else
                return false;
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
                if (IsReverse(elem) == true)
                {
                    count++;
                }
            }
            Console.WriteLine("Чисел з однаковими першою та останньою цифрами у цiй послідовностi:\t" +
                count);
        }
    }
}
