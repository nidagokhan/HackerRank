using System;
using System.Collections;
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
            #region İcecream Parlor Test
            //int m = 4;
            //List<int> list = new List<int>() { 2, 5, 4, 3 };
            //int[] index = new int[1];
            //index[0] = 1;

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if ((list[0] + list[i]) == m)
            //    {
            //        Array.Resize(ref index, index.Length + 1);
            //        index[index.Length - 1] = i + 1;
            //    }
            //    //else if (list[0] == list[i])
            //    //{
            //    //    list[0] = 0;
            //    //    Array.Resize(ref index, index.Length + 1);
            //    //    index[index.Length - 1] = i + 1;
            //    //}
            //}

            //foreach (int i in index)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Listeyi/diziyi tersten yazdırma
            //List<int> list = new List<int>() { 1, 4, 3, 2 };
            //list.Reverse();
            //foreach (int i in list)
            //{
            //    Console.Write(i+" ");
            //} 
            #endregion

            #region Dictionary type
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("sam", "99912222");
            //dic.Add("tom", "11122222");
            //dic.Add("harry", "12299933");
            //string key = Console.ReadLine();
            //string value = dic[key];
            //if (value !=null)
            //{
            //    Console.WriteLine($"{key}={value}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}

            //if (dic.ContainsKey(key))
            //    Console.WriteLine($"{key}={value}");
            //else
            //    Console.WriteLine("Not Found");
            #endregion

            #region Fibonacci

            //int sayi1 = 1;
            //int sayi2 = 2;
            //int sayi3 = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    sayi3 = sayi1 + sayi2;
            //    Console.Write(sayi3 + " ");
            //    sayi1 = sayi2;
            //    sayi2 = sayi3;
            //}

            #endregion

            #region Electronics Shop
            //int[] keyboards = new int[] { 3, 1 };
            //int[] drives = new int[] { 5, 2, 8 };
            //int budget = 10;
            //int result = -1;

            //for (int i = 0; i < keyboards.Length; i++)
            //{
            //    for (int j = 0; j < drives.Length; j++)
            //    {
            //        int totalCost = keyboards[i] + drives[j];
            //        if (totalCost <= budget && totalCost > result)
            //        {
            //            result = totalCost;
            //        }
            //    }

            //}
            //Console.WriteLine(result); 
            #endregion

            #region ?
            //int[] dizi = new int[] { 4, 6, 5, 3, 3, 1 };
            //List<int> fark = new List<int>();
            //int result = 0;

            //for (int i = 1; i < dizi.Length; i++)
            //{
            //    if (dizi[i - 1] - dizi[i]<=1)
            //    {
            //        fark.Add(dizi[i-1]);
            //        fark.Add(dizi[i]);
            //    }
            //}

            //foreach (int i in fark)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            int sonuc = beautifulDays(13,45,3);
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }

        public static int beautifulDays(int i, int j, int k)
        {
            int start = i;
            int finish = j;
            int result = 0;
            int count = 0;

            for (int a = start; a <= finish; a++)
            {
                result = Math.Abs(a - Ters(a));
                if (result % k == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static int Ters(int sayi)
        {
            int ters = 0;

            while (sayi>0)
            {
                int basamak = sayi % 10;
                ters = ters * 10 + basamak;
                sayi = sayi / 10;
            }
            return ters;
        }

        //public static List<int> icecreamParlor(int m, List<int> arr)
        //{

        //}

        #region Repeated String
        //public static long repeatedString(string s, long n)
        //{
        //    #region Optimize edilmiş hali
        //    //int length = s.Length;
        //    //long fullRepeats = n / length;
        //    //int remainingChars = (int)(n % length);

        //    //long count_a = s.Count(c => c == 'a');

        //    //long totalCount = fullRepeats * count_a + s.Substring(0, remainingChars).Count(c => c == 'a');

        //    //return totalCount;
        //    #endregion

        //    char[] chars = s.ToCharArray();
        //    long count_a = 0;

        //    if (s == "a" && chars.Length == 1)
        //    {
        //        count_a = n;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < n; i++)
        //        {
        //            if (chars.Length != n)
        //            {
        //                Array.Resize(ref chars, chars.Length + 1);
        //                chars[chars.Length - 1] = chars[i];
        //            }
        //        }

        //        foreach (char c in chars)
        //        {
        //            if (c == 'a')
        //                count_a++;
        //        }
        //    }
        //    return count_a;
        //} 
        #endregion
    }
}
