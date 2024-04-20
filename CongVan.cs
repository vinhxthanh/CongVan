using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongVan3
{
    [Serializable]
    internal class CongVan
    {
        private string m_maCongVan;
        private string m_tenCongVan;
        private string m_loaiCongVan;
        private DateTime m_ngayBanHanh;
        private string m_phongBanHanh;
        private string m_documentContent;

        public string maCongVan
        {
            get { return m_maCongVan; }
            set { m_maCongVan = value; }
        }
        public string tenCongVan
        {
            get { return m_tenCongVan; }
            set { m_tenCongVan = value; }
        }
        public string loaiCongVan
        {
            get { return m_loaiCongVan; }
            set { m_loaiCongVan = value; }
        }
        public DateTime ngayBanHanh
        {
            get { return m_ngayBanHanh; }
            set { m_ngayBanHanh = value; }
        }
        public string phongBanHanh
        {
            get { return m_phongBanHanh; }
            set { m_phongBanHanh = value; }
        }
        public string documentContent
        {
            get { return m_documentContent; }
            set { m_documentContent = value; }
        }
        public CongVan()
        {
            m_maCongVan = "";
            m_tenCongVan = "";
            m_loaiCongVan = "";
            m_ngayBanHanh = DateTime.Now;
            m_phongBanHanh = "";
            m_documentContent = "";
        }
        public CongVan(string maCongVan, string tenCongVan, string loaiCongVan,
            DateTime ngayBanHanh, string phongBanHanh, string documentContent)
        {
            m_maCongVan = maCongVan;
            m_tenCongVan = tenCongVan;
            m_loaiCongVan = loaiCongVan;
            m_ngayBanHanh = ngayBanHanh;
            m_phongBanHanh = phongBanHanh;
            m_documentContent = documentContent;
        }
    }
}
