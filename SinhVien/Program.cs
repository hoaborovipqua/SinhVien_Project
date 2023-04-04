using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            ListSV listSV = new ListSV();
            listSV.TaoList_SV_FrFile();

            Console.WriteLine("List Sinh Vien : ");
            listSV.XuatList_SV();

            Console.ReadKey();
        }
        
    }
}
