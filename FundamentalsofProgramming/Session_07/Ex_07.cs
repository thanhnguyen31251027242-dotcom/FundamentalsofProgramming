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

        // Main
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            NhapMang(arr, n);

            XuatMang(arr, n);
        }
    }
}
