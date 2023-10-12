using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sample03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Girilen Sayıyı 2'lik tabana çevirip peş peşe gelen maksimum 1'lerin sayısını bulma
            //int n = int.Parse(Console.ReadLine());
            //List<int> list = new List<int>();
            //int count = 0;
            //List<int> countList = new List<int>();

            //while (n > 0)
            //{
            //    int a = n % 2;
            //    n = n / 2;
            //    list.Add(a);
            //}

            //foreach (int a in list)
            //{
            //    if (a == 1)
            //    {
            //        count += a;
            //        countList.Add(count);
            //    }
            //    else if (a == 0)
            //    {
            //        count = 0;
            //    }
            //}
            //Console.WriteLine(countList.Max()); 
            #endregion

            #region Counting Sort 1

            //List<int> arr = new List<int>() //{1,1,3,2,1 };
            //{ 63 ,25, 73 ,1,98, 73, 56, 84, 86, 57, 16, 83, 8 ,25, 81, 56, 9, 53, 98, 67, 99 ,12, 83 ,89, 80, 91 ,39 ,86, 76, 85, 74, 39, 25, 90, 59, 10, 94 ,32 ,44, 3 ,89,30 ,27 ,79, 46, 96, 27, 32, 18 ,21, 92, 69, 81 ,40 ,40, 34, 68, 78, 24, 87, 42 ,69, 23 ,41, 78, 22 ,6 ,90, 99, 89 ,50, 30, 20, 1 ,43, 3,70, 95, 33, 46, 44, 9, 69, 48, 33, 60, 65, 16, 82 ,67 ,61, 32, 21, 79 ,75 ,75 ,13, 87 ,70, 33 };

            //int[] count = new int[100];

            //foreach(int i in arr)
            //{
            //    count[i] += 1;
            //}

            //foreach(int item in count)
            //{
            //    Console.Write(item+" ");
            //}
            #endregion

            #region Flipping The Matrix
            //List<List<int>> arr = new List<List<int>>();
            //List<int> list1 = new List<int>() { 112, 42, 83, 119 };
            //List<int> list2 = new List<int>() { 56, 125, 56, 49 };
            //List<int> list3 = new List<int>() { 15, 78, 101, 43 };
            //List<int> list4 = new List<int>() { 62, 98, 114, 108 };

            //arr.Add(list1);
            //arr.Add(list2);
            //arr.Add(list3);
            //arr.Add(list4);

            //int toplam = 0;

            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (arr[0][0] < arr[arr.Count][0])
            //    {
            //        kolonu ters çevir
            //    }
            //    if (arr[0][0] < arr[0][arr.Count])
            //    {
            //        satırı ters çevir
            //    }
            //}


            #endregion

            #region Caesar Cipher
            //int k = 87;
            //string s = "www.abc.xy";
            //string alfabe = "abcdefghijklmnopqrstuvwxyz";
            //string araDegisken1=" ", araDegisken2=" ";

            //if (k<=26)
            //{
            //     araDegisken1 = alfabe.Substring(0, k);
            //     araDegisken2 = alfabe.Substring(k, alfabe.Length - k);
            //}
            //else if (k>26)
            //{
            //    k = k % 26;
            //     araDegisken1 = alfabe.Substring(0, k);
            //     araDegisken2 = alfabe.Substring(k, alfabe.Length - k);
            //}

            //string degistirilenAlfabe = araDegisken2 + araDegisken1;

            //char[] result = new char[s.Length];

            //Dictionary<string, string> map = new Dictionary<string, string>();

            //for (int i = 0; i < alfabe.Length; i++)
            //{
            //    map[alfabe[i].ToString()] = degistirilenAlfabe[i].ToString();
            //    map[alfabe[i].ToString().ToUpper()] = degistirilenAlfabe[i].ToString().ToUpper();
            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (map.ContainsKey(s[i].ToString()))
            //    {
            //        string item = s[i].ToString();
            //        result[i] = Convert.ToChar(map[item]);
            //    }
            //    else
            //    {
            //        result[i] = s[i];
            //    }
            //}

            //string a = new string(result);
            //Console.WriteLine(a);

            #endregion

            #region Tower Breakers



            #endregion

            Console.ReadKey();
        }
    }
}
