namespace MyApplication
{
    partial class FQuanlyTS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            lblMaTaiSan = new Label();
            txtMaTaiSan = new TextBox();
            txtTenTaiSan = new TextBox();
            lblTenTaiSan = new Label();
            dtNgayMua = new DateTimePicker();
            lblNgayMua = new Label();
            lblGiaMua = new Label();
            txtGiaMua = new TextBox();
            cmbLoaiTaiSan = new ComboBox();
            lblLoaiTaiSan = new Label();
            chkStatus = new CheckBox();
            gbThongTin = new GroupBox();
            btnFilterByUsedState = new Button();
            cmbUsedState = new ComboBox();
            lblFilter = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            rdDaThanhLy = new RadioButton();
            rdDangSuDung = new RadioButton();
            rdChuaSuDung = new RadioButton();
            gbXuLy = new GroupBox();
            btnXoaDuLieu = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            btnHienThi = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            gbThongTin.SuspendLayout();
            gbXuLy.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 394);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(1163, 290);
            dataGridView.TabIndex = 13;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // lblMaTaiSan
            // 
            lblMaTaiSan.AutoSize = true;
            lblMaTaiSan.Location = new Point(62, 69);
            lblMaTaiSan.Name = "lblMaTaiSan";
            lblMaTaiSan.Size = new Size(93, 25);
            lblMaTaiSan.TabIndex = 1;
            lblMaTaiSan.Text = "Mã tài sản";
            // 
            // txtMaTaiSan
            // 
            txtMaTaiSan.Enabled = false;
            txtMaTaiSan.Location = new Point(168, 66);
            txtMaTaiSan.Name = "txtMaTaiSan";
            txtMaTaiSan.Size = new Size(279, 31);
            txtMaTaiSan.TabIndex = 2;
            // 
            // txtTenTaiSan
            // 
            txtTenTaiSan.Location = new Point(168, 102);
            txtTenTaiSan.Name = "txtTenTaiSan";
            txtTenTaiSan.Size = new Size(665, 31);
            txtTenTaiSan.TabIndex = 4;
            // 
            // lblTenTaiSan
            // 
            lblTenTaiSan.AutoSize = true;
            lblTenTaiSan.Location = new Point(62, 105);
            lblTenTaiSan.Name = "lblTenTaiSan";
            lblTenTaiSan.Size = new Size(94, 25);
            lblTenTaiSan.TabIndex = 3;
            lblTenTaiSan.Text = "Tên tài sản";
            // 
            // dtNgayMua
            // 
            dtNgayMua.Format = DateTimePickerFormat.Short;
            dtNgayMua.Location = new Point(168, 185);
            dtNgayMua.Name = "dtNgayMua";
            dtNgayMua.Size = new Size(277, 31);
            dtNgayMua.TabIndex = 8;
            // 
            // lblNgayMua
            // 
            lblNgayMua.AutoSize = true;
            lblNgayMua.Location = new Point(62, 188);
            lblNgayMua.Name = "lblNgayMua";
            lblNgayMua.Size = new Size(94, 25);
            lblNgayMua.TabIndex = 7;
            lblNgayMua.Text = "Ngày mua";
            // 
            // lblGiaMua
            // 
            lblGiaMua.AutoSize = true;
            lblGiaMua.Location = new Point(458, 188);
            lblGiaMua.Name = "lblGiaMua";
            lblGiaMua.Size = new Size(77, 25);
            lblGiaMua.TabIndex = 9;
            lblGiaMua.Text = "Giá mua";
            // 
            // txtGiaMua
            // 
            txtGiaMua.Location = new Point(551, 185);
            txtGiaMua.Name = "txtGiaMua";
            txtGiaMua.Size = new Size(282, 31);
            txtGiaMua.TabIndex = 10;
            // 
            // cmbLoaiTaiSan
            // 
            cmbLoaiTaiSan.FormattingEnabled = true;
            cmbLoaiTaiSan.Location = new Point(168, 136);
            cmbLoaiTaiSan.Name = "cmbLoaiTaiSan";
            cmbLoaiTaiSan.Size = new Size(665, 33);
            cmbLoaiTaiSan.TabIndex = 6;
            cmbLoaiTaiSan.Click += cmbLoaiTaiSan_Click;
            // 
            // lblLoaiTaiSan
            // 
            lblLoaiTaiSan.AutoSize = true;
            lblLoaiTaiSan.Location = new Point(62, 140);
            lblLoaiTaiSan.Name = "lblLoaiTaiSan";
            lblLoaiTaiSan.Size = new Size(100, 25);
            lblLoaiTaiSan.TabIndex = 5;
            lblLoaiTaiSan.Text = "Loại tài sản";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(168, 225);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(126, 29);
            chkStatus.TabIndex = 11;
            chkStatus.Text = "Tài sản mới";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(btnFilterByUsedState);
            gbThongTin.Controls.Add(cmbUsedState);
            gbThongTin.Controls.Add(lblFilter);
            gbThongTin.Controls.Add(btnTimKiem);
            gbThongTin.Controls.Add(txtTimKiem);
            gbThongTin.Controls.Add(rdDaThanhLy);
            gbThongTin.Controls.Add(rdDangSuDung);
            gbThongTin.Controls.Add(rdChuaSuDung);
            gbThongTin.Location = new Point(12, 14);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Size = new Size(859, 374);
            gbThongTin.TabIndex = 0;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông tin tài sản";
            // 
            // btnFilterByUsedState
            // 
            btnFilterByUsedState.Location = new Point(441, 321);
            btnFilterByUsedState.Name = "btnFilterByUsedState";
            btnFilterByUsedState.Size = new Size(117, 34);
            btnFilterByUsedState.TabIndex = 7;
            btnFilterByUsedState.Text = "Lọc";
            btnFilterByUsedState.UseVisualStyleBackColor = true;
            btnFilterByUsedState.Click += btnFilterByUsedState_Click;
            // 
            // cmbUsedState
            // 
            cmbUsedState.FormattingEnabled = true;
            cmbUsedState.Items.AddRange(new object[] { "Chưa sử dụng", "Đang sử dụng", "Đã thanh lý" });
            cmbUsedState.Location = new Point(156, 322);
            cmbUsedState.Name = "cmbUsedState";
            cmbUsedState.Size = new Size(279, 33);
            cmbUsedState.TabIndex = 6;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(18, 326);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(126, 25);
            lblFilter.TabIndex = 5;
            lblFilter.Text = "Lọc theo TTSD";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(681, 282);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(140, 34);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(156, 284);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(519, 31);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.Text = "Nhập tên tài sản cần tìm";
            // 
            // rdDaThanhLy
            // 
            rdDaThanhLy.AutoSize = true;
            rdDaThanhLy.Location = new Point(479, 244);
            rdDaThanhLy.Name = "rdDaThanhLy";
            rdDaThanhLy.Size = new Size(127, 29);
            rdDaThanhLy.TabIndex = 2;
            rdDaThanhLy.TabStop = true;
            rdDaThanhLy.Text = "Đã thanh lý";
            rdDaThanhLy.UseVisualStyleBackColor = true;
            // 
            // rdDangSuDung
            // 
            rdDangSuDung.AutoSize = true;
            rdDangSuDung.Location = new Point(315, 244);
            rdDangSuDung.Name = "rdDangSuDung";
            rdDangSuDung.Size = new Size(151, 29);
            rdDangSuDung.TabIndex = 1;
            rdDangSuDung.TabStop = true;
            rdDangSuDung.Text = "Đang sử dụng";
            rdDangSuDung.UseVisualStyleBackColor = true;
            // 
            // rdChuaSuDung
            // 
            rdChuaSuDung.AutoSize = true;
            rdChuaSuDung.Location = new Point(156, 244);
            rdChuaSuDung.Name = "rdChuaSuDung";
            rdChuaSuDung.Size = new Size(149, 29);
            rdChuaSuDung.TabIndex = 0;
            rdChuaSuDung.TabStop = true;
            rdChuaSuDung.Text = "Chưa sử dụng";
            rdChuaSuDung.UseVisualStyleBackColor = true;
            // 
            // gbXuLy
            // 
            gbXuLy.Controls.Add(btnXoaDuLieu);
            gbXuLy.Controls.Add(btnXoa);
            gbXuLy.Controls.Add(btnCapNhat);
            gbXuLy.Controls.Add(btnThem);
            gbXuLy.Controls.Add(btnHienThi);
            gbXuLy.Location = new Point(877, 14);
            gbXuLy.Name = "gbXuLy";
            gbXuLy.Size = new Size(298, 374);
            gbXuLy.TabIndex = 12;
            gbXuLy.TabStop = false;
            gbXuLy.Text = "Xử lý";
            // 
            // btnXoaDuLieu
            // 
            btnXoaDuLieu.Location = new Point(69, 239);
            btnXoaDuLieu.Name = "btnXoaDuLieu";
            btnXoaDuLieu.Size = new Size(170, 34);
            btnXoaDuLieu.TabIndex = 4;
            btnXoaDuLieu.Text = "Xóa thông tin";
            btnXoaDuLieu.UseVisualStyleBackColor = true;
            btnXoaDuLieu.Click += btnXoaDuLieu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(69, 199);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(170, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa tài sản";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(69, 159);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(170, 34);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(69, 118);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(170, 34);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm tài sản";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(69, 78);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(170, 34);
            btnHienThi.TabIndex = 0;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // FQuanlyTS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 696);
            Controls.Add(gbXuLy);
            Controls.Add(chkStatus);
            Controls.Add(lblLoaiTaiSan);
            Controls.Add(cmbLoaiTaiSan);
            Controls.Add(txtGiaMua);
            Controls.Add(lblGiaMua);
            Controls.Add(lblNgayMua);
            Controls.Add(dtNgayMua);
            Controls.Add(lblTenTaiSan);
            Controls.Add(txtTenTaiSan);
            Controls.Add(txtMaTaiSan);
            Controls.Add(lblMaTaiSan);
            Controls.Add(dataGridView);
            Controls.Add(gbThongTin);
            Name = "FQuanlyTS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài sản";
            Load += FQuanlyTS_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            gbXuLy.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label lblMaTaiSan;
        private TextBox txtMaTaiSan;
        private TextBox txtTenTaiSan;
        private Label lblTenTaiSan;
        private DateTimePicker dtNgayMua;
        private Label lblNgayMua;
        private Label lblGiaMua;
        private TextBox txtGiaMua;
        private ComboBox cmbLoaiTaiSan;
        private Label lblLoaiTaiSan;
        private CheckBox chkStatus;
        private GroupBox gbThongTin;
        private RadioButton rdDaThanhLy;
        private RadioButton rdDangSuDung;
        private RadioButton rdChuaSuDung;
        private TextBox txtTimKiem;
        private GroupBox gbXuLy;
        private Button btnTimKiem;
        private Button btnXoaDuLieu;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private Button btnHienThi;
        private ComboBox cmbUsedState;
        private Label lblFilter;
        private Button btnFilterByUsedState;
    }
}