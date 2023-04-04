using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class MonHoc
    {
        string maMH, tenMH;
        int soTinChi;
        double diem;

        public MonHoc() { }
        public MonHoc(string maMH, string tenMH, int soTinChi, double diem)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTinChi = soTinChi;
            this.diem = diem;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public double Diem { get => diem; set => diem = value; }
    }
}
