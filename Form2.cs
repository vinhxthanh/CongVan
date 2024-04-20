using PdfSharp.Pdf.Advanced;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongVan3
{
    public partial class Form2 : Form
    {
        CXuLyCongVan xuLy;
        List<CongVan> dataSource = new List<CongVan>();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public Form2()
        {
            InitializeComponent();
            xuLy= new CXuLyCongVan();
            dgvCongVan.DataSource = dataSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CongVan cv = new CongVan();

            if (xuLy.KiemTraTrungLap(cv) == false)
            {
                cv.maCongVan = txtId.Text;
                cv.tenCongVan = txtName.Text;
                cv.loaiCongVan = cbbLoai.Text;
                cv.phongBanHanh = cbbPB.Text;
                cv.ngayBanHanh = dateTimePicker1.Value;
                cv.documentContent = txtNoiDung.Text;
                if (xuLy.them(cv) == false)
                {
                    MessageBox.Show("Thông tin công văn này đã được lưu trước đó !");

                }
                else
                {
                    hienthi(xuLy.getDanhSachCongVan());
                }
                //// Add data to the binding list
                //xuLy.them(cv);
                //// Refresh the DataGridView
                //dgvCongVan.DataSource = null; // Clear the current binding
                //dgvCongVan.DataSource = xuLy.getDanhSachCongVan();

                //// Set the binding list as the data source for the DataGridView
                //dgvCongVan.Columns["Mã Công Văn"].DataPropertyName = "maCongVan";
                //dgvCongVan.Columns["tenCongVan"].DataPropertyName = "tenCongVan";
                //dgvCongVan.Columns["loaiCongVan"].DataPropertyName = "loaiCongVan";
                //dgvCongVan.Columns["phongBanHanh"].DataPropertyName = "phongBanHanh";
                //dgvCongVan.Columns["ngayBanHanh"].DataPropertyName = "ngayBanHanh";
                //dgvCongVan.Columns["documentContent"].DataPropertyName = "documentContent";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Check if any row is selected in the DataGridView
                if (dgvCongVan.SelectedRows.Count > 0)
                {
                    // Get the selected row index
                    int selectedIndex = dgvCongVan.SelectedRows[0].Index;

                    // Get the value in the "maCongVan" column of the selected row
                    string macv = dgvCongVan.Rows[selectedIndex].Cells["maCongVan"].Value.ToString();

                    // Call the delete method in your data processing class (xuLy)
                    xuLy.xoa(macv);

                    // Refresh the DataGridView
                    dgvCongVan.DataSource = null;
                    dgvCongVan.DataSource = xuLy.getDanhSachCongVan();
                }
                else
                {
                    // Display a message or take appropriate action if no row is selected
                    MessageBox.Show("Please select a row to delete.");
                }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvCongVan.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvCongVan.SelectedRows[0].Index;
                string maCongVanToUpdate = dgvCongVan.Rows[selectedIndex].Cells["maCongVan"].Value.ToString();
                CongVan selectedCongVan = xuLy.tim(maCongVanToUpdate);

                // Update properties of the selected CongVan
                selectedCongVan.maCongVan = txtId.Text;
                selectedCongVan.tenCongVan = txtName.Text;
                selectedCongVan.loaiCongVan = cbbLoai.Text;
                selectedCongVan.phongBanHanh = cbbPB.Text;
                selectedCongVan.ngayBanHanh = dateTimePicker1.Value;
                selectedCongVan.documentContent = txtNoiDung.Text;

                // Save the changes
                xuLy.sua(selectedCongVan);

                // Refresh the DataGridView
                dgvCongVan.DataSource = null;
                dgvCongVan.DataSource = xuLy.getDanhSachCongVan();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void dgvCongVan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row index is selected
            if (e.RowIndex >= 0 && e.RowIndex < dgvCongVan.Rows.Count)
            {
                string macv = dgvCongVan.Rows[e.RowIndex].Cells["maCongVan"].Value.ToString();

                CongVan selectedCongVan = xuLy.tim(macv);

                // You can now use the selectedCongVan to populate your UI controls for editing
                txtId.Text = selectedCongVan.maCongVan;
                txtName.Text = selectedCongVan.tenCongVan;
                cbbLoai.Text = selectedCongVan.loaiCongVan;
                cbbPB.Text = selectedCongVan.phongBanHanh;
                dateTimePicker1.Value = selectedCongVan.ngayBanHanh;
                txtNoiDung.Text = selectedCongVan.documentContent;
                }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoiTao();
            if (data.ghiFile("danhsach.txt") == true)
                MessageBox.Show("Lưu danh sách thành công!");
            else
                MessageBox.Show("Không lưu được danh sách!");
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoiTao();

            // Attempt to read data from the file
            if (data.docFile("danhsach.txt"))
            {
                // If reading is successful, update the DataGridView
                dgvCongVan.DataSource = null;
                dgvCongVan.DataSource = data.getDanhSachCongVan();

                MessageBox.Show("Đọc danh sách thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy hoặc đọc lỗi dữ liệu!");
            }
        }

        private void btnThemFile_Click(object sender, EventArgs e)
        {
            //openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "|*.pdf";
            //openFileDialog.Multiselect= false;
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    StreamReader read = new StreamReader(openFileDialog.FileName);
            //    txtNoiDung.Text = read.ReadToEnd();
            //    read.Close();
            //}
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the file path in the TextBox
                txtNoiDung.Text = openFileDialog.FileName;
            }
        }

        private void dgvCongVan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("hello");
            if (e.ColumnIndex == dgvCongVan.Columns["documentContent"].Index && e.RowIndex >= 0)
            {
                // Get the file path from the clicked cell
                string filePath = dgvCongVan.Rows[e.RowIndex].Cells["documentContent"].Value.ToString();

                // Open the file using the default application associated with the file type
                if (!string.IsNullOrEmpty(filePath) && System.IO.File.Exists(filePath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    catch (System.ComponentModel.Win32Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("File not found or path is empty.");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CTruyCapDuLieu data = CTruyCapDuLieu.khoiTao();
            if (data.docFile("danhsach.dat") == true)
            {
                // Load data into your application
                dgvCongVan.DataSource = data.getDanhSachCongVan;
            }
            else
            {
                MessageBox.Show("Không tìm thấy danh sách!");
            }
        }
        private void hienthi(List<CongVan> dsLH)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsLH;
            dgvCongVan.DataSource = bs;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string malh = txtSearch.Text;
            CongVan a = xuLy.tim(malh);
            if (a != null)
            {
                txtId.Text = a.maCongVan;
                txtName.Text = a.tenCongVan;
                cbbLoai.Text = a.loaiCongVan;
                cbbPB.Text = a.phongBanHanh;
                txtNoiDung.Text = a.documentContent;
                dateTimePicker1.Value = a.ngayBanHanh;
            }
            hienthi(xuLy.getDanhSachCongVan());
            if (txtSearch.Text != "")
            {
                List<CongVan> dsmoi = new List<CongVan>();
                foreach (CongVan b in xuLy.getDanhSachCongVan())
                {
                    if (b.maCongVan == txtSearch.Text)
                    {
                        dsmoi.Add(b);
                        hienthi(dsmoi);
                    }
                    else
                    {
                        hienthi(dsmoi);
                    }
                }
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                txtNoiDung.Text = "";
                cbbLoai.Text = "";
                cbbPB.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                hienthi(xuLy.getDanhSachCongVan());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hienthi(xuLy.getDanhSachCongVan());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ten = txtSearch.Text;
            CongVan a = xuLy.tim(ten);
            if (a != null)
            {
                txtId.Text = a.maCongVan;
                txtName.Text = a.tenCongVan;
                cbbLoai.Text = a.loaiCongVan;
                cbbPB.Text = a.phongBanHanh;
                txtNoiDung.Text = a.documentContent;
                dateTimePicker1.Value = a.ngayBanHanh;
            }
            hienthi(xuLy.getDanhSachCongVan());
            if (txtSearch.Text != "")
            {
                List<CongVan> dsmoi = new List<CongVan>();
                foreach (CongVan b in xuLy.getDanhSachCongVan())
                {
                    if (b.phongBanHanh == txtSearch.Text)
                    {
                        dsmoi.Add(b);
                        hienthi(dsmoi);
                    }
                    else
                    {
                        hienthi(dsmoi);
                    }
                }
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                txtNoiDung.Text = "";
                cbbLoai.Text = "";
                cbbPB.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                hienthi(xuLy.getDanhSachCongVan());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ngayThangNamText = txtSearch.Text;

            // Kiểm tra xem ngày tháng năm có đúng định dạng không
            if (DateTime.TryParseExact(ngayThangNamText, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayThangNam))
            {
                // Tạo danh sách để lưu trữ kết quả
                List<CongVan> ketQua = new List<CongVan>();

                // Lọc danh sách theo ngày tháng năm
                foreach (CongVan cv in xuLy.getDanhSachCongVan())
                {
                    if (cv.ngayBanHanh.Date == ngayThangNam.Date)
                    {
                        ketQua.Add(cv);
                    }
                }
                hienthi(ketQua);
            }
            else
            {
              
                MessageBox.Show("('Ngày tháng năm không hợp lệ');");
            }

        }
        }
    }
