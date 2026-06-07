using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming.on_tap
{
    internal class Ontapmangcuoiki
    {
        //tinh gia tri trung binh cac phan tu trong mang
        static double TinhTrungBinh(int[] arr)
        {
            double tong = 0;
            foreach(int i in arr)
            {
                tong += i;
            }
            return tong / arr.Length;
        }


        //Kiem tra xem 1 mang co chua gia tri cu the hay khong
        static bool KiemTraMang(int[] arr,int x)
        {
            foreach(int i in arr)
            {
                if(i==x)
                { return true; }
            }
            return false;
        }


        //Tim chi so cua 1 phan tu mang
        static int TimChiSo(int[] arr,int n)
        {
            for(int i = 0; i<arr.Length;i++)
            {
                if (arr[i]==n)
                { return i; }
            }
            return -1;
        }


        //Tim gtln cua 1 mang
        static int TimGtln(int[] arr)
        {
            int Max = 0;
            for (int i = 0; i<arr.Length;i++)
            {
                if (Max < arr[i])
                { Max = arr[i]; }
            }
            return Max;
        }

        //other way
        static int MaxValue(int[] arr)
        {
            int max = arr[0];

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }


        //Tim gtnn trong mang
        static int TimGtnn(int[]arr)
        {
            int Min = arr[0];
            foreach(int i in arr)
            {
                if (Min > arr[i])
                {
                    Min = arr[i];
                }
            }
            return Min;
        }

        //dao nguoc 1 mang co gia tri so nguyen
  




        //Ham Main
        static void Main(string[] args)
        {
            //Tao mang random
            static void TaoMangRandom(int[] arr,int n)
            {
                Random rd = new Random();
                for (int i = 0; i<n; i++)
                {
                    int so = rd.Next(1, 100);
                    arr[i] = so;
                }
            }

            //In Mang
            static void InMang(int[] arr)
            {
                for(int i=0; i <arr.Length;i++)
                {
                    Console.Write(arr[i]+" ");
                }
            }


            int n = 5;
            int[] arr = new int[n];
            Console.WriteLine("Mang ngau nhien: ");
            TaoMangRandom(arr, n);
            InMang(arr);
            Console.WriteLine();



            //Tinh trung binh
            double KetquaTB = TinhTrungBinh(arr);
            Console.WriteLine("Ket qua tinh trung binh cua mang la: "+TinhTrungBinh(arr));


            //Kiem tra xem 1 mang co gia tri cu the hay khong
            if (KiemTraMang(arr,5))
                Console.WriteLine("co gia tri");
            else
            {
                Console.WriteLine("khong co gia tri");
            }



            //tim chi so cua 1 phan tru trong mang
            int t;
            Console.WriteLine("moi ban nhap vao 1 so de tim xem no nam o vi tri so may trong mang: ");
            t=int.Parse(Console.ReadLine());
            int chiso = TimChiSo(arr,t);
            Console.WriteLine("nam o vi tri: "+chiso);

            //Tim gtln trong mang
            int max = TimGtln(arr);
            Console.WriteLine(max);

            //Tim gtnn trong mang
            int min = TimGtnn(arr);
            Console.WriteLine(min);
    }
    }
}

