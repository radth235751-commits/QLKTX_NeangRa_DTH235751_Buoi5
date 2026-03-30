using ClosedXML.Excel;
using QLKTX.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX.Forms
{
    public partial class frmLoaiPhong : Form
    {
        QLKTXDbContext db = new QLKTXDbContext();
        bool xuLyThem = false;
        int id = 0;

        public frmLoaiPhong()
        {
            InitializeComponent();

            numDonGia.Minimum = 0m;
            numDonGia.Maximum = 999999999999m;
            numDonGia.DecimalPlaces = 0;
            numDonGia.ThousandsSeparator = true;
        }

        // ================= LOAD =================
        public void LoadLoaiPhong()
        {
            try
            {
                var list = db.LoaiPhong
                    .Select(lp => new
                    {
                        lp.ID,
                        lp.MaLoaiPhong,
                        lp.TenLoaiPhong,
                        lp.GiaPhong,
                        lp.GhiChu
                    }).ToList();

                dataGridView1.DataSource = list;

                dataGridView1.Columns["MaLoaiPhong"].HeaderText = "Mã loại phòng";
                dataGridView1.Columns["TenLoaiPhong"].HeaderText = "Tên loại phòng";
                dataGridView1.Columns["GiaPhong"].HeaderText = "Đơn giá";
                dataGridView1.Columns["GhiChu"].HeaderText = "Ghi chú";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        // ================= BẬT/TẮT =================
        void BatTatChucNang(bool giaTri)
        {
            txtMaLoaiPhong.Enabled = giaTri;
            txtTenLoaiPhong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtGhiChu.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;

            dataGridView1.Enabled = !giaTri;
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            try
            {
                // Refresh context để lấy dữ liệu mới nhất từ DB
                db = new QLKTXDbContext();
               
                var list = db.LoaiPhong
                    .Select(lp => new
                    {
                        lp.ID,
                        lp.MaLoaiPhong,
                        lp.TenLoaiPhong,
                        lp.GiaPhong,
                        lp.GhiChu
                    }).ToList();

                dataGridView1.DataSource = list;

                if (dataGridView1.Columns["ID"] != null) dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["MaLoaiPhong"].HeaderText = "Mã loại phòng";
                dataGridView1.Columns["TenLoaiPhong"].HeaderText = "Tên loại phòng";
                dataGridView1.Columns["GiaPhong"].HeaderText = "Đơn giá";
                dataGridView1.Columns["GiaPhong"].DefaultCellStyle.Format = "N0"; // Định dạng 1,000,000
                dataGridView1.Columns["GhiChu"].HeaderText = "Ghi chú";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        // ================= CLICK GRID =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            id = (int)row.Cells["ID"].Value;

            txtMaLoaiPhong.Text = row.Cells["MaLoaiPhong"].Value?.ToString();
            txtTenLoaiPhong.Text = row.Cells["TenLoaiPhong"].Value?.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();

            if (decimal.TryParse(row.Cells["GiaPhong"].Value?.ToString(), out decimal gia))
                numDonGia.Value = gia;
        
        }

        // ================= TÌM KIẾM =================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = (txtTimKiem.Text ?? "").Trim().ToLower();

            var list = db.LoaiPhong
                .Where(lp =>
                    (lp.MaLoaiPhong != null && lp.MaLoaiPhong.Contains(keyword)) ||
        (lp.TenLoaiPhong != null && lp.TenLoaiPhong.Contains(keyword))
                )
                .Select(lp => new
                {
                    lp.ID,
                    lp.MaLoaiPhong,
                    lp.TenLoaiPhong,
                    lp.GiaPhong,
                    lp.GhiChu
                })
                .ToList();

            dataGridView1.DataSource = list;
        }

        // ================= THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaLoaiPhong.Clear();
            txtTenLoaiPhong.Clear();
            numDonGia.Value = 0;
            txtGhiChu.Clear();
        }

        // ================= LƯU =================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoaiPhong.Text))
            {
                MessageBox.Show("Thiếu mã loại phòng");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenLoaiPhong.Text))
            {
                MessageBox.Show("Thiếu tên loại phòng");
                return;
            }

            if (xuLyThem)
            {
                if (db.LoaiPhong.Any(x => x.MaLoaiPhong == txtMaLoaiPhong.Text))
                {
                    MessageBox.Show("Mã loại phòng đã tồn tại");
                    return;
                }

                var lp = new LoaiPhong()
                {
                    MaLoaiPhong = txtMaLoaiPhong.Text,
                    TenLoaiPhong = txtTenLoaiPhong.Text,
                    GiaPhong = numDonGia.Value,
                    GhiChu = txtGhiChu.Text
                };

                db.LoaiPhong.Add(lp);
            }
            else
            {
                var lp = db.LoaiPhong.Find(id);
                if (lp != null)
                {
                    lp.MaLoaiPhong = txtMaLoaiPhong.Text;
                    lp.TenLoaiPhong = txtTenLoaiPhong.Text;
                    lp.GiaPhong = numDonGia.Value;
                    lp.GhiChu = txtGhiChu.Text;
                }
            }

            db.SaveChanges();
            LoadLoaiPhong();
            BatTatChucNang(false);
        }

        // ================= SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                int idXoa = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                var lp = db.LoaiPhong.Find(idXoa);
                if (lp != null)
                {
                    db.LoaiPhong.Remove(lp);
                    db.SaveChanges();

                    LoadLoaiPhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa: " + ex.Message);
            }
        }

        // ================= HỦY =================
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LoadLoaiPhong();
            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ================= NHẬP EXCEL =================
        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var wb = new XLWorkbook(ofd.FileName))
                    {
                        var ws = wb.Worksheet(1);
                        var lastRow = ws.LastRowUsed();
                        int rowCount = lastRow != null ? lastRow.RowNumber() : 0;

                        if (rowCount < 2)
                        {
                            MessageBox.Show("File Excel không có dữ liệu để nhập!");
                            return;
                        }
                        int added = 0;

                        for (int i = 2; i <= rowCount; i++)
                        {
                            string ma = ws.Cell(i, 1).GetString().Trim();
                            string ten = ws.Cell(i, 2).GetString();
                            decimal gia = ws.Cell(i, 3).GetValue<decimal>();
                            string ghiChu = ws.Cell(i, 4).GetString();

                            if (string.IsNullOrEmpty(ma)) continue;
                            if (db.LoaiPhong.Any(x => x.MaLoaiPhong == ma)) continue;

                            db.LoaiPhong.Add(new LoaiPhong
                            {
                                MaLoaiPhong = ma,
                                TenLoaiPhong = ten,
                                GiaPhong = gia,
                                GhiChu = ghiChu
                            });

                            added++;
                        }

                        db.SaveChanges();
                        LoadLoaiPhong();

                        MessageBox.Show($"Đã nhập {added} loại phòng!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập Excel: " + ex.Message);
                }
            }
        }

        // ================= XUẤT EXCEL =================
        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("LoaiPhong");

                        string[] header = { "Mã loại phòng", "Tên loại phòng", "Giá phòng", "Ghi chú" };

                        for (int i = 0; i < header.Length; i++)
                        {
                            ws.Cell(1, i + 1).Value = header[i];
                            ws.Cell(1, i + 1).Style.Font.Bold = true;
                        }

                        var list = db.LoaiPhong.ToList();
                        int row = 2;

                        foreach (var lp in list)
                        {
                            ws.Cell(row, 1).Value = lp.MaLoaiPhong;
                            ws.Cell(row, 2).Value = lp.TenLoaiPhong;
                            ws.Cell(row, 3).Value = lp.GiaPhong;
                            ws.Cell(row, 4).Value = lp.GhiChu;
                            row++;
                        }

                        ws.Columns().AdjustToContents();

                        wb.SaveAs(sfd.FileName);

                        MessageBox.Show("Xuất Excel thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
                }
            }
        }
    }
}