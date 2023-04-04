using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class SinhVien:Nguoi
    {
        string maSV;
        List<MonHoc> list_MH_SV = new List<MonHoc>();
        Khoa khoa_sv = new Khoa();
        LopHoc LH_sv = new LopHoc();

        public SinhVien() { }

        public SinhVien(string maSV, List<MonHoc> list_MH_SV, Khoa khoa_sv, LopHoc lH_sv, string pSsn, string pHoTen, string pNgaySinh, string pDiaChi):base(pSsn, pHoTen, pNgaySinh, pDiaChi)
        {
            this.maSV = maSV;
            this.list_MH_SV = list_MH_SV;
            this.khoa_sv = khoa_sv;
            LH_sv = lH_sv;
        }
        public string MaSV { get => maSV; set => maSV = value; }
    }
}
