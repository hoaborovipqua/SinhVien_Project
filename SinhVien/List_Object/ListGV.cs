using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SinhVien
{
    class ListGV
    {
        public List<GiangVien> list_GV = new List<GiangVien>();

        public void TaoList_GV_FrFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null) 
            {
                string[] lecInfo = line.Split(',');
                Khoa tmp1 = new Khoa(lecInfo[1], lecInfo[2]);
                GiangVien tmp = new GiangVien(lecInfo[0], tmp1, lecInfo[3], lecInfo[4], lecInfo[5], lecInfo[6]);
                this.list_GV.Add(tmp);
            }
        }

        public void XuatList_GV()
        {
            foreach (GiangVien x in this.list_GV)
            {
                x.xuat_GV_Console();
            }
        }

    }
}
