using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text;

//1. Print Hello and Name
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Xin Chào, tôi tên là Nguyễn Trung Thành.");
//2. Sum of Two Numbers
Console.Write("nhap vao so thu nhat ");
int a, b;
a = int.Parse(Console.ReadLine());
Console.Write("nhap vao so thu hai ");
b = int.Parse(Console.ReadLine());
int sum = a + b;
Console.WriteLine("tong cua hai so la: " + sum);
//3. Divide Two Numbers
Console.Write("nhap vao so thu nhat ");
double c = double .Parse(Console.ReadLine());
Console.Write("nhap vao so thu hai ");
double d = double.Parse(Console.ReadLine());
Console.WriteLine("ket qua cua phep chia la " + (c / d));
//5. Swap Two Numbers
int e = 5; int f = 6;
Console.WriteLine($"truoc khi hoan doi: e = {e}, f = {f} ");
int temp = e;
e = f ;
f = temp;
Console.WriteLine($"sau khi hoan doi: e = {e}, f = {f} ");
//6. Multiply Three Numbers
int g = 2, h = 3, i = 6;
int result = g * h * i;
Console.WriteLine("ket qua cua phep nhan ba so la " + result);
//14. Celsius to Kelvin and Fahrenheit
float celsius = 30f;
float kelvin = celsius + 273f;
float fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"{celsius} in C degree = {kelvin} K, = {fahrenheit} F ");
//
