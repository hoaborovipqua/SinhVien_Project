using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class MonHoc
    {
        string maMH, tenMH;
        int soTinChi;
        Diem diem_MH = new Diem();

        public MonHoc() { }

        public MonHoc(string maMH, string tenMH, int soTinChi, Diem diem_MH)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTinChi = soTinChi;
            this.Diem_MH = diem_MH;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        internal Diem Diem_MH { get => diem_MH; set => diem_MH = value; }

        public void xuat_MH_Console()
        {
            Console.Write("{0} ", this.maMH);
            Console.Write("{0} ", this.tenMH);
            Console.Write("{0} ", this.soTinChi);
            this.Diem_MH.xuat_Diem_Console();
        }
    }
}
