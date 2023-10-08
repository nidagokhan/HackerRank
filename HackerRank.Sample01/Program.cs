using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sample01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "ivvkxq";
            string b = "ivvkx";

            char[] ca=a.ToCharArray();
            char[] cb=b.ToCharArray();

            char[] a1Son=new char[ca.Length];
            char[] a2Son = new char[ca.Length];

            char[] b1Son=new char[cb.Length];
            char[] b2Son = new char[cb.Length];

            for (int i = 0; i < ca.Length; i++)
            {
                if (i%2==0)
                {
                    a1Son[i] = ca[i]; 
                }
                else
                {
                    a2Son[i] = ca[i];
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(a1Son);
            sb.Append(" ");
            sb.Append(a2Son);
            
           
            for (int j = 0; j < cb.Length; j++)
            {
                if (j % 2 == 0)
                {
                    b1Son[j] = cb[j];
                }
                else
                {
                    b2Son[j] = cb[j];
                }
            }
            StringBuilder sb1= new StringBuilder();
            sb1.Append(b1Son);
            sb1.Append(" ");
            sb1.Append(b2Son);

            Console.WriteLine(sb);
            Console.WriteLine(sb1);
            Console.ReadKey();
        }
    }
}

