﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SinhVien
{
    class ListMonHoc
    {
        public List<MonHoc> list_MH = new List<MonHoc>();

        public void nhap_list_MonHoc_FrFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] t_monhoc = line.Split(',');
                MonHoc mh = new MonHoc(t_monhoc[0], t_monhoc[1], int.Parse(t_monhoc[2]));
                list_MH.Add(mh);
            }
        }
        
        
    }
}
