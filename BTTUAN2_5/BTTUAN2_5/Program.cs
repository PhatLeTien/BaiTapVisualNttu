using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong hang:");
            int n = int.Parse(Console.ReadLine());
            Student[] h = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao thong tin cua mat hang :" + (i + 1));
                h[i] = new Student();
                h[i].nhap();
            }
            Console.WriteLine(" Danh sach mat hang: ");
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", "Mahang", "Tenhang", "Gia","Soluong", "Tonggia");
            for (int i = 0; i < n; i++) 
            {
                h[i].xuat();
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}