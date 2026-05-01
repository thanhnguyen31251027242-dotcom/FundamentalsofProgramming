using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
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
double c = double.Parse(Console.ReadLine());
Console.Write("nhap vao so thu hai ");
double d = double.Parse(Console.ReadLine());
Console.WriteLine("ket qua cua phep chia la " + (c / d));

//4. Specified Operations Results: Write a C# Sharp program to print the results of the specified operations.
Console.WriteLine($"{-1 + 4 * 6} ");
Console.WriteLine($"{(35 + 5) % 7}");
Console.WriteLine($"{14 + -4 * 6 / 11}");
Console.WriteLine($"{2 + 15 / 6 * 1 - 7 % 2}");

//5. Swap Two Numbers
Console.Write("Input the first number to swap ");
int e = int.Parse(Console.ReadLine());
Console.Write("Input the second number to swap ");
int f = int.Parse(Console.ReadLine());
Console.WriteLine($"truoc khi hoan doi: e = {e}, f = {f} ");
int temp = e;
e = f;
f = temp;
Console.WriteLine($"sau khi hoan doi: e = {e}, f = {f} ");

//6. Multiply Three Numbers
Console.Write("Input the first number to multiply ");
int g = int.Parse(Console.ReadLine());
Console.Write("Input the second number to multiply ");
int h = int.Parse(Console.ReadLine());
Console.Write("Input the third number to multiply ");
int p = int.Parse(Console.ReadLine());
int result = g * h * p;
Console.WriteLine("ket qua cua phep nhan ba so la " + result);

//7. Arithmetic Operations: Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
Console.Write("Input the first number ");
int j = int.Parse(Console.ReadLine());
Console.Write("Input the second number ");
int k = int.Parse(Console.ReadLine());
int add = j + k;
int subtract = j - k;
int multiply = j * k;
double divide = (double)j / k;
int modulus = j % k;
Console.WriteLine($"{j} + {k} = {add}\n {j} - {k}= {subtract}\n {j} * {k} = {multiply}\n {j} / {k} = {divide}\n {j} mod {k} = {modulus} ");

//8. Multiplication Table: Write a C# Sharp program that prints the multiplication table of a number as input.
Console.Write("Enter the number ");
int num = int.Parse(Console.ReadLine());
for (int i = 0; i <= 10; i++)
{ Console.WriteLine($"{num} * {i} = {num * i}"); }

//9. Average of Four Numbers: Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Console.Write("Enter the first number ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter the third number ");
int num3 = int.Parse(Console.ReadLine());
Console.Write("Enter the fourth number ");
int num4 = int.Parse(Console.ReadLine());
int avarage = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: " + avarage);

//10. Specified Formula with Three Numbers: Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Console.Write("Enter the first number ");
int x = int.Parse(Console.ReadLine());
Console.Write("Enter the second number ");
int y = int.Parse(Console.ReadLine());
Console.Write("Enter the third number ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine($"(x + y) * z = {(x + y) * z}");
Console.WriteLine($"x * y + y * z = {x * y + y * z}");

//11. Print Age Message: Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
Console.Write("Enter your age ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"You look older than {age}");

//12. Repeat Number in Rows: Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console.Write and use {0}.
Console.Write("Enter a digit: ");
int digit = int.Parse(Console.ReadLine());
// lan 1
Console.WriteLine("{0} {0} {0} {0}", digit);
Console.WriteLine("{0}{0}{0}{0}", digit);
// lan 2
Console.WriteLine("{0} {0} {0} {0}", digit);
Console.WriteLine("{0}{0}{0}{0}", digit);

//13. Rectangle Pattern with Number Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.
Console.Write("Enter a number ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("{0}{0}{0}", number);
for (int i1 = 0; i1 < 3; i1++)
{ Console.WriteLine("{0} {0}", number); }
Console.WriteLine("{0}{0}{0}", number);

//14. Celsius to Kelvin and Fahrenheit
float celsius = 30f;
float kelvin = celsius + 273f;
float fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"{celsius} in C degree = {kelvin} K, = {fahrenheit} F ");

//15. Remove Character by Index: Write a C# program that removes a specified character from a non-empty string using the index of a character.
Console.Write("Enter a string: ");
string str = Console.ReadLine();
Console.Write("Enter index to remove: ");
int index = int.Parse(Console.ReadLine());
if (index >= 0 && index < str.Length)
{
    string result5 = str.Remove(index, 1);
    Console.WriteLine("Result: " + result5);
}
else
{ Console.WriteLine("Invalid index!"); }

//16. Swap First and Last Characters: Write a C# program to create a new string from a given string where the first and last characters change their positions
Console.Write("Enter a string: ");
string str1 = Console.ReadLine();
if (str1.Length > 1)
{
    string result6 = str1[str1.Length - 1] + str1.Substring(1, str1.Length - 2) + str1[0];
    Console.WriteLine("Result: " + result6);
}
else
{ Console.WriteLine("Result: " + str1); }

// 17. Add First Character to Front and Back: Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.
Console.Write("Input a string: ");
string str2 = Console.ReadLine();
char firstchar = str2[0];
string result7 = firstchar + str2 + firstchar;
Console.WriteLine("Result: " + result7);

//18. Check Positive and Negative Pair: Write a C# program to check a pair of integers and return true if one is negative and one is positive
Console.Write("Enter the first number: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int numB = int.Parse(Console.ReadLine());
bool result1 = (numA < 0 && numB > 0) || (numA > 0 && numB < 0);

Console.WriteLine("Check if one is negative and one is positive:");
Console.WriteLine(result1);

//19. Sum or Triple Sum of Integers: Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
Console.Write("Enter the first number: ");
int numC = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int numD = int.Parse(Console.ReadLine());
int sum1 = numC + numD;
if (numC == numD)
{ sum1 = sum1 * 3; }
Console.WriteLine($"The result is: {sum1}");

//20. Absolute Difference or Double It: Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.
Console.Write("Enter the first number: ");
int numE = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int numF = int.Parse(Console.ReadLine());
int difference = Math.Abs(numE - numF);
if (numE > numF)
{ difference = difference * 2; }
Console.WriteLine($"The result is: {difference}");

//21. Check for 20 or Sum Equals 20: Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.
Console.Write("Enter the first number: ");
int numG = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int numH = int.Parse(Console.ReadLine());
bool result2 = (numG == 20 || numH == 20 || (numG + numH == 20));
Console.WriteLine("Result is " + result2);

//22. Check Within 20 of 100 or 200: Write a C# program to check if the given integer is within 20 of 100 or 200.
Console.Write("Enter the first number: ");
int numI = int.Parse(Console.ReadLine());
bool result3 = (Math.Abs(numI - 100) <= 20) || (Math.Abs(numI - 200) <= 20);
Console.WriteLine("Result is " + result3);

//23.Convert String to Lowercase: Write a C# program to convert a given string into lowercase.
Console.Write("Enter a string: ");
string input = Console.ReadLine();
string result4 = input.ToLower();
Console.WriteLine("Lowercase string: " + result4);

//24. Find Longest Word in String: Write a C# program to find the longest word in a string.
using System.ComponentModel;

Console.Write("Enter a string: ");
string input1 = Console.ReadLine();
string[] words = input1.Split(' ');
string longestWord = "";
foreach (string word in words)
{
    if (word.Length > longestWord.Length)
    { longestWord = word; }
}
Console.WriteLine("Longest word: " + longestWord);

//25. Print Odd Numbers 1 to 99: Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
Console.WriteLine("Odd numbers from 1 to 99: ");
for (int i = 1; i <= 99; i += 2) { Console.WriteLine(i); }
another way
Console.WriteLine("Odd numbers from 1 to 99: ");
for (int i = 1; i <= 99; i++)
{ if (i % 2 != 0) { Console.WriteLine(i); } }





