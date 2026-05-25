using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FundamentalsofProgramming.Session_08
{
    internal class Ex_08
    {
        static void Main(string[] args)
        {
            //to input a string and print i
            Console.Write("Nhap chuoi: ");
            string cau = Console.ReadLine();
            Console.WriteLine("Chuoi la "+ cau);
            // to find the length of a string without using a library function
            int lenght = 0;
            foreach (char c in cau)
            {
                lenght++;
            }
            Console.WriteLine("so tu trong cau la: "+ lenght);
            //to separate individual characters from a string
            Console.WriteLine("tach cac ky tu rieng le cua cau se thanh: ");
            foreach(char c in cau)
            {
                Console.WriteLine(c);
            }
            //in tung ky tu nguoc lai
            Console.WriteLine("tach cac ky tu rieng le thu tu nguoc lai se thanh: ");

            for(int i=cau.Length-1;i>=0;i--)
            {
                Console.WriteLine(cau[i]);
            }
            //
            int wordCount = 0;
            bool inWord = false;

            // Count words manually
            foreach (char c in cau)
            {
                if (c != ' ' && c != '\t')
                {
                    if (!inWord)
                    {
                        wordCount++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }

            // Print result
            Console.WriteLine("Total number of words: " + wordCount);

        }
    }
}
