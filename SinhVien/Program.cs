using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


/// <summary>
/// Lưu ý mấy cái đường dẫn cố định trong mỗi máy sẽ khác nhau 
/// ví dụ nhập từ file list_SV thì mấy ông cứ chuột phải vào file input rồi copy full path 
/// rồi dán vào cái path cũ có sẵn t tạo từ máy t 
/// </summary>

namespace SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            ListSV listSV = new ListSV();
            listSV.TaoList_SV_FrFile(@"C:\Documents\OOP_Uni\CodeOOPCsharp\SinhVien\SinhVien\fileinput\input_listSV.txt");


            Console.WriteLine("List Sinh Vien : ");
            listSV.XuatList_SV();

            ListGV listGV = new ListGV();
            listGV.TaoList_GV_FrFile(@"C:\Documents\OOP_Uni\CodeOOPCsharp\SinhVien\SinhVien\fileinput\input_listGV.txt");

            Console.WriteLine("List Giang Vien : ");
            listGV.XuatList_GV();

            Console.ReadKey();
        }
    }
}
