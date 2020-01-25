//1. Viết chương trình tìm ước số chung lớn nhất, bội số chung nhỏ nhất của hai số tự nhiên


using System;

namespace Bai1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap so nguyen thu nhat: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu hai: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("UCLN ({0}, {1}): {2}", a, b, ucln(a, b));
            Console.WriteLine("BCNN ({0}, {1}): {2}", a, b, bcnn(a, b));
        }

        public static int ucln(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else
            {
                if (a > b)
                {
                    return ucln(a / b, b);
                }
                else
                {
                    return ucln(a, b / a);
                }

            }

        }

        public static int bcnn(int a, int b)
        {
            return a * b / ucln(a, b);
        }
    }
}
