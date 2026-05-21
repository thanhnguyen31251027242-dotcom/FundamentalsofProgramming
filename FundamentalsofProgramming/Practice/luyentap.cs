using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace FundamentalsofProgramming.Practice
{
    internal class luyentap
    {
        //kiem tra so chan
        static bool kiemtrasochan(int n)
        {
            return n % 2 == 0;
        }
        
        //tinh tong
        static int Tinhtong(int a, int b)
        {
            return a + b;
        }

        //tim max
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        
        //giai thua
        static long Tinhgiaithua(int m)
        {
            long ketqua = 1;
            for(int i=1;i<=m;i++)
            {
                ketqua *= i;
            }
            return ketqua;

        }
        static void Main(string[] args)
        {
            //kiem tra so chan
            int n=8;
            if (kiemtrasochan(n))
            { Console.WriteLine($"{n} la so chan"); }
            else { Console.WriteLine($"{n} la so le"); }
            //tinh tong
            int ketqua = Tinhtong(5,7);
            Console.WriteLine("Tong la "+ ketqua );
            //tim max
            int max = TimMax(4, 6, 11);
            Console.WriteLine("Max cua ba so la "+ max );
            //tinh giai thua
            int m = 5;
            long giaithua = Tinhgiaithua(m);
            Console.WriteLine(m + "! =" + giaithua);


        }
    }
}
