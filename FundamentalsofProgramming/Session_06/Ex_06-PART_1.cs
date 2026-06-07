using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FundamentalsofProgramming.Session_06
{
    internal class Ex_06_PART_1
    {
        // 1. Tính trung bình
        static double TinhTrungBinh(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return (double)sum / arr.Length;
        }

        // 2. Kiểm tra tồn tại
        static bool KiemTraTonTai(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }

            return false;
        }

        // 3. Tìm vị trí
        static int TimViTri(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return i;
            }

            return -1;
        }

        // 4. Xóa phần tử đầu tiên có giá trị value
        static int[] XoaPhanTu(int[] arr, int value)
        {
            int index = TimViTri(arr, value);

            if (index == -1)
                return arr;

            int[] result = new int[arr.Length - 1];

            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index)
                {
                    result[j] = arr[i];
                    j++;
                }
            }

            return result;
        }

        // 5. Tìm max và min
        static int TimGtln(int[] arr)
        {
            int Max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Max < arr[i])
                { Max = arr[i]; }
            }
            return Max;
        }

        static int TimGtnn(int[]arr)
        {
            int Min = arr[0];
            for (int i = 0; i<arr.Length; i++)
            {
                if (Min > arr[i])
                { Min = arr[i]; }
            }
            return Min;
        }


        // 6. Đảo ngược mảng
        static int[] DaoNguocMang(int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[arr.Length - 1 - i];
            }

            return result;
        }

        // 7. Tìm phần tử trùng lặp
        static void TimPhanTuTrungLap(int[] arr)
        {
            Console.Write("Gia tri trung lap: ");

            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }

                bool printed = false;

                for (int k = 0; k < i; k++)
                {
                    if (arr[k] == arr[i])
                    {
                        printed = true;
                        break;
                    }
                }

                if (count > 1 && !printed)
                {
                    Console.Write(arr[i] + " ");
                    found = true;
                }
            }

            if (!found)
                Console.Write("No duplicates");

            Console.WriteLine();
        }

        // 8. Xóa phần tử trùng lặp
        static int[] XoaPhanTuTrungLap(int[] arr)
        {
            int[] temp = new int[arr.Length];
            int size = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool exists = false;

                for (int j = 0; j < size; j++)
                {
                    if (temp[j] == arr[i])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    temp[size] = arr[i];
                    size++;
                }
            }

            int[] result = new int[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        static void InMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Random rd = new Random();

            int[] arr = new int[15];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 11);
            }

            Console.WriteLine("Mang Ngau Nhien:");
           InMang(arr);

            Console.WriteLine("\nTrung Binh = " + TinhTrungBinh(arr));

            Console.WriteLine("Chua 5: " + KiemTraTonTai(arr, 5));

            Console.WriteLine("Vi tri 5: " + TimViTri(arr, 5));

            Console.WriteLine("\nSau khi xoa 5:");
            InMang(XoaPhanTu(arr, 5));


            Console.WriteLine("\nMax = " + TimGtln(arr));
            Console.WriteLine("\nMin = " + TimGtnn(arr));

            Console.WriteLine("\nMang sau khi dao nguoc:");
            InMang(DaoNguocMang(arr));

            Console.WriteLine();
            TimPhanTuTrungLap(arr);

            Console.WriteLine("\nSau khi xoa trung lap:");
           InMang(XoaPhanTuTrungLap(arr));
        }
    }
}
