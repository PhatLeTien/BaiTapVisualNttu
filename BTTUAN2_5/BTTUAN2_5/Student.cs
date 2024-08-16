using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Student
    {
        private int _Mahang;
        private string _Tenhang;
        private decimal _Gia;
        private int _Soluong;
        private decimal _Tonggia;
        //Hàm khởi tạo không có tham số
        public Student()
        {
            _Mahang = 0;
            _Tenhang = "";
            _Gia = 0;
            _Soluong = 0;
            _Tonggia = 0;
        }
        //Các phhương thức Properties để get/set giá trị cho các thuộc tính.

        public int Mahang
        {
            get { return _Mahang; }
            set { _Mahang = value; }
        }
        public string Tenhang
        {
            get { return _Tenhang; }
            set { _Tenhang = value; }
        }
        public decimal Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        public int Soluong
        {
            get { return _Soluong; }
            set { _Soluong = value; }
        }
        public decimal Tonggia
        {
            get { return Math.Round(Soluong * Gia); }
            set { _Tonggia = value; }
        }

        //Các phương thức nhập/xuất dữ liệu...GIANG DH\.NET Framework\Code Thuc Hanh\Student\Student.cs 2
        public void nhap()
        {
            Console.Write(" \t -Nhap ma hang:");
            Mahang = int.Parse(Console.ReadLine());
            Console.Write("  \t -Nhap ten hang:");
            Tenhang = Console.ReadLine();
            Console.Write(" \t -Nhap gia:");
            Gia = decimal.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap so luong:");
            Soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
        }
        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}", Mahang, Tenhang, Gia, Soluong, Tonggia);
        }
    }
}