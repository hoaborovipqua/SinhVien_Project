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
    }
}
