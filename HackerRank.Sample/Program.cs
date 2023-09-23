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

            #region MyRegion
            //List<int> grades = new List<int> { 73, 67, 38, 33 };
            //List<int> roundedGrades = gradingStudents(grades);

            //Console.WriteLine("Yuvarlanmış Notlar:");
            //foreach (int grade in roundedGrades)
            //{
            //    Console.WriteLine(grade);
            //} 
            #endregion

            #region ASCİİ Değ. Bulma
            //char a = 'z';
            //Console.WriteLine(Convert.ToByte(a).GetHashCode());
            //Console.ReadKey();
            #endregion

            #region Muhammet Çözüm

            //string kelime = Console.ReadLine().ToLower();

            //if (string.IsNullOrWhiteSpace(kelime) || kelime.Length <= 1)
            //{
            //    Console.WriteLine("no answer");
            //    return;
            //}

            //char[] kelimeHarfleri = new char[kelime.Length];
            //int h = 0;

            //foreach (var item in kelime)
            //{
            //    if (char.IsLetter(item))
            //    {
            //        kelimeHarfleri[h] = item;
            //    }
            //    h++;
            //}

            //bool cevap = true;
            //cevap = Char.IsDigit(kelimeHarfleri[0]);

            //char degisecekIlkHarf = ' ';
            //int degisecekIlkHarfIndisi = 0;
            //char degisecekIkinciHarf = ' ';
            //int degisecekIkinciHarfIndisi = 0;

            //for (int i = kelime.Length - 1; i > 0; i--)
            //{
            //    byte harfAscii = Convert.ToByte(kelimeHarfleri[i]);
            //    byte harfAscii2 = Convert.ToByte(kelimeHarfleri[i - 1]);
            //    if (harfAscii > harfAscii2)
            //    {
            //        degisecekIlkHarf = kelimeHarfleri[i];
            //        degisecekIlkHarfIndisi = i;
            //        degisecekIkinciHarf = kelimeHarfleri[i - 1];
            //        degisecekIkinciHarfIndisi = i - 1;
            //        break;
            //    }
            //}
            //if (degisecekIlkHarfIndisi != 0)
            //{
            //    kelimeHarfleri[degisecekIkinciHarfIndisi] = degisecekIlkHarf;
            //    kelimeHarfleri[degisecekIlkHarfIndisi] = degisecekIkinciHarf;
            //    Console.WriteLine(kelimeHarfleri);
            //}
            //else
            //{
            //    Console.WriteLine("no answer");
            //} 
            #endregion

            #region Adil Abi Çözüm
            //static string biggerIsGreater(string str)
            //{
            //    char[] word = str.ToCharArray();
            //    if (word.Length == 1)
            //    {
            //        return "no answer";
            //    }
            //    int i = word.Length - 2;
            //    while (i >= 0 && word[i] >= word[i + 1])
            //    {
            //        i--;
            //    }
            //    if (i < 0)
            //    {
            //        return "no answer";
            //    }
            //    int j = word.Length - 1;
            //    while (j >= 0 && word[j] <= word[i])
            //    {
            //        j--;
            //    }
            //    (word[i], word[j]) = (word[j], word[i]);



            //    Array.Sort(word, i + 1, word.Length - i - 1);



            //    return new string(word);
            //}
            #endregion

            #region MyRegion
            //string s = "abcc";
            //int[] adetDizisi = new int[s.Length];
            //bool valid = true;
            //string valid1 = "";

            //for (int i = 1; i < s.Length; i++)
            //{
            //    adetDizisi[i] = s.Count(a => a == s[i]);
            //}

            //for (int j = 0; j < adetDizisi.Length; j++)
            //{
            //    if (adetDizisi[0] != adetDizisi[j])
            //    {
            //        valid = false;
            //        break;
            //    }
            //}

            //if (valid)
            //{
            //    valid1 = "YES";
            //}
            //else
            //{
            //    valid1 = "NO";
            //}
            //Console.Write(valid1); 
            #endregion

            #region MyRegion
            //string a = kangaroo(21, 6, 47, 3);
            //Console.WriteLine(a); 
            #endregion

            #region MyRegion
            //List<List<int>> arr = new List<List<int>>();
            //List<int> innerList1 = new List<int> { -10, 3, 0, 5, -4 };
            //List<int> innerList2 = new List<int> { 2, -1, 0, 2, -8 };
            //List<int> innerList3 = new List<int> { 9, -2, -5, 6, 0 };
            //List<int> innerList4 = new List<int> { 9, -7, 4, 8, -2 };
            //List<int> innerList5 = new List<int> { 3, 7, 8, -5, 0 };

            ////List<int> innerList1 = new List<int> { 11,2,4 };
            ////List<int> innerList2 = new List<int> { 4,5,6 };
            ////List<int> innerList3 = new List<int> { 10,8,-12};

            //arr.Add(innerList1);
            //arr.Add(innerList2);
            //arr.Add(innerList3);
            //arr.Add(innerList4);
            //arr.Add(innerList5);

            //int sonuc = diagonalDifference(arr);
            //Console.WriteLine(sonuc); 
            #endregion



            Console.ReadKey();
        }

        #region Diagonal Difference
        //public static int diagonalDifference(List<List<int>> arr)
        //{
        //    int toplam1 = 0;
        //    int toplam2 = 0;
        //    int result = 0;
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        for (int j = 0; j < arr.Count; j++)
        //        {
        //            if (i == j)
        //            {
        //                toplam1 += arr[i][j];
        //            }
        //            if (i+j ==arr.Count-1)
        //            {
        //                toplam2+= arr[i][j];
        //            }
        //            result=Math.Abs(toplam1-toplam2);
        //        }
        //    }
        //    return result;
        //}
        #endregion

        #region Number Line Jumps

        //public static string kangaroo(int x1, int v1, int x2, int v2)
        //{
        //    string result = "";

        //    if (v1==v2)
        //    {
        //        result = "NO";
        //    }
        //    else
        //    {
        //        int a = (x1 - x2) / (v2 - v1);
        //        if (((x1 - x2) % (v2 - v1)) != 0 || a <= 0)
        //        {
        //            result = "NO";
        //        }
        //        else
        //        {
        //            result = "YES";
        //        }
        //    }           
        //return result;
        //}

        #endregion

        #region appendAndDelete-bakılacak
        //public static string appendAndDelete(string s, string t, int k)
        //{
        //    int minLength = Math.Min(s.Length, t.Length);
        //    int farkIndex = -1;
        //    string c = "";
        //    string d = "";
        //    string result = "";

        //    if (s.Length == t.Length)
        //    {
        //        k = s.Length + t.Length + 1;
        //        result = "Yes";
        //    }
        //    else if (s.Length != t.Length)
        //    {
        //        for (int i = 0; i < minLength; i++)
        //        {
        //            if (t.Length == i)
        //            {
        //                result = "No";
        //                break;
        //            }
        //            else if (s[i] != t[i])
        //            {
        //                farkIndex = i;
        //                c = s.Substring(0, i);
        //                d = t.Substring(i);
        //                k = i + d.Length - 1;
        //                if (k < 3)
        //                    result = "No";
        //                else
        //                    result = "Yes";
        //                break;
        //            }
        //        }
        //    }
        //    return result;

        #endregion

        #region Angry Professor

        //public static string angryProfessor(int k, List<int> a)
        //{
        //    int sayac = 0;
        //    string durum = "";

        //    foreach (int i in a)
        //    {
        //        if (i<=0)
        //        {
        //            sayac++;
        //        }
        //    }

        //    if (sayac>=k)
        //    {
        //        durum = "NO";
        //    }
        //    else
        //    {
        //        durum = "YES";
        //    }

        //    return durum;
        //}

        #endregion

        #region biggerIsGreater-bakılacak
        //public static string biggerIsGreater(string w)
        //{
        //    char[] tekHarf = w.ToCharArray();
        //    int[] asciiDeg = new int[tekHarf.Length];

        //    for (int i = 0; i < tekHarf.Length; i++)
        //    {
        //        asciiDeg[i] = Convert.ToByte(tekHarf[i]).GetHashCode();

        //        if (asciiDeg[i] == asciiDeg.Max())
        //        {
        //            asciiDeg[0] = asciiDeg[i];
        //        }

        //        if (asciiDeg[i] == asciiDeg.Min())
        //        {
        //            asciiDeg[asciiDeg.Length - 1] = asciiDeg[i];
        //        }
        //    }


        //    return tekHarf.ToString(); 
        #endregion

        #region Sherlock and the Valid String
        //public static string isValid(string s)
        //{

        //} 
        #endregion

        #region Grading Students
        //public static List<int> gradingStudents(List<int> grades)
        //{
        //    for (int i = 0; i < grades.Count; i++)
        //    {
        //        if ((grades[i] + 2) % 5 == 0 && grades[i] >= 38)
        //        {
        //            grades[i] = grades[i] + 2;
        //        }
        //        else if ((grades[i] + 1) % 5 == 0 && grades[i] >= 38)
        //        {
        //            grades[i] = grades[i] + 1;
        //        }
        //        else if (grades[i] < 38)
        //        {
        //            grades[i] = grades[i];
        //        }
        //    }

        //    return grades;
        //} 
        #endregion

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

        #region StairCase - bakılacak
        //public static void staircase(int n)
        //{

        //}
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


