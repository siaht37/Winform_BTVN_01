using System;

namespace Buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap so luong san pham: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Nhap don gia cua san pham: ");
                float price = float.Parse(Console.ReadLine());

                float total = quantity * price;

                Console.WriteLine($"Tong gia tri don hang la: {total:C}");
                Console.ReadKey();
            }
             catch (FormatException ex)
            {
                Console.WriteLine("Vui long nhap so hop le");
                Console.ReadKey();
            }
        }
    }
}
