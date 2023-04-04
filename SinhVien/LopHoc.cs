using System;
using System.Collections.Generic;
using System.Text;

namespace SinhVien
{
    class LopHoc
    {
        string maLH, tenLH, gvCoVan;

        public LopHoc() { }
        public LopHoc(string maLH, string tenLH, string gvCoVan)
        {
            this.maLH = maLH;
            this.tenLH = tenLH;
            this.gvCoVan = gvCoVan;
        }

        public string MaLH { get => maLH; set => maLH = value; }
        public string TenLH { get => tenLH; set => tenLH = value; }
        public string GvCoVan { get => gvCoVan; set => gvCoVan = value; }
    }
}
