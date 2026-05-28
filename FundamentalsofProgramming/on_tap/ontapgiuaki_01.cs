using System;
using System.Collections.Generic;
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
            const float pi = 3.14f;
            float r;
            Console.WriteLine("moi ban nhap r: ");
            r = float.Parse(Console.ReadLine());
            float chuvi = 2 * r * pi;
            Console.WriteLine($"chu vi cua hinh tron la {chuvi}");
            float dientich = pi * r * r;
            Console.WriteLine($"dien tich cua hinh tron la {dientich}");
            //hoac
            float dientich1 =(float)(Math.PI * Math.Pow(r, 2));
            Console.WriteLine($"dien tich cua hinh tron la {dientich1}");


            



          }
    }
}
