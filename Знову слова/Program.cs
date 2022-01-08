using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Знову_слова
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rad = Console.ReadLine().Trim().Split();
            Console.WriteLine(CreateWord(rad));
            Console.ReadKey();
        }
        static string CreateWord(string[] data)
        {
            int count01 = 0;
            int count = 0;
            string k = data[0];
            string k1 = k;
            for (int j = 0; j < k.Length; j++)
            {
                if (k[j] == 'а' || k[j] == 'е' || k[j] == 'и' || k[j] == 'і' || k[j] == 'о' || k[j] == 'я' || k[j] == 'є' || k[j] == 'ї' || k[j] == 'ю' || k[j] == 'у')
                {
                    count++;
                }
            }
            for (int i = 1; i < data.Length; i++)
            {
                k = data[i];
                for (int j = 0; j < k.Length; j++)
                {
                    if (k[j] == 'а' || k[j] == 'е' || k[j] == 'и' || k[j] == 'і' || k[j] == 'о' || k[j] == 'я' || k[j] == 'є' || k[j] == 'ї' || k[j] == 'ю' || k[j] == 'у')
                    {
                        count01++;
                    }
                }
                if (count01 > count)
                {
                    k1 = k;
                }
                
            }
            return k1;
        }
        static void CountOfLatters(string k)
        {
           
            
        }
    }
}
