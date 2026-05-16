using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FundamentalsofProgramming.Session_06
{
    internal class Ex_06_PART_1
    {
        //1.to caculate the average value of array elements.
        static double avg(int[] arr)
        {
            double a = 0, sum = 0;
            foreach (int i in arr)
                sum += i;
            a = sum / arr.Length;
            return a;
        }
        //2.to test if an array contains a specific value
        static bool containsValue(int[] arr1, int x)
        {
            foreach (int i in arr1)
            {
                if (x == i)
                    return true;
            }
            return false;

        }
        //3.to find the index of an array element.
        static int FindIndex(int[] arr2, int x)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }
        //4.to remove a specific element from an array.
        //tim phan tu can xoa, neu tim thay thi xoa va tra ve true, nguoc lai tra ve false
        static bool xoa_phantu(int[] arr3, ref int n, int x)
        {
            for (int i =0; i < n; i++)
            {
                if (arr3[i] == x)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        arr3[j] = arr3[j + 1];
                    }
                    n--;
                    return true;
                }
            }
            return false;
        }
        //sinh ngau nhien n phan tu cua mang
        static void phatsinh_mang(int[] a, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(1, 100);
        }
        static void In_Mang(int[] a, int n)
        {
            for(int i = 0;i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
        //5.to find the maximum and minimum value of an array.
        static int MaxValue(int[] arr4)
        {
            int max = arr4[0];

            foreach (int i in arr4)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }

        // to find the minimum value of an array
        static int MinValue(int[] arr4)
        {
            int min = arr4[0];

            foreach (int i in arr4)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }
        //6.to reverse an array of integer values.
        static void ReverseArray(int[] arr5)
        {
            int left = 0;
            int right = arr5.Length - 1;

            while (left < right)
            {
                int temp = arr5[left];
                arr5[left] = arr5[right];
                arr5[right] = temp;

                left++;
                right--;
            }
        }
        //7.to find duplicate values in an array of values.
        static void FindDuplicate(int[] arr6)
        {
            Console.WriteLine("Duplicate values:");

            for (int i = 0; i < arr6.Length; i++)
            {
                for (int j = i + 1; j < arr6.Length; j++)
                {
                    if (arr6[i] == arr6[j])
                    {
                        Console.Write(arr6[i] + " ");
                        break;
                    }
                }
            }

            Console.WriteLine();
        }
        //8.to remove duplicate elements from an array.
        static int[] RemoveDuplicate(int[] arr7)
        {
            int[] temp = new int[arr7.Length];
            int count = 0;

            for (int i = 0; i < arr7.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < count; j++)
                {
                    if (arr7[i] == temp[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    temp[count] = arr7[i];
                    count++;
                }
            }

            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }
        static void Main()
        {
            //1.to caculate the average value of array elements.
            int[] arr = { 1, 2, 3, 4, 5, 32, 5, 6 };
            double tb = avg(arr);
            Console.WriteLine("trung binh gia tri trong mang " + tb);
            //2.to test if an array contains a specific value
            Random rd = new Random();

            int[] randomArr = new int[10];

            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = rd.Next(1, 101);
            }
            Console.WriteLine("Array elements:");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.Write("Enter value to search: ");
            int x = int.Parse(Console.ReadLine());


            if (containsValue(arr, x))
                Console.WriteLine("Array contains " + x);
            else
                Console.WriteLine("Array does not contain " + x);
            //3.to find the index of an array element.
            int[] arr2 = { 1, 2, 3, 4, 5 };

            int index = FindIndex(arr2, 4);

            Console.WriteLine("Index = " + index);
            //4.to remove a specific element from an array.
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr3 = new int[n];
            phatsinh_mang(arr3, n);//sinh n so ngau nhien cho mang
            In_Mang(arr3, n);
            Console.Write("Nhap phan tu can xoa: ");
            int y = int.Parse(Console.ReadLine());
            bool kq = xoa_phantu(arr, ref n, y);
            if(!kq)
            {
                Console.WriteLine("Khong tim thay phan tu nao can xoa!");
            }
            else
            {
                Console.WriteLine("Mang sau khi xoa: ");
                for (int i = 0;i<n;i++)
                {  Console.Write(arr3[i]+ " "); }
            }
            //5.to find the maximum and minimum value of an array.
            int[] arr4 = { 5, 2, 9, 1, 7 };

            Console.WriteLine("Maximum value: " + MaxValue(arr4));
            Console.WriteLine("Minimum value: " + MinValue(arr4));
            //6.to reverse an array of integer values.
            int[] arr5 = { 1, 2, 3, 4, 5 };

            ReverseArray(arr5);

            Console.WriteLine("Array after reverse:");

            foreach (int i in arr5)
            {
                Console.Write(i + " ");
            }
            //7.to find duplicate values in an array of values.
            int[] arr6 = { 1, 2, 3, 2, 5, 1, 7 };

            FindDuplicate(arr6);
            //8.to remove duplicate elements from an array.
            int[] arr7 = { 1, 2, 3, 2, 5, 1, 7 };

            int[] newArr = RemoveDuplicate(arr7);

            Console.WriteLine("Array after removing duplicates:");

            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
