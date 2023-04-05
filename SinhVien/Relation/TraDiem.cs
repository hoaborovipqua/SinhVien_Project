using System;
using System.Collections.Generic;
using System.Text;


// Duoc tao khi sinh vien ca mon hoc duoc tao 
namespace SinhVien.Relation
{
    class TraDiem
    {
        string MaSV_MaMH;
        Diem diem_SV = new Diem();

        public TraDiem() { }
        public TraDiem(string maSV_MaMH, Diem diem_SV)
        {
            MaSV_MaMH1 = maSV_MaMH;
            this.Diem_SV = diem_SV;
        }

        public string MaSV_MaMH1 { get => MaSV_MaMH; set => MaSV_MaMH = value; }
        internal Diem Diem_SV { get => diem_SV; set => diem_SV = value; }


    }
}
