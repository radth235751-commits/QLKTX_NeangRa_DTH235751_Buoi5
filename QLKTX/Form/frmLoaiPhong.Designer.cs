namespace QLKTX.Forms
{
    partial class frmLoaiPhong
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnXuat = new Button();
            btnNhap = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            txtTenLoaiPhong = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtGhiChu = new TextBox();
            label3 = new Label();
            txtMaLoaiPhong = new TextBox();
            label1 = new Label();
            ID = new DataGridViewTextBoxColumn();
            MaLoaiPhong = new DataGridViewTextBoxColumn();
            TenLoaiPhong = new DataGridViewTextBoxColumn();
            GiaPhong = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            numDonGia = new NumericUpDown();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(24, 382);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1253, 309);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, MaLoaiPhong, TenLoaiPhong, GiaPhong, GhiChu });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.Size = new Size(1247, 281);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(txtTenLoaiPhong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaLoaiPhong);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1253, 309);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại phòng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(864, 26);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 16;
            label7.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(864, 52);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(262, 29);
            txtTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1134, 50);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(98, 31);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(864, 245);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 31);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(996, 245);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 31);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1122, 195);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(98, 31);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1122, 148);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(98, 31);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(864, 195);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(98, 31);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(864, 148);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 31);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(996, 195);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(98, 31);
            btnHuyBo.TabIndex = 13;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(996, 148);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 31);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtTenLoaiPhong
            // 
            txtTenLoaiPhong.Location = new Point(568, 90);
            txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            txtTenLoaiPhong.Size = new Size(221, 29);
            txtTenLoaiPhong.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 153);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 0;
            label4.Text = "Đơn giá (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 93);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 0;
            label2.Text = "Loại phòng (*):";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(138, 150);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(221, 29);
            txtGhiChu.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 153);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 0;
            label3.Text = "Ghi chú (*):";
            // 
            // txtMaLoaiPhong
            // 
            txtMaLoaiPhong.Location = new Point(138, 90);
            txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            txtMaLoaiPhong.Size = new Size(221, 29);
            txtMaLoaiPhong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 93);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã loại phòng (*):";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            // 
            // MaLoaiPhong
            // 
            MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            MaLoaiPhong.HeaderText = "Mã loại phòng";
            MaLoaiPhong.MinimumWidth = 7;
            MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // TenLoaiPhong
            // 
            TenLoaiPhong.DataPropertyName = "TenLoaiPhong";
            TenLoaiPhong.HeaderText = "Loại phòng";
            TenLoaiPhong.MinimumWidth = 7;
            TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // GiaPhong
            // 
            GiaPhong.DataPropertyName = "GiaPhong";
            GiaPhong.HeaderText = "Đơn giá";
            GiaPhong.MinimumWidth = 7;
            GiaPhong.Name = "GiaPhong";
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 7;
            GhiChu.Name = "GhiChu";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(579, 153);
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(210, 29);
            numDonGia.TabIndex = 18;
            // 
            // frmLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 719);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiPhong";
            Text = "Loại phòng";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnSua;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnLuu;
        private Button btnThem;
        private Button btnHuyBo;
        private Button btnXoa;
        private TextBox txtTenLoaiPhong;
        private Label label2;
        private TextBox txtMaLoaiPhong;
        private Label label1;
        private Label label4;
        private TextBox txtGhiChu;
        private Label label3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaLoaiPhong;
        private DataGridViewTextBoxColumn TenLoaiPhong;
        private DataGridViewTextBoxColumn GiaPhong;
        private DataGridViewTextBoxColumn GhiChu;
        private NumericUpDown numDonGia;
    }
}