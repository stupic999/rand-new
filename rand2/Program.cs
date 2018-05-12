using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // 设定一个存放抽奖号码的list
            List<int> number = new List<int>();
            
            // 把数字1-42加入number里
            for (int i = 0; i < 42; i++)
            {
                number.Add(i);
            }

            // 抽取6个号码，并把抽出的号码从list移除，保证不重复
            for (int i = 0; i <6; i++)
            {
                int j = rand.Next(1,number.Count);
                Console.Write(number[j]+" ");
                number.RemoveAt(j);
            }
            Console.ReadLine();
        }
    }
}
