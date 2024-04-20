using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CongVan3
{
    [Serializable]
    class CTruyCapDuLieu
    {
        private static CTruyCapDuLieu m_data = null;
        private List<CongVan> m_dsCongVan;
        private CTruyCapDuLieu()
        {
            m_dsCongVan = new List<CongVan>();
        }
        public static CTruyCapDuLieu khoiTao()
        {
            if (m_data == null) m_data = new CTruyCapDuLieu();
            return m_data;
        }

        public List<CongVan> getDanhSachCongVan()
        {
            return m_dsCongVan;
        }

        public bool docFile(string tenFile)
        {
            try
            {
                m_dsCongVan.Clear(); // Clear data

                using (StreamReader sr = new StreamReader(tenFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] values = line.Split(',');

                            if (values.Length == 6)
                            {
                                CongVan congVan = new CongVan(
                                    values[0], // maCongVan
                                    values[1], // tenCongVan
                                    values[2], // loaiCongVan
                                    DateTime.Parse(values[3]), // ngayBanHanh
                                    values[4], // phongBanHanh
                                    values[5]  // documentContent
                                );

                                m_dsCongVan.Add(congVan);
                            }
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ghiFile(string tenFile)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(tenFile))
                {
                    foreach (CongVan congVan in m_dsCongVan)
                    {
                        string line = $"{congVan.maCongVan},{congVan.tenCongVan},{congVan.loaiCongVan},{congVan.ngayBanHanh},{congVan.phongBanHanh},{congVan.documentContent}";
                        sw.WriteLine(line);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}
