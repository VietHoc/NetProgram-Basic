//4. Số fibonaci là dãy số bắt đầu từ 1 1 và sau đó, số tiếp theo bằng 2 số trước cộng lại.Tức là `1 1 2 3 5 8 ....`.
//   Nhập vào số nguyên n, xuất ra danh sách những số fibonaci không lớn hơn n.
using System;

namespace Bai4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so nguyen: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Day so Fibonaci nho hon {0} la: 1 ", n);
            int a = 1, b = 1;

            while (b < n)
            {
                b = a + b;
                a = b - a;
                Console.Write("{0} ", a);
            }
        }
    }
}
