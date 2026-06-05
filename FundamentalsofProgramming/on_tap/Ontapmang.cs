using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming.on_tap
{
    internal class Ontapmang
    {
        //tao mang bang com
        static void TaoMangCom(int[] arr,int n)
        {

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Moi ban nhap vao so n: ");
                int so = int.Parse(Console.ReadLine());
                arr[i] = so;
            }
        }


        //tao mang random
        static void TaoMangRandom(int[] arr, int n)
        {
          Random rnd = new Random();
            for ( int i = 0; i < n; i++)
            {
                int so = rnd.Next(1,100);
                arr[i] = so;
            }

        }

        //tinh tb cac phan tu trong mang
        static double TinhTb(int[] arr)
        {
            double sum = 0.0;
            for (int i = 0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }


        //tim vtri so lon nhat trong mang
        static int TimSoLn(int[] arr)
        {
            int Max = arr[0]; int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >Max)
                { index=i; }
            }
            return index;
        }


        //tim vi tri lon nhat trong mang
        static int TimViTri(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==x)
                { return i; }
            }
            return -1;
        }
        static void InMang(int[] arr)
        {
            for ( int i = 0; i<arr.Length;i++)
            {
                Console.Write(arr[i]+ " " );
            }
        }


        static void Main(string[] args)
        {
            //in mang com, mang random
            int n = 5;
            int[] arr = new int[n];
            int[] com = new int[n];
            TaoMangRandom(arr, n);
            Console.WriteLine("Mang random la: ");
            InMang(arr);
            Console.WriteLine();
            TaoMangCom(com, n);
            Console.WriteLine("Mang bang com la: ");
            InMang(com);

            //tinh tb mang com
            double kq = TinhTb(arr);
            Console.WriteLine("Trung binh cua mang random la: "+ kq);
            double kq1 = TinhTb(com);
            Console.WriteLine("Trung binh cua mang bang com la: "+kq1);

            //Tim vtri gtln trong mang
            int kq2 = TimSoLn(arr);
            Console.WriteLine("vi tri so lon nhat trong mang la: "+kq2);


            
        }
    }
}
