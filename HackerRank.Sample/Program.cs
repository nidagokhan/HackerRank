using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //int[] sayiDizisi = { 1, 2, 3, 4, 10, 11 };
            //int toplam = 0;
            //foreach (var item in sayiDizisi)
            //{
            //    toplam = toplam + item;
            //}

            //Console.WriteLine(toplam); 
            #endregion

            #region MyRegion
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //int[] dizi = { 1, 0, 2, 2, 3 };

            //int sayac = TekrarSayisi(sayi, dizi);

            //Console.WriteLine($" {sayi} dizinin içinde {sayac} tane var."); 
            #endregion

            #region MyRegion

            //int[] dizi = { 1, 2, 3 };

            //string a = dizi[0].ToString(); //1
            //string b = dizi[1].ToString(); //2
            //string c = dizi[2].ToString(); //3

            //string d = (a + b + c); //123

            //int e = Convert.ToInt32(d);
            //int f = e + 1; //124

            //string g = f.ToString(); //124

            //int[] dizi1 = new int[3];

            //dizi1[0] = Convert.ToInt32(g.Substring(0, 1));
            //dizi1[1] = Convert.ToInt32(g.Substring(1, 1));
            //dizi1[2] = Convert.ToInt32(g.Substring(2, 1));


            //Console.WriteLine(dizi1[0] + ", " + dizi1[1] + ", " + dizi1[2]); 
            #endregion

            #region MyRegion

            //int[] dizi0 = { 11, 2, 4 };
            //int[] dizi2 = { 10, 8, -12 };
            //int sonuc = 0;

            //for (int i = 0; i < dizi0.Length; i++)
            //{
            //    sonuc = Math.Abs((dizi0[i] + dizi2[]) - (dizi0[2] + dizi2[0]));
            //}

            //Console.WriteLine(sonuc);

            // return sonuc;

            #endregion

            #region MyRegion

            //Console.WriteLine(timeConversion("01:05:45PM"));

            //List<int> myIntArray = new List<int> { -4, 3, -9, 0, 4, 1 };
            //plusMinus(myIntArray);
            #endregion

            #region MyRegion
            //extraLongFactorials(25); 
            #endregion

            #region MyRegion
            //List<int> mumlar = new List<int>();
            //mumlar.Add(4);//1
            //mumlar.Add(4);//2
            //mumlar.Add(1);//-
            //mumlar.Add(3);//-
            //mumlar.Add(5);//1
            //mumlar.Add(7);//1
            //mumlar.Add(7);//2
            //mumlar.Add(8);//1
            //mumlar.Add(9);//1
            //mumlar.Add(9);
            //mumlar.Add(9);
            //mumlar.Add(13);

            //int sonuc = birthdayCakeCandles(mumlar);
            //Console.WriteLine(sonuc);
            #endregion

            Console.ReadKey();

        }

        #region BirthDay Candles
        //public static int birthdayCakeCandles(List<int> candles)
        //{
        //    int enBuyukDeger = candles[0];
        //    int geriDonecekDeger = 0;

        //    for (int i = 0; i < candles.Count; i++)

        //    {
        //        if (candles[i] > enBuyukDeger)
        //        {
        //            enBuyukDeger = candles[i];
        //            geriDonecekDeger = 1;
        //        }
        //        else if (candles[i] == enBuyukDeger)
        //        {
        //            geriDonecekDeger++;
        //        }
        //    }
        //    return geriDonecekDeger;
        //}
        #endregion

        #region Extra Long Factorials
        //public static void extraLongFactorials(int n)
        //{
        //    BigInteger result = new BigInteger();
        //    result = 1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        result = result * i;
        //    }
        //    Console.WriteLine(result);
        //}

        #endregion

        #region StairCase
        public static void staircase(int n)
        {

        }
        #endregion

        #region Plus Minus

        //public static void plusMinus(List<int> arr)
        //{
        //   float adet = arr.Count();
        //   float pozitif = 0;
        //   float negatif = 0;
        //   float sifir = 0;

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        if (arr[i] > 0)
        //        {
        //            pozitif++;
        //        }
        //        else if (arr[i] < 0)
        //        {
        //            negatif++;
        //        }
        //        else
        //        {
        //            sifir++;
        //        }
        //    }

        //    Console.WriteLine(pozitif / adet);
        //    Console.WriteLine(negatif/adet);
        //    Console.WriteLine(sifir/adet);

        #endregion

        #region Time conversion
        //public static string timeConversion(string s)
        //{
        //    string sonIki = s.Substring(s.Length - 2);
        //    string saat = null;

        //    if (sonIki == "AM")
        //    {
        //        if (s.Substring(0, 2) == "12")
        //        {
        //            saat = "00" + s.Substring(2, 6);
        //        }
        //        else
        //        {
        //            saat = s.Substring(0, 8);
        //        }
        //    }
        //    else
        //    {
        //        int hour = Convert.ToInt32(s.Substring(0, 2));
        //        if (hour == 12)
        //        {
        //            saat = s.Substring(0, 8);
        //        }
        //        else
        //        {
        //            hour = (hour + 12) % 24;
        //            saat = hour.ToString("00") + s.Substring(2, 6);
        //        }
        //    }

        //    return saat;
        //}
        #endregion

        #region Mini-Maks Sum
        //public static void miniMaxSum(List<int> arr)
        //{
        //    int tumToplam = 0;
        //    int toplamMin = 0;
        //    int toplamMax=0;

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        tumToplam = arr[i] + tumToplam;
        //    }

        //    toplamMax = tumToplam - arr.Min();
        //    toplamMin= tumToplam - arr.Max();

        //    Console.WriteLine($"{toplamMin} {toplamMax}");

        //} 
        #endregion

        #region Apple and Orange

        //public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        //{
        //    int count_a = 0;
        //    int count_b = 0;

        //    for (int i = 0; i < apples.Count; i++)
        //    {
        //        int newApple = apples[i] + a;
        //        if (newApple >= s && newApple <= t)
        //        {
        //            count_a++;
        //        }
        //    }
        //    for (int i = 0; i < oranges.Count; i++)
        //    {
        //        int newOrange = oranges[i] + b;
        //        if (newOrange >= s && newOrange <= t)
        //        {
        //            count_b++;
        //        }
        //    }
        //    Console.WriteLine(count_a);
        //    Console.WriteLine(count_b);
        //}

        #endregion

        #region MyRegion
        //public static int TekrarSayisi(int sayi, int[] dizi)
        //{
        //    int sayac = 0;

        //    foreach (int item in dizi)
        //    {
        //        if (item == sayi)
        //        {
        //            sayac++;
        //        }
        //    }

        //    return sayac;
        //} 
        #endregion
    }
}

