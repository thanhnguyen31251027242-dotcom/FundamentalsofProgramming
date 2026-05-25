using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming.Session_07
{
    internal class Ex_07
    {
        static void NhapMang(int[] arr, int n)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
        }

        // Hàm xuất mảng
        static void XuatMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        //tao ma tran random
        static int[,] Taomang_random(int dong, int cot)
            {
            int[,] a = new int[dong,cot];
            Random random = new Random();
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
            return a;
        }
        //In mang
        static void Inmang(int[,]a)
        {
            for (int i=0; i<a.GetLength(0);i++)
            {
                for(int j =0; j<a.GetLength(1);j++)
                {
                    Console.Write($"{a[i,j]}  ");

                }
                Console.WriteLine();
            }
        }
        // Main
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            NhapMang(arr, n);

            XuatMang(arr, n);

            //in ma tran
            Console.Write("Nhap so dong: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot ");int m = int.Parse(Console.ReadLine());
            int[,] a = Taomang_random(b, m);
            Inmang(a);
        }
    }
}
