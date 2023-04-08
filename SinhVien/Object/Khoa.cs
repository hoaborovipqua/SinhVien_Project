using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class Khoa
    {
        string maKhoa, tenKhoa;

        public Khoa() { }
        public Khoa(string maKhoa, string tenKhoa)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
        }

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }

        public void nhap_Khoa_Console()
        {
            Console.Write("Nhap vao ma khoa: ");
            this.maKhoa = Console.ReadLine();
            Console.Write("Nhap vao ten khoa: ");
            this.tenKhoa = Console.ReadLine();
        }
        public void xuat_Khoa_Console()
        { 
            Console.Write("{0} / {1} / ", this.maKhoa, this.tenKhoa);
        }
    }
}

