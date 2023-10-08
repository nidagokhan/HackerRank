using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sample02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 4;
            List<int> list = new List<int>() {2,5,4,3};
            int[] index = new int[1];
            index[0] = 1;

            for (int i = 0; i < list.Count; i++)
            {
                if ((list[0] + list[i]) == m)
                {
                    Array.Resize(ref index, index.Length + 1);
                    index[index.Length-1] = i+1;
                }
                //else if (list[0] == list[i])
                //{
                //    list[0] = 0;
                //    Array.Resize(ref index, index.Length + 1);
                //    index[index.Length - 1] = i + 1;
                //}
            }

            foreach (int i in index)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        //public static List<int> icecreamParlor(int m, List<int> arr)
        //{

        //}
    }
}
