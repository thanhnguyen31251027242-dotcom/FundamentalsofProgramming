using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming.Session_05
{
    internal class Bài_tập
    {

        // Hàm tính tổng hai số nguyên
        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        // Hàm kiểm tra số chẵn
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        // Hàm tìm số lớn nhất trong 3 số
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        // Hàm tính giai thừa
        static long TinhGiaiThua(int n)
        {
            long ketQua = 1;

            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }

            return ketQua;
        }

        // Hàm đảo ngược chuỗi
        static string DaoNguocChuoi(string input)
        {
            char[] kyTu = input.ToCharArray();

            Array.Reverse(kyTu);

            return new string(kyTu);
        }

        //
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Hàm in dãy Fibonacci
        static void InFibonacci(int n)
        {
            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int temp = a + b;
                a = b;
                b = temp;
            }
        }

        // Hàm đếm số lượng nguyên âm
        static int DemNguyenAm(string s)
        {
            int dem = 0;

            s = s.ToLower();

            foreach (char c in s)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    dem++;
                }
            }

            return dem;
        }

        // Hàm tính lũy thừa
        static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;

            for (int i = 1; i <= y; i++)
            {
                ketQua *= x;
            }

            return ketQua;
        }

        // Hàm tính điểm trung bình của mảng
        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;

            foreach (int so in arr)
            {
                tong += so;
            }

            return (double)tong / arr.Length;
        }

        // Hàm kiểm tra chuỗi đối xứng
        static bool KiemTraDoiXung(string s)
        {
            s = s.ToLower();

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        // Hàm chuyển đổi từ độ C sang độ F
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        // Hàm tìm giá trị nhỏ nhất trong mảng
        static int TimMin(int[] arr)
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

        // Hàm tính tổng các chữ số
        static int TongCacChuSo(int n)
        {
            int tong = 0;

            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }

            return tong;
        }

        // Hàm sắp xếp mảng tăng dần
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);

            Console.Write("Mang sau khi sap xep: ");

            foreach (int so in arr)
            {
                Console.Write(so + " ");
            }
        }

        // Hàm xóa ký tự trùng lặp
        static string XoaTrungLap(string s)
        {
            string ketQua = "";

            foreach (char c in s)
            {
                if (!ketQua.Contains(c))
                {
                    ketQua += c;
                }
            }

            return ketQua;
        }

        // Hàm tìm UCLN bằng thuật toán Euclid
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // Hàm chuyển đổi thập phân sang nhị phân
        static string DecimalToBinary(int n)
        {
            string binary = "";

            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }

            return binary;
        }

        // Hàm kiểm tra năm nhuận
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Hàm đếm số từ trong câu
        static int DemSoTu(string sentence)
        {
            string[] tu = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return tu.Length;
        }
        static void Main(string[] args)
        {
            // Hàm tính tổng hai số nguyên
            int ketQua = TinhTong(5, 7);

            Console.WriteLine("Tong la: " + ketQua);

            //Kiểm tra số chẵn lẻ
            int so = 8;

            if (KiemTraChan(so))
            {
                Console.WriteLine(so + " la so chan");
            }
            else
            {
                Console.WriteLine(so + " la so le");
            }

            //Tìm số lớn nhất trong ba số
            int max = TimMax(12, 25, 18);

            Console.WriteLine("So lon nhat la: " + max);

            //Tính giai thừa của một số
            int n = 5;

            long giaiThua = TinhGiaiThua(n);

            Console.WriteLine(n + "! = " + giaiThua);

            //Đảo ngược chuỗi ký tự
            string chuoi = "Hello";

            string ketQua1 = DaoNguocChuoi(chuoi);

            Console.WriteLine("Chuoi sau khi dao nguoc: " + ketQua1);

            //Kiểm tra số nguyên tố
            int so1 = 7;
            int so2 = 10;

            Console.WriteLine(so1 + " -> " + KiemTraNguyenTo(so1));
            Console.WriteLine(so2 + " -> " + KiemTraNguyenTo(so2));

            //In dãy Fibonacci
            int m = 6;

            Console.Write("Dãy Fibonacci: ");
            InFibonacci(m);

            //Đếm số lượng nguyên âm trong chuỗi
            string chuoi1 = "Hello World";

            int ketQua2 = DemNguyenAm(chuoi1);

            Console.WriteLine("Số nguyên âm: " + ketQua2);

            //Tính lũy thừa
            double x = 2;
            int y = 3;

            double ketQua3 = TinhLuyThua(x, y);

            Console.WriteLine(x + "^" + y + " = " + ketQua3);

            //Tính điểm trung bình của mảng
            int[] mang = { 4, 5, 6, 7 };

            double trungBinh = TinhTrungBinh(mang);

            Console.WriteLine("Diem trung binh: " + trungBinh);

            //Kiểm tra chuỗi đối xứng (Palindrome)
            string chuoi2 = "radar";
            string chuoi3 = "hello";

            Console.WriteLine(chuoi2 + " -> " + KiemTraDoiXung(chuoi2));
            Console.WriteLine(chuoi3 + " -> " + KiemTraDoiXung(chuoi3));

            //Chuyển đổi nhiệt độ
            double celsius = 25;

            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine(celsius + "°C = " + fahrenheit + "°F");

            //Tìm giá trị nhỏ nhất trong mảng
            int[] mang1 = { 10, 5, 8, 2, 9 };

            int ketQua4 = TimMin(mang1);

            Console.WriteLine("Gia tri nho nhat la: " + ketQua4);

            //Tính tổng các chữ số của một số nguyên
            int b = 1234;

            int ketQua5 = TongCacChuSo(n);

            Console.WriteLine("Tong cac chu so la: " + ketQua5);

            //Sắp xếp mảng tăng dần
            int[] mang2 = { 3, 1, 4, 2 };

            SapXepMang(mang2);

            //Xóa ký tự trùng lặp
            string chuoi5 = "programming";

            string ketQua6 = XoaTrungLap(chuoi5);

            Console.WriteLine("Chuoi sau khi xoa trung lap: " + ketQua6);

            //Tìm ước chung lớn nhất (UCLN)
            int a = 12;
            int c = 18;

            int ketQua7 = UCLN(a, b);

            Console.WriteLine("UCLN = " + ketQua7);

            //Chuyển đổi hệ thập phân sang nhị phân
            int v = 10;

            string ketQua8 = DecimalToBinary(v);

            Console.WriteLine("So nhi phan: " + ketQua8);

            //Kiểm tra năm nhuận
            int nam1 = 2024;
            int nam2 = 2023;

            Console.WriteLine(nam1 + " -> " + KiemTraNamNhuan(nam1));
            Console.WriteLine(nam2 + " -> " + KiemTraNamNhuan(nam2));

            //Đếm số từ trong câu
            string cau = "Hoc lap trinh rat thu vi";

            int ketQua9 = DemSoTu(cau);

            Console.WriteLine("So tu trong cau: " + ketQua9);
        }
    }
}
