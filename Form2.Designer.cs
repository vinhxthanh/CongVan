namespace CongVan3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbPB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCongVan = new System.Windows.Forms.DataGridView();
            this.maCongVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCongVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiCongVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBanHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentContent = new System.Windows.Forms.DataGridViewLinkColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.btnThemFile = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongVan)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 51);
            this.button2.TabIndex = 34;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 27);
            this.txtName.TabIndex = 33;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(156, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 27);
            this.txtId.TabIndex = 32;
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Hành Chính",
            "Tài Vụ",
            "Quyết Định",
            "Thông Báo",
            "Quy Chế",
            "Thông Tư",
            "Nghị Quyết",
            "Chỉ Thị",
            "Kế Hoạch",
            "Biên Bản"});
            this.cbbLoai.Location = new System.Drawing.Point(156, 100);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(185, 28);
            this.cbbLoai.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 27);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.UseWaitCursor = true;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 27, 0, 0, 0, 0);
            // 
            // cbbPB
            // 
            this.cbbPB.DisplayMember = "12";
            this.cbbPB.FormattingEnabled = true;
            this.cbbPB.Items.AddRange(new object[] {
            "Giáo Vụ",
            "Bộ Công An",
            "Văn Phòng Chính Phủ",
            "Tổng Cục",
            "Viện Kiểm Soát",
            "Ủy Ban",
            "Bộ",
            "Tòa",
            "Thanh Tra",
            "Tòa Án",
            "Cục"});
            this.cbbPB.Location = new System.Drawing.Point(156, 133);
            this.cbbPB.Name = "cbbPB";
            this.cbbPB.Size = new System.Drawing.Size(185, 28);
            this.cbbPB.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày Ban Hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Phòng Ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Loại Công Văn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Công Văn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên Công Văn";
            // 
            // dgvCongVan
            // 
            this.dgvCongVan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongVan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCongVan,
            this.tenCongVan,
            this.loaiCongVan,
            this.phongBanHanh,
            this.ngayBanHanh,
            this.documentContent});
            this.dgvCongVan.Location = new System.Drawing.Point(27, 259);
            this.dgvCongVan.Name = "dgvCongVan";
            this.dgvCongVan.RowHeadersWidth = 51;
            this.dgvCongVan.RowTemplate.Height = 29;
            this.dgvCongVan.Size = new System.Drawing.Size(799, 188);
            this.dgvCongVan.TabIndex = 35;
            this.dgvCongVan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongVan_RowEnter);
            this.dgvCongVan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongVan_CellContentDoubleClick);
            this.dgvCongVan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongVan_RowEnter);
            // 
            // maCongVan
            // 
            this.maCongVan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maCongVan.DataPropertyName = "maCongVan";
            this.maCongVan.HeaderText = "maCongVan";
            this.maCongVan.MinimumWidth = 6;
            this.maCongVan.Name = "maCongVan";
            this.maCongVan.Width = 118;
            // 
            // tenCongVan
            // 
            this.tenCongVan.DataPropertyName = "tenCongVan";
            this.tenCongVan.HeaderText = "tenCongVan";
            this.tenCongVan.MinimumWidth = 6;
            this.tenCongVan.Name = "tenCongVan";
            this.tenCongVan.Width = 125;
            // 
            // loaiCongVan
            // 
            this.loaiCongVan.DataPropertyName = "loaiCongVan";
            this.loaiCongVan.HeaderText = "loaiCongVan";
            this.loaiCongVan.MinimumWidth = 6;
            this.loaiCongVan.Name = "loaiCongVan";
            this.loaiCongVan.Width = 125;
            // 
            // phongBanHanh
            // 
            this.phongBanHanh.DataPropertyName = "phongBanHanh";
            this.phongBanHanh.HeaderText = "phongBanHanh";
            this.phongBanHanh.MinimumWidth = 6;
            this.phongBanHanh.Name = "phongBanHanh";
            this.phongBanHanh.Width = 125;
            // 
            // ngayBanHanh
            // 
            this.ngayBanHanh.DataPropertyName = "ngayBanHanh";
            this.ngayBanHanh.HeaderText = "ngayBanHanh";
            this.ngayBanHanh.MinimumWidth = 6;
            this.ngayBanHanh.Name = "ngayBanHanh";
            this.ngayBanHanh.Width = 125;
            // 
            // documentContent
            // 
            this.documentContent.DataPropertyName = "documentContent";
            this.documentContent.HeaderText = "documentContent";
            this.documentContent.MinimumWidth = 6;
            this.documentContent.Name = "documentContent";
            this.documentContent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.documentContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.documentContent.Width = 125;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(507, 37);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(94, 49);
            this.buttonXoa.TabIndex = 36;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(607, 37);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 49);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(707, 37);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(94, 49);
            this.btnDocFile.TabIndex = 39;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Location = new System.Drawing.Point(693, 100);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(101, 36);
            this.btnGhiFile.TabIndex = 40;
            this.btnGhiFile.Text = "Ghi File";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // btnThemFile
            // 
            this.btnThemFile.Location = new System.Drawing.Point(595, 97);
            this.btnThemFile.Name = "btnThemFile";
            this.btnThemFile.Size = new System.Drawing.Size(92, 39);
            this.btnThemFile.TabIndex = 41;
            this.btnThemFile.Text = "Thêm File";
            this.btnThemFile.UseVisualStyleBackColor = true;
            this.btnThemFile.Click += new System.EventHandler(this.btnThemFile_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(378, 102);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(211, 27);
            this.txtNoiDung.TabIndex = 42;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(507, 142);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 27);
            this.txtSearch.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 57);
            this.button1.TabIndex = 44;
            this.button1.Text = "Tìm theo mã";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(756, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 35);
            this.button3.TabIndex = 45;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(549, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 57);
            this.button4.TabIndex = 46;
            this.button4.Text = "Tìm theo phòng ban";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nhập thông tin để tìm";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(649, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 57);
            this.button5.TabIndex = 48;
            this.button5.Text = "Tìm theo Ngày";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(708, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "(dd/MM/yyyy)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.btnThemFile);
            this.Controls.Add(this.btnGhiFile);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.dgvCongVan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbbPB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Quản lý công văn";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongVan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private TextBox txtName;
        private TextBox txtId;
        private ComboBox cbbLoai;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbbPB;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvCongVan;
        private OpenFileDialog openFileDialog1;
        private Button buttonXoa;
        private Button btnSua;
        private Button btnDocFile;
        private Button btnGhiFile;
        private Button btnThemFile;
        private TextBox txtNoiDung;
        private DataGridViewTextBoxColumn maCongVan;
        private DataGridViewTextBoxColumn tenCongVan;
        private DataGridViewTextBoxColumn loaiCongVan;
        private DataGridViewTextBoxColumn phongBanHanh;
        private DataGridViewTextBoxColumn ngayBanHanh;
        private DataGridViewLinkColumn documentContent;
        private TextBox txtSearch;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label6;
        private Button button5;
        private Label label7;
    }
}