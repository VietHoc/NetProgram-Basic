//3. Viết chương trình nhận vào một số nguyên và trả về cách phân tích số đó ra tích của thừa số nguyên tố.
//   Ví dụ nhập vào 600 thì cần phải trả về `2 * 2 * 2 * 3 * 5 * 5`

using System;

namespace Bai3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Nhap so nguyen: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} = {1}", a, phanTichThuaSoNguyenTo(a));
        }

        private static string phanTichThuaSoNguyenTo(int a)
        {
            int i = 2;
            string phanTich = string.Empty;

            while (a != 1)
            {
                if (Properties.PrimeTool.IsPrime(i) & a % i == 0)
                {
                    phanTich += i.ToString() + " * ";
                    a /= i;
                }
                else
                {
                    i++;
                }
            }
            return phanTich.Substring(0, phanTich.Length - 3);
        }
    }
}
