using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class GiangVien : Nguoi
    {
        string maGV;
        Khoa khoa_GV = new Khoa();

        public GiangVien() { }

        public GiangVien(string maGV, Khoa khoa_GV, string pSsn, string pHoTen, string pNgaySinh, string pDiaChi):base(pSsn, pHoTen, pNgaySinh,  pDiaChi)
        {
            this.MaGV = maGV;
            this.Khoa_GV = khoa_GV;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        internal Khoa Khoa_GV { get => khoa_GV; set => khoa_GV = value; }
    }
}
