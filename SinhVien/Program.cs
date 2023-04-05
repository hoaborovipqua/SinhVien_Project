using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            ListSV listSV = new ListSV();
            string filePath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fileinput", "input_listSV.txt");
            listSV.TaoList_SV_FrFile(filePath1);

            Console.WriteLine("List Sinh Vien : ");
            listSV.XuatList_SV();

            ListGV listGV = new ListGV();
            string filePath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fileinput", "input_listGV.txt");
            listGV.TaoList_GV_FrFile(filePath2);

            Console.WriteLine("List Giang Vien : ");
            listGV.XuatList_GV();


            Console.ReadKey();
        }
        
    }
}
