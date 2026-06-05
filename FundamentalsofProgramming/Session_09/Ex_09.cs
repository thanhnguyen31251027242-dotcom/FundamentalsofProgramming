using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentalsofProgramming.Session_09
{
    internal class Ex_09
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            // 1. Tạo thư mục làm việc 
            string thuMuc = @"C:\BaiTapFile";
            if (!Directory.Exists(thuMuc))
            {
                Directory.CreateDirectory(thuMuc);
            }

            string fileGoc = thuMuc + @"\test.txt";
            string fileCopy = thuMuc + @"\test_copy.txt";
            string fileDoiTen = thuMuc + @"\test_moi.txt";

            Console.WriteLine("--- CHẠY 15 BÀI TẬP  ---\n");

            // Chạy lần lượt từ bài 1 đến 15
            Bai1_TaoFileTrong(fileGoc);
            Bai2_XoaFile(fileGoc);
            Bai3_TaoFileVaVietChu(fileGoc, "Chào bạn\nC# File Handling thật đơn giản.\n12345");
            Bai4_TaoVaDocFile(thuMuc + @"\bai4.txt", "Học lập trình là phải vui!");

            string[] traiCay = { "Táo", "Lê", "Chuối", "Cam" };
            Bai5_VietMangVaoFile(thuMuc + @"\bai5.txt", traiCay);

            Bai6_GhiNoiTiepFile(fileGoc, "\nĐoạn này được nối thêm .");
            Bai7_CopyVaHienThi(fileGoc, fileCopy);
            Bai8_DoiTenFile(fileCopy, fileDoiTen);

            // Chuẩn bị file nhiều dòng dùng từ bài 9 đến 13
            string fileNhieuDong = thuMuc + @"\nhieudong.txt";
            string[] cacDong = { "Dòng số một", "Dòng số hai", "Dòng số ba", "Dòng số bốn", "Dòng số năm" };
            File.WriteAllLines(fileNhieuDong, cacDong);

            Bai9_DocDongDauTien(fileNhieuDong);
            Bai10_DocDongCuoiCung(fileNhieuDong);
            Bai11_DocNDongCuoi(fileNhieuDong, 3);
            Bai12_DocDongCuThe(fileNhieuDong, 3);
            Bai13_DemSoDong(fileNhieuDong);
            Bai14_InCauTrucThuMuc(thuMuc);
            Bai15_ThongKeKyTu(fileGoc); // Thống kê cái file có cả chữ lẫn số
        }

        // 1. Tạo một file trống trên đĩa
        static void Bai1_TaoFileTrong(string path)
        {
            FileStream fs = null;
            try
            {
                fs = File.Create(path);
                Console.WriteLine("1. Tạo file trống thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("1. Lỗi tạo file trống: " + ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    Console.WriteLine("  Đã giải phóng file bài 1.");
                }
            }
        }

        // 2. Xóa một file khỏi đĩa
        static void Bai2_XoaFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    Console.WriteLine("2. Đã xóa file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("2. Lỗi xóa file: " + ex.Message);
            }
        }

        // 3. Tạo một file và viết vài dòng chữ vào
        static void Bai3_TaoFileVaVietChu(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content);
                Console.WriteLine("3. Tạo file và ghi chữ thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("3. Lỗi ghi file: " + ex.Message);
            }
        }

        // 4. Tạo một file chữ xong rồi đọc lại file đó
        static void Bai4_TaoVaDocFile(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content);
                string readContent = File.ReadAllText(path);
                Console.WriteLine("4. Nội dung đọc được: " + readContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("4. Lỗi đọc/ghi file: " + ex.Message);
            }
        }

        // 5. Tạo một file và viết một mảng các chuỗi vào file
        static void Bai5_VietMangVaoFile(string path, string[] stringArray)
        {
            try
            {
                File.WriteAllLines(path, stringArray);
                Console.WriteLine("5. Đã ghi mảng chuỗi vào file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("5. Lỗi: " + ex.Message);
            }
        }

        // 6. Viết thêm chữ vào cuối một file đang có sẵn
        static void Bai6_GhiNoiTiepFile(string path, string text)
        {
            try
            {
                File.AppendAllText(path, text);
                Console.WriteLine("6. Đã nối thêm chữ vào cuối file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("6. Lỗi nối tiếp file: " + ex.Message);
            }
        }

        // 7. Tạo và copy file sang tên khác rồi hiện nội dung lên
        static void Bai7_CopyVaHienThi(string source, string dest)
        {
            try
            {
                File.Copy(source, dest, true);
                string txt = File.ReadAllText(dest);
                Console.WriteLine("7. Đã copy. Nội dung file mới:\n" + txt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("7. Lỗi copy file: " + ex.Message);
            }
        }

        // 8. Tạo một file và di chuyển/đổi tên nó trong cùng thư mục
        static void Bai8_DoiTenFile(string source, string dest)
        {
            try
            {
                if (File.Exists(dest)) File.Delete(dest);
                File.Move(source, dest);
                Console.WriteLine("8. Đã đổi tên/di chuyển file xong.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("8. Lỗi đổi tên file: " + ex.Message);
            }
        }

        // 9. Đọc dòng đầu tiên của file
        static void Bai9_DocDongDauTien(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length > 0) Console.WriteLine("9. Dòng đầu tiên là: " + lines[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("9. Lỗi đọc dòng đầu: " + ex.Message);
            }
        }

        // 10. Tạo và đọc dòng cuối cùng của file
        static void Bai10_DocDongCuoiCung(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length > 0) Console.WriteLine("10. Dòng cuối cùng là: " + lines[lines.Length - 1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("10. Lỗi đọc dòng cuối: " + ex.Message);
            }
        }

        // 11. Tạo và đọc n dòng cuối cùng của file
        static void Bai11_DocNDongCuoi(string path, int n)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine($"11. Đọc {n} dòng cuối:");
                int start = lines.Length - n;
                if (start < 0) start = 0;

                for (int i = start; i < lines.Length; i++)
                {
                    Console.WriteLine("   " + lines[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("11. Lỗi: " + ex.Message);
            }
        }

        // 12. Đọc một dòng cụ thể từ file (Ví dụ dòng số 3)
        static void Bai12_DocDongCuThe(string path, int lineNo)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                int idx = lineNo - 1;
                if (idx >= 0 && idx < lines.Length)
                {
                    Console.WriteLine($"12. Dòng số {lineNo} là: " + lines[idx]);
                }
                else
                {
                    Console.WriteLine("12. Không tìm thấy dòng yêu cầu.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("12. Lỗi: " + ex.Message);
            }
        }

        // 13. Đếm số lượng dòng trong file
        static void Bai13_DemSoDong(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine("13. Tổng số dòng trong file là: " + lines.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("13. Lỗi: " + ex.Message);
            }
        }

        // 14. In cấu trúc của một thư mục (Hiện danh sách file)
        static void Bai14_InCauTrucThuMuc(string folderPath)
        {
            try
            {
                Console.WriteLine("14. Cấu trúc thư mục " + folderPath + ":");
                string[] files = Directory.GetFiles(folderPath);
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine("   └── [File] " + Path.GetFileName(files[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("14. Lỗi đọc thư mục: " + ex.Message);
            }
        }

        // 15. Đọc file text và thống kê sự xuất hiện của chữ cái và chữ số
        static void Bai15_ThongKeKyTu(string path)
        {
            try
            {
                string text = File.ReadAllText(path);
                int letters = 0, digits = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsLetter(text[i])) letters++;
                    else if (char.IsDigit(text[i])) digits++;
                }

                Console.WriteLine("15. Thống kê file: Chữ cái = " + letters + ", Chữ số = " + digits);
            }
            catch (Exception ex)
            {
                Console.WriteLine("15. Lỗi thống kê: " + ex.Message);
            }
        }
    }
}
