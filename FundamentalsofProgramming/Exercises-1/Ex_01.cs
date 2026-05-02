using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming
{
    internal class Ex_01
    {
        /*
         Write programs that: 

1. to Add / Sum Two Numbers.

2. to Swap Values of Two Variables.

3. to Multiply two Floating Point Numbers

4. to convert feet to meter

5. to convert Celsius to Fahrenheit and vice versa

6. to find the Size of data types

7. to Print ASCII Value (tip: read character, print number of this char)

8. to Calculate Area of Circle

9. to Calculate Area of Square

10. to convert days to years, weeks and days
         */
        public static void Run()
        {
            //1. to Add / Sum Two Numbers.
            int a = 10 + 6;
            Console.WriteLine("The sum of 10 and 6 is: " + a);
            //2. to Swap Values of Two Variables.
            int b = 5; int c = 10;
            Console.WriteLine($"Truoc khi hoan doi b = { b},c = { c}");
                        int temp = b;
            b = c;
            c = temp;
            Console.WriteLine($"sau khi hoan doi b = {b}, c = {c}");
            //3. to Multiply two Floating Point Numbers
            float f1 = 3.5f; float f2 = 2.5f;
            float result = f1 * f2;
            Console.WriteLine($"{f1} * {f2} = {result}");
            //4. to convert feet to meter
            float feet = 10f;
            float meters = feet * 0.3048f;
            Console.WriteLine($"{feet} feets = {meters} meters");
            //5. to convert Celsius to Fahrenheit and vice versa
            float celsius = 25f;
            float fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} in C degree = {fahrenheit} F");
            float fahrenheit2 = 77f;
            float celsius2 = (fahrenheit2 - 32) * 5 / 9;
            Console.WriteLine( $"{fahrenheit2} in F degree = {celsius2} C");
            //6. to find the Size of data types
            Console.WriteLine("int: " + sizeof(int) + " bytes");
            Console.WriteLine("double: " + sizeof(double) + " bytes");
            Console.WriteLine("float: " + sizeof(float) + " bytes");
            Console.WriteLine("char: " + sizeof(char) + " bytes");
            Console.WriteLine("bool: " + sizeof(bool) + " bytes");
            //7. to Print ASCII Value (tip: read character, print number of this char)
            Console.Write("Nhap ky tu: ");
            char ch = Console.ReadKey().KeyChar;

            int ascii = (int)ch;

            Console.WriteLine("\nASCII = " + ascii);
            //8. to Calculate Area of Circle
            Console.Write("Nhap ban kinh");
            double r = double.Parse(Console.ReadLine());
            double areaCircle = Math.PI * Math.Pow(r,2);
            Console.WriteLine("dien tich hinh tron = " + areaCircle);
            //9. to Calculate Area of Square
            Console.Write("Nhap canh");
            double x = double.Parse(Console.ReadLine());
            double areasquare = Math.Pow(x,2);
            Console.WriteLine("dien tich hinh vuong = " + areasquare);
            //10. to convert days to years, weeks and days
            Console.Write("Nhap so ngay: ");
                        int days = int.Parse(Console.ReadLine());
                        int years = days / 365;
                                    int weeks = (days % 365) / 7;
                                                int remainingDays = (days % 365) % 7;
                        Console.WriteLine($"{days} days = {years} years, {weeks} weeks, {remainingDays} days");

        }
    }

    }
