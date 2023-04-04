using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class dayHoc
    {
        string maSV_maGV_maMH, tietHoc;
        PhongHoc phong_hoc = new PhongHoc();

        public dayHoc() { }
        public dayHoc(string maSV_maGV_maMH, string tietHoc, PhongHoc phong_hoc)
        {
            this.maSV_maGV_maMH = maSV_maGV_maMH;
            this.tietHoc = tietHoc;
            this.phong_hoc = phong_hoc;
        }

        public string MaSV_maGV_maMH { get => maSV_maGV_maMH; set => maSV_maGV_maMH = value; }
        public string TietHoc { get => tietHoc; set => tietHoc = value; }


    }
}
