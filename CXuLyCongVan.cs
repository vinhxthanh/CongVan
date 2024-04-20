using CongVan3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongVan3
{
    class CXuLyCongVan
    {
        private List<CongVan> dsCV;
        public CXuLyCongVan()
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoiTao();
            dsCV = data.getDanhSachCongVan();
        }
        public List<CongVan> getDanhSachCongVan()
        {
            return dsCV;
        }
        public CongVan tim(string maCv)
        {
            foreach (CongVan cv in dsCV)
            {
                if (cv.maCongVan == maCv) return cv;
            }
            return null;
        }
        public bool them(CongVan cv)
        {
            CongVan c = tim(cv.maCongVan);
            if (c != null) return false;
            dsCV.Add(cv);
            return true;
        }
        public bool xoa(string maCv)
        {
            CongVan c = tim(maCv);
            if (c == null) return false;
            dsCV.Remove(c);
            return true;
        }
        public bool sua(CongVan cv)
        {
            CongVan c = tim(cv.maCongVan);
            if (c == null)
            {
                return false;
            }

            // Update the existing CongVan
            c.maCongVan = cv.maCongVan;
            c.tenCongVan = cv.tenCongVan;
            c.loaiCongVan = cv.loaiCongVan;
            c.ngayBanHanh = cv.ngayBanHanh;
            c.documentContent = cv.documentContent;

            return true;
        }

        public bool KiemTraTrungLap(CongVan newCongVan)
        {
            foreach (CongVan existingCongVan in dsCV)
            {
                if (existingCongVan.maCongVan == newCongVan.maCongVan)
                {
                    return true; // Trùng lặp
                }
            }
            return false; // Không trùng lặp
        }

    }
}
