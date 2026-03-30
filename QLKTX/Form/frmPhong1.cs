using Microsoft.EntityFrameworkCore;
using QLKTX.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLKTX.Forms
{
    public partial class frmPhong1 : Form
    {
        QLKTXDbContext db = new QLKTXDbContext();
        bool xuLyThem = false;
        int idSelected = 0;

        public frmPhong1()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object? sender, EventArgs e)
        {
            try
            {
                var dsToaNha = db.ToaNha.ToList();
                MessageBox.Show("ToaNha count = " + dsToaNha.Count);

                var dsLoaiPhong = db.LoaiPhong.ToList();
                MessageBox.Show("LoaiPhong count = " + dsLoaiPhong.Count);

                LoadComboBox();
                LoadPhong();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load form: " + ex.Message);
            }
        }

        void LoadComboBox()
        {
            // ===== RESET tránh lỗi binding =====
            cboToaNha.DataSource = null;
            cboLoaiPhong.DataSource = null;

            cboToaNha.Items.Clear();
            cboLoaiPhong.Items.Clear();

            // ===== LOAD TÒA NHÀ =====
            var dsToaNha = db.ToaNha.ToList();
            MessageBox.Show("ToaNha: " + dsToaNha.Count); // debug

            cboToaNha.DataSource = dsToaNha;
            cboToaNha.DisplayMember = "TenToa";   // sửa nếu DB khác tên
            cboToaNha.ValueMember = "ID";

            cboToaNha.SelectedIndex = -1;

            // ===== LOAD LOẠI PHÒNG =====
            var dsLoaiPhong = db.LoaiPhong.ToList();
            MessageBox.Show("LoaiPhong: " + dsLoaiPhong.Count); // debug

            cboLoaiPhong.DataSource = dsLoaiPhong;
            cboLoaiPhong.DisplayMember = "TenLoai"; // sửa nếu DB khác tên
            cboLoaiPhong.ValueMember = "ID";

            cboLoaiPhong.SelectedIndex = -1;
        }

        void LoadPhong()
        {
            var list = db.Phong
                .Include(p => p.LoaiPhong)
                .Include(p => p.ToaNha)
                .Select(p => new
                {
                    p.ID,
                    p.MaPhong,
                    p.TenPhong,
                    TenLoai = p.LoaiPhong.TenLoaiPhong,
                    TenToa = p.ToaNha.TenToa,
                    p.SucChua,
                    p.SoLuongHienTai
                })
                .ToList();

            dataGridView1.DataSource = list;

            if (dataGridView1.Columns["ID"] != null)
                dataGridView1.Columns["ID"].Visible = false;
        }

        void BatTatChucNang(bool giaTri)
        {
            txtMaPhong.Enabled = giaTri;
            cboSoPhong.Enabled = giaTri;
            cboLoaiPhong.Enabled = giaTri;
            cboToaNha.Enabled = giaTri;
            dmSucChua.Enabled = giaTri;
            dmSLhientai.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            idSelected = Convert.ToInt32(row.Cells["ID"].Value);

            txtMaPhong.Text = row.Cells["MaPhong"].Value?.ToString();
            cboSoPhong.Text = row.Cells["TenPhong"].Value?.ToString();

            var phong = db.Phong.Find(idSelected);
            if (phong != null)
            {
                cboLoaiPhong.SelectedValue = phong.MaLoaiPhong;
                cboToaNha.SelectedValue = phong.MaToa;
            }


            dmSucChua.Text = row.Cells["SucChua"].Value?.ToString();
            dmSLhientai.Text = row.Cells["SoLuongHienTai"].Value?.ToString();
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaPhong.Clear();
            cboSoPhong.SelectedIndex = -1;
            cboLoaiPhong.SelectedIndex = -1;
            cboToaNha.SelectedIndex = -1;


            dmSucChua.Text = "0";
            dmSLhientai.Text = "0";
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (MessageBox.Show("Xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var p = db.Phong.Find(idSelected);
                if (p != null)
                {
                    db.Phong.Remove(p);
                    db.SaveChanges();
                    LoadPhong();
                }
            }
        }

        private void btnLuu_Click(object? sender, EventArgs e)
        {
            try
            {
                Phong p;

                if (xuLyThem)
                {
                    p = new Phong();
                    db.Phong.Add(p);
                }
                else
                {
                    p = db.Phong.Find(idSelected);
                }

                if (p == null) return;

                // Validate ComboBox
                if (cboToaNha.SelectedValue == null || cboLoaiPhong.SelectedValue == null)
                {
                    MessageBox.Show("Chọn Tòa nhà & Loại phòng!");
                    return;
                }

                p.MaPhong = txtMaPhong.Text;
                p.TenPhong = cboSoPhong.Text;
                p.MaToa = (int)cboToaNha.SelectedValue;
                p.MaLoaiPhong = (int)cboLoaiPhong.SelectedValue;


                int.TryParse(dmSucChua.Text, out int sucChua);
                int.TryParse(dmSLhientai.Text, out int sl);


                p.SucChua = sucChua;
                p.SoLuongHienTai = sl;

                db.SaveChanges();

                LoadPhong();
                BatTatChucNang(false);

                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi: " + msg);
            }
        }

        private void btnHuyBo_Click(object? sender, EventArgs e)
        {
            BatTatChucNang(false);
        }
    }
}