using System;
using System.Collections.Generic;

namespace PatikaDevCSharpHW
{
    class Program
    {
        public static void Question1()
        {
            Console.Write("Kac tane sayi gireceginizi yazin = ");
            int n = Int32.Parse(Console.ReadLine());
            string s = String.Empty;
            for (int i = 0; i < n; i++)
            {
                int a = Int32.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    s += a + " ";
                }
            }
            Console.WriteLine(s);
        }
        public static void Question2(int n, int m)
        {
            string s = String.Empty;
            for (int i = 0; i < n; i++)
            {
                int a = Int32.Parse(Console.ReadLine());
                if (a % m == 0)
                {
                    s += a + " ";
                }
            }
            Console.WriteLine(s);
        }
        public static void Question3(int n)
        {
            string s = String.Empty;
            List<string> word = new List<string>();
            for (int i = 0; i < n; i++)
            {
                word.Add(Console.ReadLine());
            }
            for (int i = n-1; i <= 0; i--)
            {
                s += word[i] + " ";
            }
            Console.WriteLine(s);
        }
        public static void Question4(string sentence)
        {
            string[] strList =  sentence.Split(" ");
            int count = strList.Length;
            int letterCount = 0;
            for (int i = 0; i < strList.Length; i++)
            {
                char[] letterList = strList[i].ToCharArray();
                letterCount += letterList.Length;
            }
            Console.WriteLine("Toplam kelime sayisi = "+count);
            Console.WriteLine("Toplam harf sayisi = "+letterCount);
        }
        static void Main(string[] args)
        {
            Console.Write("Cozmek istediginiz sorunun numarasini yazin = ");
            int n = Int32.Parse(Console.ReadLine());
            if (n == 1)
            {
                Question1();
            }
            else if (n == 2)
            {
                Console.WriteLine("Iki tane pozitif sayi giriniz");
                Console.Write("1.Pozitif Sayi = ");
                int a = Int32.Parse(Console.ReadLine());
                Console.Write("2.Pozitif Sayi = ");
                int b = Int32.Parse(Console.ReadLine());
                if(a>0 && b > 0)
                {
                    Question2(a,b);
                }
                else
                {
                    Console.WriteLine("Yanlis sayi girdiniz.");
                }
            }
            else if (n == 3)
            {
                Console.Write("Kac tane kelime gireceksiniz = ");
                int a = Int32.Parse(Console.ReadLine());
                Question3(a);
            }
            else if (n == 4)
            {
                Console.Write("Cumlenizi yazin = ");
                string s = Console.ReadLine();
                Question4(s);
            }
            else
            {
                Console.Write("Boyle bir soru numarasi yok. Lutfen tekrar deneyin. (Soru sayilari 1-4 arasindadir)");
                n = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
