using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming.Session_04
{
    internal class Ex_04
    {
        static int Max(int a, params int[] pars)
        {
            int max = a;
            foreach (int i in pars)
            {
                if (i > max) { max = i; }
            }
            return max;

        }
        static long Factorial(int a)
        {
            int b = 1;
            for (int i = 1; i <= a; i++)
            {
                b = b * i;
            }
            return b;
        }
        static bool nto(int a)
        {
            if (a <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                { return false; }
            }
            return true;
        }
        static void PrintPrimeUnderN(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (nto(i))
                    Console.WriteLine($"{i}, ");
            }
        }
        static void PrintFirtsPrimeN(int n)
        {
            int dem = 0;
            int so = 2;
            while (dem < n)
            {
                if (nto(so))
                {
                    dem++;
                    Console.WriteLine($"{so} ");
                }
                so++;
            }
        }
        static bool hhao(int a)
        {
            {
                bool hhao = false;
                int b = 1;
                for (int i = 2; i < a; i++)
                {
                    if ((a % i) == 0)
                    {
                        b = b + i;
                    }
                }
                if (b == a)
                {
                    hhao = true;
                }
                return hhao;
            }
        }
        static bool IsPangram(string text)
        {
            HashSet<char> letters = new HashSet<char>();

            foreach (char c in text.ToLower())
            {
                if (c >= 'a' && c <= 'z')
                {
                    letters.Add(c);
                }
            }

            return letters.Count == 26;
        }
        static void Main(string[] args)
        {
            //bai1
            Console.Write("nhap 1 so");
            int ba = int.Parse(Console.ReadLine());
            Console.Write("nhap 1 so");
            int bc = int.Parse(Console.ReadLine());
            Console.Write("nhap 1 so");
            int bd = int.Parse(Console.ReadLine());
            int m1 = Max(ba, bc, bd);
            Console.WriteLine($"so lon nhat cua 3 so la : {m1} ");
            //bai2
            Console.Write("nhap vao 1 so");
            int a = int.Parse(Console.ReadLine());
            long gt = Factorial(a);
            Console.WriteLine($"{a}!= {gt}");
            //bai3
            Console.Write("Nhap 1 so: ");
            int b = int.Parse(Console.ReadLine());
            if (nto(b))
            {
                Console.WriteLine($"{b} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{b} khong la so nguyen to");
            }
            //bai4
            Console.WriteLine("nhap vao 1 so");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"cac so nguyen to nho hon {n}");
            PrintPrimeUnderN(n);
            Console.WriteLine($"\n{n}cac so nguyen to dau tien");
            PrintFirtsPrimeN(n);
            //bai5
            Console.WriteLine("nhap vao 1 so");
            int d = int.Parse(Console.ReadLine());
            if (hhao(d))
            {
                Console.WriteLine($"{d} la so hoan hao");
            }
            else
            {
                Console.WriteLine($"{d} khong la so hoan hao");
            }
            for (int i = 1; i < d; i++)
            {
                if (hhao(i))
                {
                    Console.Write($"{i} \n");
                }
            }
            //bai6
            Console.Write("Nhap chuoi: ");
            string sentence = Console.ReadLine();
            if (IsPangram(sentence))
            {
                Console.WriteLine("The string is a pangram.");
            }
            else
            {
                Console.WriteLine("The string is not a pangram.");
            }


        }

    }
}