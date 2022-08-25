using System;
using System.Collections;
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
        public static void Question5()
        {
            Console.WriteLine("Asal Sayilari Belirleyen Liste");
            List<int> asal = new List<int>();
            List<int> notAsal = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Pozitif bir sayi giriniz = ");
                int num = Int32.Parse(Console.ReadLine());
                bool checkAsal = true;
                if(num == 2)
                {
                    asal.Add(num);
                }
                else if(num == 1)
                {
                    notAsal.Add(num);
                }
                else if (num > 2)
                {
                    for (int k = num - 1; k > 1; k--)
                    {
                        if (num % k == 0)
                        {
                            checkAsal = false;
                        }
                        else
                        {
                            checkAsal = true;
                        }
                    }
                    if (checkAsal)
                    {
                        asal.Add(num);
                    }
                    else
                    {
                        notAsal.Add(num);
                    }
                }
                else
                {
                    Console.WriteLine("Yanlis sayi girdiniz.");
                    break;
                }

            }
            asal.Sort();
            notAsal.Sort();
            string asalStr = String.Empty;
            string notAsalStr = String.Empty;
            for (int i = 0; i < asal.Count; i++)
            {
                asalStr += asal[i] + " ";
            }
            for (int i = 0; i < notAsal.Count; i++)
            {
                notAsalStr += notAsal[i] + " ";
            }
            Console.WriteLine("Asal sayilar = " + asalStr);
            Console.WriteLine("Asal olmayan sayilar = " + notAsalStr);
        }
        public static void Question6()
        {
            Console.WriteLine("En buyuk 3 sayinin ve En kucuk 3 sayinin ortalamasini bulan program");
            Console.WriteLine("20 tane sayi giriniz");
            List<int> numList = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                Console.Write((i + 1) + ". sayiyi giriniz = ");
                int num = Int32.Parse(Console.ReadLine());
                numList.Add(num);
            }
            numList.Sort();
            float minAverage = (numList[0] + numList[1] + numList[2])/3;
            float maxAverage = (numList[19] + numList[18] + numList[17])/3;
            Console.WriteLine("En kucuk 3 elemanin ortalamasi = " + minAverage);
            Console.WriteLine("En buyuk 3 elemanin ortalamasi = " + maxAverage);
        }
        public static void Question7(string s)
        {
            s.ToLower();
            List<string> res = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    res.Add("a");
                }
                if (s[i] == 'e')
                {
                    res.Add("e");
                }
                if (s[i] == 'i')
                {
                    res.Add("i");
                }
                if (s[i] == 'o')
                {
                    res.Add("o");
                }
                if (s[i] == 'u')
                {
                    res.Add("u");
                }
            }
            string resSentence = String.Empty;
            for (int i = 0; i < res.Count; i++)
            {
                resSentence += res[i] + " ";
            }
            Console.WriteLine("Cumle icinde bulunan sesli harfler = " + resSentence);
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
            else if(n == 5)
            {
                Question5();
            }
            else if(n == 6)
            {
                Question6();
            }
            else if(n == 7)
            {
                Console.Write("Cumlenizi yazin = ");
                string s = Console.ReadLine();
                Question7(s);
            }
            else
            {
                Console.Write("Boyle bir soru numarasi yok. Lutfen tekrar deneyin. (Soru sayilari 1-4 arasindadir)");
                n = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
