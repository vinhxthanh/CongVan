using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongVan3
{
    internal class CongVanView
    {
        public string maCongVan { get; set; }
        public string tenCongVan { get; set; }
        public string loaiCongVan { get; set; }
        public DateTime ngayBanHanh { get; set; }
        public string phongBanHanh { get; set; }
        public string documentContent { get; set; }

        public static List<CongVanView> Chuyendoi(List<CongVan> list)
        {
            List<CongVanView> cv = new List<CongVanView>();
            foreach (CongVan v in list)
            {
                CongVanView cvv = new CongVanView();
                v.maCongVan = cvv.maCongVan;
                v.tenCongVan = cvv.tenCongVan;
                v.loaiCongVan = cvv.loaiCongVan;
                v.ngayBanHanh = cvv.ngayBanHanh;
                v.phongBanHanh = cvv.phongBanHanh;
                v.documentContent = cvv.documentContent;
                cv.Add(cvv);
            }
            return cv;
        }
    }

}
