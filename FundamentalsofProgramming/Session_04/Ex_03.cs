using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace FundamentalsofProgramming.Session_03
{
    internal class Ex_03
    {
        static void Main(string[] args)
        { 
            //1. Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.
            Console.Write("Input first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                case 'x':
                case 'X':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    return;
            }

            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");

            //2.Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
            Console.WriteLine("y\t x = y^2 + 2y + 1");
            Console.WriteLine("----------------------");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;

                Console.WriteLine($"{y}\t {x}");
            }

            //3.Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
            Console.Write("Input distance (in meters): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            // Tổng thời gian tính bằng giây
            double timeSeconds = (hours * 3600) + (minutes * 60) + seconds;

            // Speed in meters/second
            double metersPerSecond = distance / timeSeconds;

            // Speed in km/h
            double kmPerHour = (distance / 1000.0) / (timeSeconds / 3600.0);

            // Speed in miles/h
            double milesPerHour = kmPerHour / 1.609;

            Console.WriteLine("Speed in meters/second: " + metersPerSecond);
            Console.WriteLine("Speed in km/h: " + kmPerHour);
            Console.WriteLine("Speed in miles/h: " + milesPerHour);

            //4.Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3 
            Console.Write("Input the radius of the sphere: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            // Surface area
            double surface = 4 * Math.PI * radius * radius;

            // Volume
            double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;

            Console.WriteLine("Surface Area = " + surface);
            Console.WriteLine("Volume = " + volume);

            //5.Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            // Check vowel
            if ("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("It is a vowel.");
            }
            // Check digit
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("It is a digit.");
            }
            // Other symbol
            else
            {
                Console.WriteLine("It is another symbol.");
            }
        }
    }
}