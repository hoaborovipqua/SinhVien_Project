using System;
using System.Collections.Generic;
using System.Text;


// phuc vu cho viec tra cuu sinh vien tu phong hoc 
namespace SinhVien
{
    class TraPhongHoc
    {
        // maph_mamh la khoa chinh
        string MaPH_MaMH, tiet_Hoc;

        public TraPhongHoc() { }
        public TraPhongHoc(string maPH_MaMH, string tiet_Hoc)
        {
            MaPH_MaMH1 = maPH_MaMH;
            this.Tiet_Hoc = tiet_Hoc;
        }

        public string MaPH_MaMH1 { get => MaPH_MaMH; set => MaPH_MaMH = value; }
        public string Tiet_Hoc { get => tiet_Hoc; set => tiet_Hoc = value; }

    }
}
