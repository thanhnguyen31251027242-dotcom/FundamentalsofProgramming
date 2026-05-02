using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace FundamentalsofProgramming.Practice
{
    internal class luyentap
    {
       public static void Run()
       
        //1. Write a C# Sharp program to check whether a given number is even or odd.
        {
            Console.WriteLine("nhap 1 so: ");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            { Console.WriteLine($"{num} la so chan"); }
            else { Console.WriteLine($"{num} la so le"); }

            //2. Write a C# Sharp program to find the largest of three numbers.
                        Console.WriteLine("nhap so thu nhat: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu ba: ");
            int num3 = int.Parse(Console.ReadLine());
            if(num1>=num2 && num1>=num3)
            { Console.WriteLine($"{num1} la so lon nhat"); }
            else if(num2>=num1 && num2>=num3)
            { Console.WriteLine($"{num2} la so lon nhat"); }
            else { Console.WriteLine($"{num3} la so lon nhat"); }
        }
    }
}
