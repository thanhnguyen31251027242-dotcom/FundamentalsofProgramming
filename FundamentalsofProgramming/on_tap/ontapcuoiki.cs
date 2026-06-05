using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FundamentalsofProgramming.on_tap
{
    internal class ontapcuoiki
    {
        // Hàm tính tổng hai số nguyên
        static int Tinhtong(int a, int b)
        {
            return a + b;
        }

        //ktra so chan
        static bool Kiemtrasochan(int a)

        {
            return a%2==0;

        }

        //tim so lon nhat trong 3 so
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }


        //tinh giai thua
        static long TinhGiaiThua(int a)
        {
            int Giaithua = 1;
            for (int i = 1; i<=a; i++)
            {
                Giaithua *= i;

            }
            return Giaithua;
        }

        //dao nguoc chuoi
        static string DaoNguocChuoi(string s)
        {
            char[] chuoi = s.ToCharArray();
            Array.Reverse(chuoi);
            return new string(chuoi);
        }

        //kiem tra so nguyen to
        static bool KiemTraSoNguyenTo(int a)
        {
            if (a < 2)
                return false;
            for ( int i = 2; i<=Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

        //in day fibonaccy
        static void IndayFibonacci(int n) //day fibonacci co dang 0 1 1 2 3 5 8
        {
            int a = 0; int b = 1;
            for (int i = 0; i<n;i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
        }

        //Dem so luong nguyen am
        static int DemsoluongNguyenAm(string s)
        {
            int tong = 0;
            s = s.ToLower();
            foreach(char c in s)
            {
                if (c == 'u' || c == 'e' || c == 'o' || c == 'a' || c == 'i')
                {
                    tong++;
                }
            }
            return tong;
        }

        // tinh luy thua
        static double TinhLuyThua(double x, int y)
        {
            double kq = 1;
            for ( int i = 1; i<=y; i++)
            {
                kq *= x;
            }
            return kq;
        }

        //tinh trung binh cua mang
        static double TinhTrungBinh(int[] arr)
        {
            double tong = 0;
            foreach (int so in arr)
            {
                tong += so;
            }
            return tong / arr.Length;
        }


        //tim gia tri nho nhat trong mang
        static int TimGtnnTrongMang(int[] arr)
        {
            int min = arr[0];
            foreach (int so in arr)
            {
                if (so < min)
                {
                    min = so;
                }
            }
            return min;
        }


        //kiem tra chuoi doi xung
        static bool KiemTraChuoiDoiXung(string s)
        {
            s = s.ToLower();
            for ( int i = 0; i <= s.Length/2; i++)
            {
                if (s[i] == s[s.Length-1-i])
                { return true; }
            }
            return false;
        }

        
        //chuyen do c->f
        static double Chuyendoi(double c)
        {
            return (c * 9 / 5) + 32;
        }

        //tim gia tri lon nhat trong mang
        static int TimGtlntrongMang(int[] arr)
        {
            int Max = arr[0];
            foreach (int so in arr)
            {
                if (so > Max)
                { Max = so; }
            }
            return Max;
        }


        //sap xep mang tang dan
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Mang sau khi sap xep la: ");
            foreach (int so in arr)
            {
                Console.Write(so + " ");
            }
        }


        //ham xoa ki tu trung lap
        static string XoaKiTuTrunglap(string s)
        {
            string ketqua = " ";
            s = s.ToLower();
            foreach (char c in s)
            {
                if (!ketqua.Contains(c))
                {
                    ketqua += c;
                }
            }
            return ketqua;
        }
        static void Main(string[] args)
        {
            //tinh tong
            int ketqua;
            ketqua = Tinhtong(5, 7);
            Console.WriteLine($"ket qua la: {ketqua}");

            //kiem tra so chan
            int so = 7;
            if (Kiemtrasochan(so))
                Console.WriteLine($"{so} la so chan");
            else
                Console.WriteLine($"{so} la so le");

            //tim max 3 so
            int Max = TimMax(4, 6, 8);
            Console.WriteLine($"Max cua 3 so tren la: {Max}");

            //Tinh giai thua
            Console.WriteLine("Nhap vao so m: ");
            int m = int.Parse(Console.ReadLine());
            long result = TinhGiaiThua(m);
            Console.WriteLine($"{m}! = {result}");

            //dao nguoc chuoi
            string chuoi = "Hello";
            string ketqua1 = DaoNguocChuoi(chuoi);
            Console.WriteLine($"chuoi sau khi dao nguoc la: {ketqua1}");

            //Kiem tra so nguyen to
            Console.WriteLine("Nhap vao so can kiem tra xem co phai la so nguyen to hay khong: ");
            int a = int.Parse(Console.ReadLine());
            if (KiemTraSoNguyenTo(a))
                Console.WriteLine($"{a} la so nguyen to");
            else
                Console.WriteLine($"{a} khong phai la so nguyen to");

            //in day fibonacci
            int t = 6;
            Console.WriteLine("in day fibonacci: ");
            IndayFibonacci(t);
            Console.WriteLine();

            //dem nguyen am
            string cau = ("Nguoi yeu oi, anh yeu em nhieu lam");
            int kq = DemsoluongNguyenAm(cau);
            Console.WriteLine($"so luong nguyen am la: {kq}");

            //tinh luy thua
            double e; int r;
            Console.WriteLine("nhap vao so tinh luy thua: ");
            e = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao so mu: ");
            r = int.Parse(Console.ReadLine());
            double kq1 = TinhLuyThua(e, r);
            Console.WriteLine($"{e} ^ {r} = {kq1}");

            //tinh trung binh cua mang
            int[] mang = { 4, 5, 6, 7 };
            double kq2 = TinhTrungBinh(mang);
            Console.WriteLine($"diem trung binh cua mang la: {kq2}");


            //tim gtnn trong mang
            int[] mang1 = { 4, 6, 4, 3, 2, 6, 7, 87, 6 };
            int kq3 = TimGtnnTrongMang(mang1);
            Console.WriteLine($"gtnn trong mang la: {kq3}");

            //Kiem tra chuoi doi xung
            String chuoi1 = "radar";
            String chuoi2 = "trahfjbqff";
            if (KiemTraChuoiDoiXung(chuoi1))
                Console.WriteLine("chuoi doi xung day doiii");
            else
                Console.WriteLine("khong phai chuoi doi xung roii");
            if (KiemTraChuoiDoiXung(chuoi2))
                Console.WriteLine("chuoi doi xung day doiii");
            else
                Console.WriteLine("khong phai chuoi doi xung roii");

            //chuyen do c sang f
            double c = 25;
            double Fehrenheit = Chuyendoi(c);
            Console.WriteLine(c + " do c = " + Fehrenheit);

            //tim gtln trong mang
            int[] max = { 100, 2, 3, 4, 23, 43 };
            int kq4 = TimGtlntrongMang(max);
            Console.WriteLine("GTLN trong mang la: " + kq4);


            //sap xep mang
            int[] Sx = { 2, 3, 453, 4, 65, 45, 33, 5, 4 };
            SapXepMang(Sx);
            Console.WriteLine();


            //xoa ki tu
            string chuoi3 = "nguoi oi anh nho em nhieu lam";
            chuoi3 = XoaKiTuTrunglap(chuoi3);
            Console.WriteLine("chuoi sau khi xoa ki tu trung lap:"+ chuoi3);




















        }
    }
}
