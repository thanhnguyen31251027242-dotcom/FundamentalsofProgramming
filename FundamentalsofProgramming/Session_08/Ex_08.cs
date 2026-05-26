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
            //1. to input a string and print i
            Console.Write("Nhap chuoi: ");
            string cau = Console.ReadLine();
            Console.WriteLine("Chuoi la "+ cau);
            //2. to find the length of a string without using a library function
            int lenght = 0;
            foreach (char c in cau)
            {
                lenght++;
            }
            Console.WriteLine("so tu trong cau la: "+ lenght);
            //3. to separate individual characters from a string
            Console.WriteLine("tach cac ky tu rieng le cua cau se thanh: ");
            foreach(char c in cau)
            {
                Console.WriteLine(c);
            }
            //4. in tung ky tu nguoc lai
            Console.WriteLine("tach cac ky tu rieng le thu tu nguoc lai se thanh: ");

            for(int i=cau.Length-1;i>=0;i--)
            {
                Console.WriteLine(cau[i]);
            }
            //5. đếm tổng số từ trong một chuỗi ký tự
            int wordCount = 0;
            bool inWord = false;

            // đếm bằng cơm
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

            // in kết quả
            Console.WriteLine("Total number of words: " + wordCount);

            //6. So sánh hai chuỗi mà không sử dụng các hàm thư viện chuỗi
            // Nhập 2 chuõi
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            bool isEqual = true;

            // so sánh độ dài
            int len1 = 0, len2 = 0;

            foreach (char c in str1)
                len1++;

            foreach (char c in str2)
                len2++;

            if (len1 != len2)
            {
                isEqual = false;
            }
            else
            {
                // so sánh từng ký tự 1
                for (int i = 0; i < len1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            // hiển thị kết quả
            if (isEqual)
            {
                Console.WriteLine("Both strings are equal.");
            }
            else
            {
                Console.WriteLine("Both strings are not equal.");
            }

            //7. để đếm số lượng chữ cái, chữ số và ký tự đặc biệt trong một chuỗi ký tự.
            // Nhập chuỗi
            Console.Write("Nhap chuoi: ");
            string text = Console.ReadLine();

            int letters = 0;
            int digits = 0;
            int specialChars = 0;

            // Duyệt từng ký tự
            foreach (char c in text)
            {
                // Kiểm tra chữ cái
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    letters++;
                }
                // Kiểm tra chữ số
                else if (c >= '0' && c <= '9')
                {
                    digits++;
                }
                // Ký tự đặc biệt (không tính khoảng trắng)
                else if (c != ' ')
                {
                    specialChars++;
                }
            }

            // In kết quả
            Console.WriteLine("So chu cai: " + letters);
            Console.WriteLine("So chu so: " + digits);
            Console.WriteLine("So ky tu dac biet: " + specialChars);

            //8. Đếm số lượng nguyên âm hoặc phụ âm trong một chuỗi ký tự.
            // Nhập chuỗi
            Console.Write("Enter a string: ");
            string text1 = Console.ReadLine().ToLower();

            int vowels = 0;
            int consonants = 0;

            // Đếm số lượng nguyên âm và phụ âm
            foreach (char c in text)
            {
                // Kiểm tra xem ký tự đó có phải là chữ cái hay không.
                if (c >= 'a' && c <= 'z')
                {
                    // kiểm tra nguyên âm
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            // In kết quả
            Console.WriteLine("Number of vowels: " + vowels);
            Console.WriteLine("Number of consonants: " + consonants);


            //9. Kiểm tra xem một chuỗi con nhất định có xuất hiện trong chuỗi đã cho hay không
            // Nhập chuỗi chính
            Console.Write("Enter the main string: ");
            string text2 = Console.ReadLine();

            // Chuỗi con đầu vào
            Console.Write("Enter the substring: ");
            string sub = Console.ReadLine();

            bool found = false;

            // Kiểm tra chuỗi con thủ công
            for (int i = 0; i <= text.Length - sub.Length; i++)
            {
                int j;

                for (j = 0; j < sub.Length; j++)
                {
                    if (text[i + j] != sub[j])
                    {
                        break;
                    }
                }

                // Nếu tất cả các ký tự khớp
                if (j == sub.Length)
                {
                    found = true;
                    break;
                }
            }

            // In kết quả
            if (found)
            {
                Console.WriteLine("Substring is present in the string.");
            }
            else
            {
                Console.WriteLine("Substring is not present in the string.");
            }

            //10. Tìm kiếm vị trí của một chuỗi con trong một chuỗi
            // Nhập chuỗi chính
            Console.Write("Nhap chuoi chinh: ");
            string text3 = Console.ReadLine();

            // Nhập chuỗi con
            Console.Write("Nhap chuoi con: ");
            string sub1 = Console.ReadLine();

            int position = -1;

            // Tìm vị trí chuỗi con
            for (int i = 0; i <= text3.Length - sub1.Length; i++)
            {
                int j;

                for (j = 0; j < sub1.Length; j++)
                {
                    if (text3[i + j] != sub1[j])
                    {
                        break;
                    }
                }

                // Nếu tìm thấy
                if (j == sub1.Length)
                {
                    position = i;
                    break;
                }
            }

            // In kết quả
            if (position != -1)
            {
                Console.WriteLine("Chuoi con xuat hien tai vi tri: " + position);
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi con.");
            }

            //11. Để kiểm tra xem một ký tự có phải là chữ cái hay không, và nếu là chữ cái thì kiểm tra xem có viết hoa chữ thường hay không.
            // Nhập ký tự
            Console.Write("Nhap mot ky tu: ");
            char ch = Convert.ToChar(Console.ReadLine());

            // Kiểm tra có phải chữ cái không
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine(ch + " la chu cai.");

                // Kiểm tra viết hoa hay viết thường
                if (ch >= 'A' && ch <= 'Z')
                {
                    Console.WriteLine("Day la chu hoa.");
                }
                else
                {
                    Console.WriteLine("Day la chu thuong.");
                }
            }
            else
            {
                Console.WriteLine(ch + " khong phai la chu cai.");
            }

            //12. Tìm số lần một chuỗi con xuất hiện trong một chuỗi cho trước.
            // Nhập chuỗi chính
            Console.Write("Nhap chuoi chinh: ");
            string text4 = Console.ReadLine();

            // Nhập chuỗi con
            Console.Write("Nhap chuoi con: ");
            string sub2 = Console.ReadLine();

            int count = 0;

            // Đếm số lần xuất hiện
            for (int i = 0; i <= text4.Length - sub2.Length; i++)
            {
                int j;

                for (j = 0; j < sub2.Length; j++)
                {
                    if (text4[i + j] != sub2[j])
                    {
                        break;
                    }
                }

                // Nếu tìm thấy chuỗi con
                if (j == sub2.Length)
                {
                    count++;
                }
            }

            // In kết quả
            Console.WriteLine("So lan xuat hien cua chuoi con: " + count);

            //13. Chèn một chuỗi con trước lần xuất hiện đầu tiên của một chuỗi.
            // Nhập chuỗi chính
            Console.Write("Nhap chuoi chinh: ");
            string text5 = Console.ReadLine();

            // Nhập chuỗi cần tìm
            Console.Write("Nhap chuoi can tim: ");
            string find = Console.ReadLine();

            // Nhập chuỗi cần chèn
            Console.Write("Nhap chuoi can chen: ");
            string insert = Console.ReadLine();

            int position1 = -1;

            // Tìm vị trí xuất hiện đầu tiên
            for (int i = 0; i <= text5.Length - find.Length; i++)
            {
                int j;

                for (j = 0; j < find.Length; j++)
                {
                    if (text5[i + j] != find[j])
                    {
                        break;
                    }
                }

                // Nếu tìm thấy
                if (j == find.Length)
                {
                    position1 = i;
                    break;
                }
            }

            // Chèn chuỗi
            if (position1 != -1)
            {
                string result = "";

                // Phần trước vị trí tìm thấy
                for (int i = 0; i < position1; i++)
                {
                    result += text5[i];
                }

                // Chuỗi cần chèn
                result += insert;

                // Phần còn lại của chuỗi gốc
                for (int i = position1; i < text5.Length; i++)
                {
                    result += text5[i];
                }

                Console.WriteLine("Chuoi sau khi chen:");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi can tim.");
            }
        }
    }
}
