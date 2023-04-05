using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace SinhVien
{
    class ListSV
    {
        public List<SinhVien> list_SV = new List<SinhVien>();

        public void TaoList_SV()
        {
            int n;
            Console.WriteLine("Nhap vao so luong sinh vien can nhap: ");
            n = Console.Read();
            for(int i = 0; i < n; i++)
            {
                SinhVien tmp = new SinhVien();
                tmp.nhapSV_Console();
                this.list_SV.Add(tmp);
            }
        }

        public void TaoList_SV_FrFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string line;
            while((line = reader.ReadLine()) != null)
            {
                string[] studentInfo = line.Split(',');
                Khoa tmp1 = new Khoa(studentInfo[1], studentInfo[2]);
                LopHoc tmp2 = new LopHoc(studentInfo[3], studentInfo[4]);
                SinhVien tmp = new SinhVien(studentInfo[0], tmp1, tmp2, studentInfo[5], studentInfo[6], studentInfo[7], studentInfo[8]);
                this.list_SV.Add(tmp);
            }
        }

        public void XuatList_SV()
        {
            foreach(SinhVien x in this.list_SV)
            {
                x.xuat_SV_Console();
            }
        }
    }
}
