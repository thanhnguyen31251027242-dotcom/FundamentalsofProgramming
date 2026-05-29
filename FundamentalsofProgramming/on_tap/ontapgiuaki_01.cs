using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Channels;

namespace FundamentalsofProgramming.on_tap
{
    internal class ontapgiuaki_01
    {
        static void Main(string[] args)
        {
            //cộng, trừ, nhân, chia
            //int a, b;
            //Console.WriteLine("Moi nhap vao a: ");
            //a= int.Parse(Console.ReadLine());
            //Console.WriteLine("Moi nhap vao b: ");
            //b = int.Parse(Console.ReadLine());
            //float c = a + b;
            //float d = a - b;
            //float e = a * b;
            //float f = (float)a / b;
            //float g = (float)a % b;
            //Console.WriteLine("tong cua hai so {0} va {1} la {2}",a,b,c);
            //Console.WriteLine("hieu cua hai so {0} va {1} la {2}",a,b,d);
            //Console.WriteLine("tich cua hai so {0} va {1} la {2}",a,b,e);
            //Console.WriteLine("thuong cua hai so {0} va {1} la {2}",a,b,f);
            //Console.WriteLine("phep chia lay du cua hai so {0} va {1} la {2}",a,b,g);

            ////chẵn, lẻ
            //int n;
            //Console.WriteLine("Moi ban nhap so: ");
            //n = int.Parse(Console.ReadLine());
            //if ( n%2==0)
            //    Console.WriteLine("so ban vua nhap la so chan");
            //else
            //    Console.WriteLine("so ban vua nhap la so le");

            //tinh cac phep toan
            //int a;
            //Console.Write("Nhap vao so nguyen a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine(a);
            //int a1= a;
            //a += 3;
            //Console.WriteLine(a);
            //a = a1;
            //a -= 5;
            //Console.WriteLine(a);
            //a = a1;
            //a *= 2;
            //Console.WriteLine(a);
            //a = a1;
            //a /= 9; //không thực hiện viết tắt, chương trình vẫn chạy nhưng thiếu thập phân
            //Console.WriteLine(a);
            //a = a1;
            //a %= 5; //không thực hiện viết tắt
            //Console.WriteLine(a);
            //a = a1;
            ////cho b=2, rut gon bieu thuc a=a-(b+7)
            //int b = 2;
            //a -=( b + 7);
            //Console.WriteLine(a);

            //chu vi, dien tich hinh tron
            //const float pi = 3.14f;
            //float r;
            //Console.WriteLine("moi ban nhap r: ");
            //r = float.Parse(Console.ReadLine());
            //float chuvi = 2 * r * pi;
            //Console.WriteLine($"chu vi cua hinh tron la {chuvi}");
            //float dientich = pi * r * r;
            //Console.WriteLine($"dien tich cua hinh tron la {dientich}");
            ////hoac
            //float dientich1 =(float)(Math.PI * Math.Pow(r, 2));
            //Console.WriteLine($"dien tich cua hinh tron la {dientich1}");

            //chu vi, dien tich hinh chu nhat
            //float a, b, dt, cv;
            //Console.WriteLine("moi ban nhap vao chieu dai: ");
            //a = float.Parse(Console.ReadLine());
            //Console.WriteLine("moi ban nhap vao chieu rong: ");
            //b = float.Parse(Console.ReadLine());
            //if (a <= 0 || b <= 0)
            //{
            //    Console.WriteLine("moi ban nhap lai sao cho a,b duong: ");
            //    return;
            //}
            //cv = (a + b) * 2;
            //dt = a * b;
            //Console.WriteLine("chu vi hinh chu nhat la: "+cv);
            //Console.WriteLine("dien tich hinh chu nhat la: "+dt);

            //tim x, y khi biet tong va hieu
            //float tong, hieu, x, y;
            //Console.WriteLine("moi ban nhap vao tong: ");
            //tong = float.Parse(Console.ReadLine());
            //Console.WriteLine("moi ban nhap vao hieu: ");
            //hieu = float.Parse(Console.ReadLine());
            //y=(tong-hieu)/2;
            //Console.WriteLine($"y = {y}");
            //x = tong - y;
            //Console.WriteLine($"x = {x}");

            //tinh BMI
            //float height, weight, bmi;
            //Console.WriteLine("moi ban nhap chieu cao (met): ");
            //height = float.Parse(Console.ReadLine());
            //Console.WriteLine("moi ban nhap vao can nang(kg): ");
            //weight = float.Parse(Console.ReadLine());
            //bmi =(float)( weight / (Math.Pow(height, 2)));
            //if (bmi < 15)
            //    Console.WriteLine("than hinh qua gay");
            //else if (bmi >= 15 && bmi < 16)
            //    Console.WriteLine("than hinh gay");
            //else if (bmi >= 16 && bmi < 18.5)
            //    Console.WriteLine("than hinh hoi gay");
            //else if (bmi >= 18.5 && bmi < 25)
            //    Console.WriteLine("than hinh binh thuong");
            //else if (bmi >= 25 && bmi < 30)
            //    Console.WriteLine("than hinh hoi beo");
            //else if (bmi >= 30 && bmi < 35)
            //    Console.WriteLine("than hinh beo");
            //else
            //    Console.WriteLine("than hinh qua beo");

            //kiem tra nam nhuan
            //int nam;
            //Console.WriteLine("moi ban nhap vao 1 nam: ");
            //nam = int.Parse(Console.ReadLine());
            //if((nam%4==0 && nam%100!=0) || nam%400==0)
            //    Console.WriteLine("nam ban vua nhap la nam nhuan");
            //else
            //    Console.WriteLine("nam ban vua nhap khong phai la nam nhuan");

            //kiem tra thang 1-12 co bao nhieu ngay
            //int thang, nam;
            //Console.WriteLine("moi ban nhap vao 1 thang: ");
            //thang = int.Parse(Console.ReadLine());
            //if (thang >=1 &&thang <= 12)
            //{
            //    if (thang==1||thang==3||thang==5||thang==7||thang==8||thang==10||thang==12)
            //        Console.WriteLine($"thang {thang} co 31 ngay");
            //    else if (thang == 4|| thang == 6|| thang==9|| thang == 11)
            //        Console.WriteLine($"thang {thang} co 30 ngay");
            //    else if (thang == 2)
            //    {
            //        Console.WriteLine("moi ban nhap them nam: ");
            //        nam = int.Parse(Console.ReadLine());
            //        if((nam%4==0&&nam%100!=0)||nam%400==0)
            //        {
            //            Console.WriteLine("thang 2 co 29 ngay");
            //        }
            //        else
            //            Console.WriteLine("thang 2 co 28 ngay");
            //    }
            //}
            //else
            //    Console.WriteLine("xin vui long nhap lai, ban da nhap sai yeu cau!");

            //chan le bang toan tu 3 ngoi
            //int q;
            //Console.WriteLine("moi ban nhap vao 1 so bat ki: ");
            //q = int.Parse(Console.ReadLine());
            //string traloi = (q % 2 == 0) ? "chan" : "le";
            //Console.WriteLine("so ban vua nhap la so: "+traloi);

            //diem tbinh
            //float dtb;
            //Console.WriteLine("moi ban nhap vao diem trung binh: "); //bien=bieu thuc 1? bieu thuc 2: bieu thuc 3
            //dtb = float.Parse(Console.ReadLine());
            //string ketquaxeploai = (dtb >= 8) ? "gioi" : ((dtb < 8 && dtb >= 6.5) ? "kha" : (dtb < 6.5 && dtb >= 5) ? "trung binh" : "yeu");
            //Console.WriteLine("ket qua xep loai cua hoc sinh la: "+ketquaxeploai);

            //kiem tra chan le switch-case
            //float w;
            //Console.WriteLine("nhap vao so bat ki: ");
            //w = float.Parse(Console.ReadLine());
            //float div = w % 2;
            //switch (div)
            //{
            //    case 0:
            //        Console.WriteLine("so ban vua nhap la so chan");
            //        break;
            //    default:
            //        Console.WriteLine("so ban vua nhap la so le");
            //        break;
            //}

            //viet chuong trinh khung tim kiem
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("CHƯƠNG TRÌNH TÌM KIẾM");
            //Console.WriteLine("1. Tìm theo tên");
            //Console.WriteLine("2. Tìm theo tác giả");
            //Console.WriteLine("3. Tìm theo nhà xuất bản");
            //Console.WriteLine("4. Tìm theo tiêu đề");
            //int e;
            //Console.WriteLine("Bấm phím để lựa chọn:");
            //e=int.Parse(Console.ReadLine());
            //switch (e)
            //{
            //    case 1:
            //        Console.WriteLine("Tìm theo tên");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tìm theo tác giả");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tìm theo nhà xuất bản");
            //        break;
            //    case 4:
            //        Console.WriteLine("Tìm theo tiêu đề");
            //        break;
            //    default:
            //        Console.WriteLine("Lựa chọn bạn nhập vào không đúng, vui lòng nhập lại");
            //        break;

            //}

            //m nam trong khoang tu 1 den 99, sai bat nhap lai
            //int m;
            //Console.WriteLine("moi ban nhap so: ");
            //m = int.Parse(Console.ReadLine());
            //while (m<1||m>99)
            //{
            //    Console.WriteLine("so ban vua nhap khong thoa man dieu kien, vui long nhap lai");
            //    m = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"{m} la so thoa man dieu kien, chuc mung ban");

            //nhap vao so nguyen n, tinh n!
            //int n;
            //Console.WriteLine("moi ban nhap vao so nguyen n: ");
            //n = int.Parse(Console.ReadLine());
            //int giaithua = 1;
            //for(int i=1;i<=n;i++)//dung for
            //{
            //    giaithua *= i;
            //}
            //Console.WriteLine($"ket qua {n}! = {giaithua}");

            //dung while
            //int n, i = 1; 
            //Console.WriteLine("moi ban nhap vao so nguyen n: ");
            //n = int.Parse(Console.ReadLine());
            //int giaithua = 1;
            //while(i<=n)
            //{
            //    giaithua *= i; i++;
            //}
            //Console.WriteLine($"ket qua {n}! = {giaithua}");

            //tinh tong so chan
            //int a; int tong = 0;
            //Console.WriteLine("nhap so a tu ban phim: ");
            //a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    for (int i = 0; i <= a; i += 2)
            //        tong += i;
            //    Console.WriteLine($"tong so chan tu 0 den {a} la {tong}");
            //}
            //else
            //    Console.WriteLine("toi khong tinh tong so le, bye bye");


            //tong so le tu 1 den n
            //int n; int tong = 0;
            //Console.WriteLine("nhap so n tu ban phim: ");
            //n = int.Parse(Console.ReadLine());
            //    for (int i = 1; i <= n; i += 2)
            //    {
            //        if (i == 3)
            //            continue;
            //        tong += i;
            //    }
            //    Console.WriteLine($"tong so le tu 1 den {n} la {tong}");


            //tim nhung so chia het cho 3 tu 10->50
            //for (int i = 10; i < 50; i++)
            //{
            //    if (i%3==0)
            //        Console.WriteLine($"{i} la so chia het cho 3 trong khoan 10->50");
            //}

            //tinh tong giai thua
            //int giaithua = 1, tonggiaithua=0;
            //for(int i = 1; i<=10; i++)
            //{
            //    giaithua *= i;
            //    tonggiaithua += giaithua;
            //}
            //Console.WriteLine("tong giai thua tu 1 den 10 la "+ tonggiaithua);

            //kiem tra tu 1-1000 so nao la so hoan hao ( so hoan hao 6=1+2+3)
            for (int n = 1; n <= 1000; n++)
            {
                int sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == n)
                    Console.WriteLine($"{n} la so hoan hao");
            }
        }
    }
}
