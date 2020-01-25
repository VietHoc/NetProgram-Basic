//2. Viết chương trình tìm tổng các chữ số của một số nguyên

using System;

namespace Bai2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a;
            Console.Write("Nhap so tu nhien: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Tong cac chu so cua {0} la: {1}", a, tongChuSo(a));
        }

        private static int tongChuSo(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                sum += (a % 10);
                a /= 10;
            }
            return sum;
        }
    }
}
