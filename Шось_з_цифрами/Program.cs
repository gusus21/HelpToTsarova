using System;

namespace Шось_з_цифрами
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int[] myArray = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                myArray[i] = int.Parse(data[i]);
            }
            Console.WriteLine("Число з найбiльшою цифрою:\t" + MaxNum(myArray));
            Console.WriteLine("Число з найменшою цифрою:\t" + MinNum(myArray));
        }
        static int MaxNum(int[] arr)
        {
            bool res = false;
            int n;
            int maxN = 9;
            int i = 0;
            int k = 10;
            for (i = 0; i < arr.Length; i++)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    n = arr[i];
                    if (n == maxN || n % k == maxN || n / k == maxN || (n % k) * 10 == maxN)
                    {
                        res = true;
                        break;
                    }
                    else
                    {
                        while (n % k != n)
                            k *= 10;
                    }
                    
                    if (maxN <= 0)
                        break;
                    k = 10;
                }
                if (res)
                    break;
                else
                    maxN--;
            }
            if (res)
                return arr[i];
            else
                return -1;
        }
        static int MinNum(int[] arr)
        {
            bool res = false;
            int n;
            int minN = 0;
            int i = 0;
            int k = 10;
            for (i = 0; i < arr.Length; i++)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    n = arr[i];
                    if (n == minN || n % k == minN || n / k == minN)
                    {
                        res = true;
                        break;
                    }
                    else
                    {
                        while (n % k != n)
                            k *= 10;
                    }
                    if (minN >= 9)
                        break;
                }
                if (res)
                    break;
                else
                    minN++;
            }
            if (res)
                return arr[i];
            else
                return -1;
        }
    }
}
