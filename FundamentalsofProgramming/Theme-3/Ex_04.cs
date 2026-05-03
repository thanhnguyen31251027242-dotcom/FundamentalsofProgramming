using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace FundamentalsofProgramming.Practice
{
    internal class Ex_04
    {
       public static void Run()
       
        //1. Write a C# Sharp program to check whether a given number is even or odd.
        {
            Console.WriteLine("nhap 1 so: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            { Console.WriteLine($"{num} la so chan"); }
            else { Console.WriteLine($"{num} la so le"); }

            //2. Write a C# Sharp program to find the largest of three numbers.
            Console.WriteLine("nhap so thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu ba: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            { Console.WriteLine($"{num1} la so lon nhat"); }
            else if (num2 >= num1 && num2 >= num3)
            { Console.WriteLine($"{num2} la so lon nhat"); }
            else { Console.WriteLine($"{num3} la so lon nhat"); }

            //3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            Console.Write("nhap toa do x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("nhap toa do y: ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0) { Console.WriteLine("diem toa do nam o goc phan tu thu nhat"); }
            else if (x < 0 && y > 0) { Console.WriteLine("diem toa do nam o goc phan tu thu hai"); }
            else if (x > 0 && y < 0) { Console.WriteLine("diem toa do nam o goc phan tu thu ba"); }
            else if (x < 0 && y < 0) { Console.WriteLine("diem toa do nam o goc phan tu thu tu"); }
            else if (x == 0 && y == 0) { Console.WriteLine("diem toa do nam o goc toa do"); }
            else if (x == 0) { Console.WriteLine("diem toa do nam tren truc y"); }
            else if (y == 0) { Console.WriteLine("diem toa do nam tren truc x"); }

            //1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.Write("nhap canh thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap canh thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("nhap canh thu ba: ");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c) { Console.WriteLine("day la tam giac deu"); }
                else if (a == b || a == c || b == c) { Console.WriteLine("day la tam giac can"); }
                else { Console.WriteLine("day la tam giac thuong"); }
            }
            else { Console.WriteLine("day khong phai la tam giac"); }

            //2. Write a program to read 10 numbers and find their average and sum.
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"nhap so thu {i}: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            double average = sum / 10.0;
            Console.WriteLine($"tong cua 10 so la: {sum}");
            Console.WriteLine($"trung binh cong cua 10 so la: {average}");

            //3. Write a program to display the multiplication table of a given integer
            Console.Write("nhap so can in bang cuu chuong: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"bang cuu chuong cua {n}:");
            for (int i = 1; i <= 10; i++)
            { Console.WriteLine($"{n}x{i}={n * i}"); }

            //4. Write a program to display a pattern like triangles with a number.
            // pattern 1
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                { Console.Write(j); }
                Console.WriteLine("");
            }
            // pattern 2
            int number1 = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number1 + " ");
                    number1++;
                }

                Console.WriteLine();
            }
            // pattern 3
            int number2 = 1;
            int rows = 4;

            for (int i = 1; i <= rows; i++)
            {
                // In khoảng trắng
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write("  ");
                }

                // In số
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number2 + " ");
                    number2++;
                }

                Console.WriteLine();
            }

            // 6.Write a program to display the n terms of harmonic series and their sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
            int m;
            double sum3 = 0.0;
            Console.Write("nhap so n: ");
            m = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                sum3 += 1.0 / i;
                Console.Write($"1/{i} ");
                if (i < m)
                {
                    Console.Write("+ ");
                }
            }
            Console.WriteLine($"\nTong cua {m} so dau tien trong day harmonic la: {sum3}");

           // 7.Write a program to find the ‘perfect’ numbers within a given number range.
            int lower, upper;
            Console.Write("nhap gioi han duoi: ");
            lower = int.Parse(Console.ReadLine());
            Console.Write("nhap gioi han tren: ");
            upper = int.Parse(Console.ReadLine());
            Console.WriteLine("so hoan hao la:");
            for (int num4 = lower; num4 <= upper; num4++)
            {
                int sum2 = 0;
                for (int i = 1; i < num4; i++)
                {
                    if (num4 % i == 0)
                    {
                        sum2 += i;
                    }
                }
                if (sum2 == num4)
                {
                    Console.WriteLine(num4);
                }
            }

            //8. Write a program to determine whether a given number is prime or not.
            int number3;
            Console.Write("nhap so can kiem tra: ");
            number3 = int.Parse(Console.ReadLine());

            bool isPrime = true;
            if (number3 <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number3); i++)
                {
                    if (number3 % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number3} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{number3} khong phai la so nguyen to.");
            }
        }
    }
}