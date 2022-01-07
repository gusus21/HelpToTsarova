using System;

namespace Шось_страшне_з_словами
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            Console.WriteLine(MadeWord(data));
        }
        static string MadeWord(string[] data)
        {
            string minSl = data[0];
            for (int i = 0; i < data.Length; i++)
            {
                string k = data[i];
                int a = k.Length;
                for (int j = 0; j < k.Length; j++)
                {
                    if (k[j] == ',' || k[j] == '!' || k[j] == '.' || k[j] == ':' || k[j] == ';')
                    {
                        k.Remove(i, 1);
                    }
                }
                if (k.Length < minSl.Length)
                {
                    minSl = k;
                }
            }
            return minSl;
        }
    }
}
