using Models;
using Services;

namespace MyApplication
{
    public partial class FQuanlyTS : Form
    {
        private const string TAI_SAN_MOI = "Mua mới";
        private const string TAI_SAN_CU = "Mua lại";
        private const string CHUA_SU_DUNG = "Chưa sử dụng";
        private const string DANG_SU_DUNG = "Đang sử dụng";
        private const string DA_THANH_LY = "Đã thanh lý";
        List<TaiSan>? lstTaiSan = null;
        List<LoaiTaiSan>? lstLoaiTaiSan = null;

        public FQuanlyTS()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Prepare data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FQuanlyTS_Load(object sender, EventArgs e)
        {
            lstLoaiTaiSan = ServiceLoaiTaiSan.GetAll();
            cmbLoaiTaiSan.DataSource = lstLoaiTaiSan;
            cmbLoaiTaiSan.DisplayMember = "TenLoaiTS";
            cmbLoaiTaiSan.ValueMember = "maLoaiTS";
        }
        /// <summary>
        /// Xử lý sự kiện click lên combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbLoaiTaiSan_Click(object sender, EventArgs e)
        {
            cmbLoaiTaiSan.DataSource = lstLoaiTaiSan;
            cmbLoaiTaiSan.DisplayMember = "TenLoaiTS";
        }
        /// <summary>
        /// Gọi hàm hiển thị dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lstTaiSan = TaiSanService.GetAll();
            HienThi();
        }
        /// <summary>
        /// Thêm tài sản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTaiSan.Text) ||
                string.IsNullOrEmpty(txtGiaMua.Text))
            {
                return;
            }
            TaiSan taiSan = new TaiSan();
            taiSan.TenTaiSan = txtTenTaiSan.Text;
            taiSan.MaLoaiTS = (short?)(cmbLoaiTaiSan.SelectedIndex + 1);
            taiSan.NgayMua = dtNgayMua.Value;
            taiSan.GiaMua = Convert.ToDouble(txtGiaMua.Text);
            if (chkStatus.Checked)
            {
                taiSan.TinhTrang = TAI_SAN_MOI;
            }
            else
            {
                taiSan.TinhTrang = TAI_SAN_CU;
            }
            if (rdChuaSuDung.Checked)
            {
                taiSan.TrangThaiSD = CHUA_SU_DUNG;
            }
            else if (rdDangSuDung.Checked)
            {
                taiSan.TrangThaiSD = DANG_SU_DUNG;
            }
            else
            {
                taiSan.TrangThaiSD = DA_THANH_LY;
            }
            taiSan = TaiSanService.Create(taiSan);
            lstTaiSan = TaiSanService.GetAll();
            XoaThongTin();
            HienThi();
        }
        /// <summary>
        /// Cập nhật thông tin tài sản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTaiSan.Text))
            {
                return;
            }
            TaiSan taiSan = new TaiSan();
            taiSan.MaTaiSan = Convert.ToInt16(txtMaTaiSan.Text);
            taiSan.TenTaiSan = txtTenTaiSan.Text;
            taiSan.MaLoaiTS = (short?)(cmbLoaiTaiSan.SelectedIndex + 1);
            taiSan.NgayMua = dtNgayMua.Value;
            taiSan.GiaMua = Convert.ToDouble(txtGiaMua.Text);
            if (chkStatus.Checked)
            {
                taiSan.TinhTrang = TAI_SAN_MOI;
            }
            else
            {
                taiSan.TinhTrang = TAI_SAN_CU;
            }
            if (rdChuaSuDung.Checked)
            {
                taiSan.TrangThaiSD = CHUA_SU_DUNG;
            }
            else if (rdDangSuDung.Checked)
            {
                taiSan.TrangThaiSD = DANG_SU_DUNG;
            }
            else
            {
                taiSan.TrangThaiSD = DA_THANH_LY;
            }
            TaiSanService.Update(taiSan);
            lstTaiSan = TaiSanService.GetAll();
            XoaThongTin();
            HienThi();
        }
        /// <summary>
        /// Xoa tài sản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTaiSan.Text))
            {
                return;
            }
            TaiSan taiSan = new TaiSan();
            taiSan.MaTaiSan = Convert.ToInt16(txtMaTaiSan.Text);
            taiSan.TenTaiSan = txtTenTaiSan.Text;
            taiSan.MaLoaiTS = (short?)(cmbLoaiTaiSan.SelectedIndex + 1);
            taiSan.NgayMua = dtNgayMua.Value;
            taiSan.GiaMua = Convert.ToDouble(txtGiaMua.Text);
            if (chkStatus.Checked)
            {
                taiSan.TinhTrang = TAI_SAN_MOI;
            }
            else
            {
                taiSan.TinhTrang = TAI_SAN_CU;
            }
            if (rdChuaSuDung.Checked)
            {
                taiSan.TrangThaiSD = CHUA_SU_DUNG;
            }
            else if (rdDangSuDung.Checked)
            {
                taiSan.TrangThaiSD = DANG_SU_DUNG;
            }
            else
            {
                taiSan.TrangThaiSD = DA_THANH_LY;
            }
            TaiSanService.Delete(taiSan);
            XoaThongTin();
            lstTaiSan = TaiSanService.GetAll();
            HienThi();
        }
        /// <summary>
        /// Thiết lập thông tin mặc định
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoaDuLieu_Click(object sender, EventArgs e)
        {
            XoaThongTin();
        }
        /// <summary>
        /// Tìm kiếm tài sản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Equals("Nhập tên tài sản cần tìm"))
            {
                return;
            }
            lstTaiSan = TaiSanService.FindByName(txtTimKiem.Text);
            dataGridView.DataSource = lstTaiSan;
            HienThi();
        }
        /// <summary>
        /// Lọc theo tình trạng sử dụng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilterByUsedState_Click(object sender, EventArgs e)
        {
            string value = cmbUsedState.Text;
            if (string.IsNullOrEmpty(value))
            {
                return;
            }
            lstTaiSan = TaiSanService.FilterByUsedState(value);
            HienThi();
        }
        /// <summary>
        /// Xử lý khi click lên cell của DatagridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                txtMaTaiSan.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenTaiSan.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                //Ngày mua
                string? buyDate = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (!string.IsNullOrEmpty(buyDate))
                {
                    dtNgayMua.Value = DateTime.Parse(buyDate);
                }
                txtGiaMua.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                //Loại tài sản
                string? loaiTS = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (!string.IsNullOrEmpty(loaiTS))
                {
                    cmbLoaiTaiSan.SelectedIndex = Convert.ToInt16(loaiTS) - 1;
                }
                //Trạng thái của tài sản
                string? status = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (TAI_SAN_MOI.Equals(status))
                {
                    chkStatus.Checked = true;
                }
                else
                {
                    chkStatus.Checked = false;
                }
                // Trạng thái sử dụng
                string? usedState = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                switch (usedState)
                {
                    case CHUA_SU_DUNG:
                        rdChuaSuDung.Checked = true;
                        break;
                    case DANG_SU_DUNG:
                        rdDangSuDung.Checked = true;
                        break;
                    case DA_THANH_LY:
                        rdDaThanhLy.Checked = true;
                        break;
                }

                if (TAI_SAN_MOI.Equals(status))
                {
                    chkStatus.Checked = true;
                }
                else
                {
                    chkStatus.Checked = false;
                }
            }
        }
        /// <summary>
        /// Hàm hiển thị dữ liệu lên DataGridView
        /// </summary>
        private void HienThi()
        {
            dataGridView.DataSource = lstTaiSan;
            dataGridView.Columns[0].HeaderText = "mã tài sản";
            dataGridView.Columns[1].HeaderText = "Tên tài sản";
            dataGridView.Columns[2].HeaderText = "Ngày mua";
            dataGridView.Columns[3].HeaderText = "Giá mua";
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].HeaderText = "Tình trạng";
            dataGridView.Columns[6].HeaderText = "Trạng thái sử dụng";
            //Định dạng tiêu đề cột
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            //Chọn dòng đầu tiên
            if (lstTaiSan != null && lstTaiSan.Count > 0)
            {
                dataGridView.Rows[0].Selected = true;
            }
        }
        /// <summary>
        /// Hàm xóa thông tin
        /// </summary>
        private void XoaThongTin()
        {
            txtMaTaiSan.Text = string.Empty;
            txtTenTaiSan.Text = string.Empty;
            dtNgayMua.Value = DateTime.UtcNow.ToLocalTime();
            txtGiaMua.Text = string.Empty;
            chkStatus.Checked = true;
            rdChuaSuDung.Checked = true;
            txtTimKiem.Text = "Nhập tên tài sản cần tìm";
            cmbLoaiTaiSan.SelectedIndex = 0;
        }
    }
}
