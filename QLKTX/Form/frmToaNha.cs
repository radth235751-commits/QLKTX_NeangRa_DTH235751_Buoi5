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
    public partial class frmToaNha : Form
    {
        QLKTXDbContext db = new QLKTXDbContext();
        bool xuLyThem = false;
        int id = 0;
        public frmToaNha()
        {
            InitializeComponent();
        }
        private void LoadToaNha()
        {
            try
            {
               
                var list = db.ToaNha
                    .Select(t => new { t.ID, t.MaToa, t.TenToa })
                    .ToList();
                dataGridView1.DataSource = list;

                if (dataGridView1.Columns["MaToa"] != null) dataGridView1.Columns["MaToa"].HeaderText = "Mã Tòa";
                if (dataGridView1.Columns["TenToa"] != null) dataGridView1.Columns["TenToa"].HeaderText = "Tên Tòa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        void BatTatChucNang(bool giaTri)
        {
            txtMaToa.Enabled = giaTri;
            txtTenToa.Enabled = giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;

            dataGridView1.Enabled = !giaTri;
        }
        private void frmToaNha_Load(object sender, EventArgs e)
        {
            LoadToaNha();
            BatTatChucNang(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            id = Convert.ToInt32(row.Cells["ID"].Value);

            txtMaToa.Text = row.Cells["MaToa"].Value?.ToString() ?? "";
            txtTenToa.Text = row.Cells["TenToa"].Value?.ToString() ?? "";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = (txtTimKiem.Text ?? "").Trim().ToLower();

            var list = db.ToaNha
                .Where(t =>
                    (t.MaToa ?? "").ToLower().Contains(keyword) ||
                    (t.TenToa ?? "").ToLower().Contains(keyword)
                )
                .Select(t => new
                {
                    t.ID,
                    MaToa = t.MaToa ?? "",
                    TenToa = t.TenToa ?? ""
                })
                .ToList();

            dataGridView1.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtMaToa.Clear();
            txtTenToa.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaToa.Text))
            {
                MessageBox.Show("Thiếu mã tòa");
                return;
            }

            if (xuLyThem)
            {
                if (db.ToaNha.Any(x => x.MaToa == txtMaToa.Text))
                {
                    MessageBox.Show("Mã tòa đã tồn tại");
                    return;
                }

                var t = new ToaNha()
                {
                    MaToa = txtMaToa.Text,
                    TenToa = txtTenToa.Text
                };

                db.ToaNha.Add(t);
            }
            else
            {
                var t = db.ToaNha.Find(id);
                if (t != null)
                {
                    t.MaToa = txtMaToa.Text;
                    t.TenToa = txtTenToa.Text;
                }
            }

            db.SaveChanges();
            LoadToaNha();
            BatTatChucNang(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            id = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                
                int idXoa = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                var t = db.ToaNha.Find(idXoa);
                if (t != null)
                {
                    db.ToaNha.Remove(t);
                    db.SaveChanges();

                    LoadToaNha(); 
                }
            }
            catch
            {
               
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            LoadToaNha();

            BatTatChucNang(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx";
            ofd.Title = "Chọn file Excel để nhập danh sách Tòa Nhà";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var wb = new XLWorkbook(ofd.FileName))
                    {
                        var ws = wb.Worksheet(1); // Lấy sheet đầu tiên
                        var lastRow = ws.LastRowUsed();
                        int rowCount = lastRow != null ? lastRow.RowNumber() : 0;

                        if (rowCount < 2)
                        {
                            MessageBox.Show("File Excel không có dữ liệu để nhập!");
                            return;
                        }
                        int addedCount = 0;

                        // Giả sử: Cột 1 là MaToa, Cột 2 là TenToa
                        // Vòng lặp chạy từ dòng 2 (bỏ qua tiêu đề)
                        for (int i = 2; i <= rowCount; i++)
                        {
                            string maToa = ws.Cell(i, 1).GetString().Trim();
                            string tenToa = ws.Cell(i, 2).GetString().Trim();

                            if (string.IsNullOrEmpty(maToa)) continue;

                            // Kiểm tra nếu mã tòa đã tồn tại trong DB thì bỏ qua
                            if (db.ToaNha.Any(x => x.MaToa == maToa)) continue;

                            var toaNha = new ToaNha()
                            {
                                MaToa = maToa,
                                TenToa = tenToa
                            };

                            db.ToaNha.Add(toaNha);
                            addedCount++;
                        }

                        db.SaveChanges();
                        LoadToaNha(); // Load lại Grid sau khi nhập

                        MessageBox.Show($"Đã nhập thành công {addedCount} tòa nhà!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi nhập Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách tòa nhà ra Excel";
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = "DanhSachToaNha_" + DateTime.Now.ToString("yyyyMMdd_HHmm");

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add("ToaNha");

                            // 1. THIẾT LẬP TIÊU ĐỀ (HEADER)
                            string[] header = { "Mã Tòa", "Tên Tòa Nhà" };

                            for (int i = 0; i < header.Length; i++)
                            {
                                var cell = ws.Cell(1, i + 1);
                                cell.Value = header[i];
                                cell.Style.Font.Bold = true;
                                cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // 2. ĐỔ DỮ LIỆU (DATA)
                            var listToaNha = db.ToaNha.ToList();
                            int row = 2;

                            foreach (var t in listToaNha)
                            {
                                ws.Cell(row, 1).Value = t.MaToa;
                                ws.Cell(row, 2).Value = t.TenToa;
                                row++;
                            }

                            // 3. ĐỊNH DẠNG (FORMAT)
                            ws.Columns().AdjustToContents(); // Tự rộng cột

                            // Kẻ khung cho vùng dữ liệu
                            var range = ws.Range(1, 1, row - 1, header.Length);
                            range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                            // 4. LƯU FILE
                            wb.SaveAs(sfd.FileName);
                            MessageBox.Show("Xuất danh sách tòa nhà thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
    }
}
