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
        public static string tenTruong = "HUFI";

        public SinhVien() { }

        public SinhVien(string maSV, List<MonHoc> list_MH_SV, Khoa khoa_sv, LopHoc lH_sv, string pSsn, string pHoTen, string pNgaySinh, string pDiaChi):base(pSsn, pHoTen, pNgaySinh, pDiaChi)
        {
            this.maSV = maSV;
            this.list_MH_SV = list_MH_SV;
            this.khoa_sv = khoa_sv;
            LH_sv = lH_sv;
        }
        public string MaSV { get => maSV; set => maSV = value; }

        public void nhapSV_Console()
        {
            Console.Write("Nhap vao ma so sinh vien: ");
            this.maSV = Console.ReadLine();
            this.khoa_sv.nhap_Khoa_Console();
            this.LH_sv.nhap_LH_Console();
            Console.Write("Nhap vao ma so dinh danh: ");
            this.Ssn = Console.ReadLine();
            Console.Write("Nhap vao ho ten: ");
            this.HoTen = Console.ReadLine();
            Console.Write("Nhap vao ngay sinh(dd/mm/yyyy): ");
            this.NgaySinh = Console.ReadLine();
            Console.Write("Nhap vao dia chi: ");
            this.DiaChi = Console.ReadLine();
        }

        public void Nhap_list_MH()
        {

        }
    }
}
