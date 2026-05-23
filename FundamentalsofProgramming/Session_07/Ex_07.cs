using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming.Session_07
{
    internal class Ex_07
    {
        //Create an integer matrix N x M (N,M was prompted from user) randomly.
        static int[,] Taomang_com(int rows, int columns)
        {
            int[,] a = new int[rows, columns];
            for(int i=0; i<rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Nhap phan tu a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        static int[,] Taomang_random(int rows, int columns)
        {
            int[,] a = new int[rows, columns];
            Random random = new Random();
            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<columns;j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
            return a;
        }
        //In mang
        static void Inmang(int[,]a)
        {
            for(int i=0;i< a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write($"{a[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        //in 1 dong/cot
        static void Indong(int[,]a, int rowIndex)
        {
            for(int j=0; j<a.GetLength(1);j++)
            {
                Console.Write($"{a[rowIndex,j]}\t");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: "); int columns = int.Parse(Console.ReadLine());
            ////tao mang bang com
            int[,] a = Taomang_com(rows, columns);
            Inmang(a);
            //tao mang ngau nhien
            int[,]a= Taomang_random(rows,columns);
            Console.WriteLine("Mang sau khi nhap");
            Inmang(a);
            //in 1 dong/cot
            Console.WriteLine("Nhap dong can in: ");
            int rowIndex = int.Parse(Console.ReadLine());
            Indong(a,rowIndex);
        }
    }
}
