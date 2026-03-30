namespace QLKTX.Forms
{
    partial class frmPhong1
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
            ID = new DataGridViewTextBoxColumn();
            MaPhong = new DataGridViewTextBoxColumn();
            SoPhong = new DataGridViewTextBoxColumn();
            LoaiPhong = new DataGridViewTextBoxColumn();
            ToaNha = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SucChua = new DataGridViewTextBoxColumn();
            SoLuongHienTai = new DataGridViewTextBoxColumn();
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
            cboSoPhong = new ComboBox();
            cboLoaiPhong = new ComboBox();
            cboToaNha = new ComboBox();
            dmSLhientai = new DomainUpDown();
            domainUpDown4 = new DomainUpDown();
            dmSucChua = new DomainUpDown();
            domainUpDown2 = new DomainUpDown();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            txtMaPhong = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(22, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1256, 351);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dannh sách phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, MaPhong, SoPhong, LoaiPhong, ToaNha, DonGia, SucChua, SoLuongHienTai });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.Size = new Size(1250, 323);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            // 
            // MaPhong
            // 
            MaPhong.DataPropertyName = "MaPhong";
            MaPhong.HeaderText = "Mã phòng";
            MaPhong.MinimumWidth = 7;
            MaPhong.Name = "MaPhong";
            // 
            // SoPhong
            // 
            SoPhong.DataPropertyName = "TenPhong";
            SoPhong.HeaderText = "Số phòng";
            SoPhong.MinimumWidth = 7;
            SoPhong.Name = "SoPhong";
            // 
            // LoaiPhong
            // 
            LoaiPhong.DataPropertyName = "LoaiPhongID";
            LoaiPhong.HeaderText = "Loại phòng";
            LoaiPhong.MinimumWidth = 7;
            LoaiPhong.Name = "LoaiPhong";
            // 
            // ToaNha
            // 
            ToaNha.DataPropertyName = "ToaNhaID";
            ToaNha.HeaderText = "Tòa nhà";
            ToaNha.MinimumWidth = 7;
            ToaNha.Name = "ToaNha";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "GiaPhong";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 7;
            DonGia.Name = "DonGia";
            // 
            // SucChua
            // 
            SucChua.DataPropertyName = "SucChua";
            SucChua.HeaderText = "Sức chứa";
            SucChua.MinimumWidth = 7;
            SucChua.Name = "SucChua";
            // 
            // SoLuongHienTai
            // 
            SoLuongHienTai.DataPropertyName = "SoLuongHienTai";
            SoLuongHienTai.HeaderText = "Số lượng hiện tại";
            SoLuongHienTai.MinimumWidth = 7;
            SoLuongHienTai.Name = "SoLuongHienTai";
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(cboSoPhong);
            groupBox1.Controls.Add(cboLoaiPhong);
            groupBox1.Controls.Add(cboToaNha);
            groupBox1.Controls.Add(dmSLhientai);
            groupBox1.Controls.Add(domainUpDown4);
            groupBox1.Controls.Add(dmSucChua);
            groupBox1.Controls.Add(domainUpDown2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMaPhong);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1256, 291);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phòng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(863, 21);
            label7.Name = "label7";
            label7.Size = new Size(77, 21);
            label7.TabIndex = 16;
            label7.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(863, 47);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(262, 29);
            txtTimKiem.TabIndex = 15;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1133, 45);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(98, 31);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(863, 240);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 31);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(995, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 31);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1121, 190);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(98, 31);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1121, 143);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(98, 31);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(863, 190);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(98, 31);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(863, 143);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 31);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(995, 190);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(98, 31);
            btnHuyBo.TabIndex = 13;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(995, 143);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 31);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // cboSoPhong
            // 
            cboSoPhong.FormattingEnabled = true;
            cboSoPhong.Location = new Point(581, 52);
            cboSoPhong.Name = "cboSoPhong";
            cboSoPhong.Size = new Size(194, 29);
            cboSoPhong.TabIndex = 3;
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Location = new Point(132, 173);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(201, 29);
            cboLoaiPhong.TabIndex = 3;
            // 
            // cboToaNha
            // 
            cboToaNha.FormattingEnabled = true;
            cboToaNha.Location = new Point(132, 114);
            cboToaNha.Name = "cboToaNha";
            cboToaNha.Size = new Size(201, 29);
            cboToaNha.TabIndex = 3;
            // 
            // dmSLhientai
            // 
            dmSLhientai.Location = new Point(581, 178);
            dmSLhientai.Name = "dmSLhientai";
            dmSLhientai.Size = new Size(194, 29);
            dmSLhientai.TabIndex = 2;
            // 
            // domainUpDown4
            // 
            domainUpDown4.Location = new Point(581, 177);
            domainUpDown4.Name = "domainUpDown4";
            domainUpDown4.Size = new Size(156, 29);
            domainUpDown4.TabIndex = 2;
            domainUpDown4.Text = "domainUpDown1";
            // 
            // dmSucChua
            // 
            dmSucChua.Location = new Point(581, 116);
            dmSucChua.Name = "dmSucChua";
            dmSucChua.Size = new Size(194, 29);
            dmSucChua.TabIndex = 2;
            // 
            // domainUpDown2
            // 
            domainUpDown2.Location = new Point(581, 115);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(156, 29);
            domainUpDown2.TabIndex = 2;
            domainUpDown2.Text = "domainUpDown1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(459, 55);
            label9.Name = "label9";
            label9.Size = new Size(101, 21);
            label9.TabIndex = 0;
            label9.Text = "Số phòng (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 178);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 0;
            label3.Text = "Loại phòng (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 116);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 0;
            label2.Text = "Tòa nhà (*):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(408, 179);
            label8.Name = "label8";
            label8.Size = new Size(152, 21);
            label8.TabIndex = 0;
            label8.Text = "Số lượng hiện tại (*):";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(132, 52);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(201, 29);
            txtMaPhong.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 122);
            label6.Name = "label6";
            label6.Size = new Size(96, 21);
            label6.TabIndex = 0;
            label6.Text = "Sức chứa (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 123);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 0;
            label5.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 60);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng (*):";
            // 
            // frmPhong1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 719);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPhong1";
            Text = "Phòng";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn SoPhong;
        private DataGridViewTextBoxColumn LoaiPhong;
        private DataGridViewTextBoxColumn ToaNha;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SucChua;
        private DataGridViewTextBoxColumn SoLuongHienTai;
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
        private ComboBox cboSoPhong;
        private ComboBox cboLoaiPhong;
        private ComboBox cboToaNha;
        private DomainUpDown dmSLhientai;
        private DomainUpDown domainUpDown4;
        private DomainUpDown dmSucChua;
        private DomainUpDown domainUpDown2;
        private Label label9;
        private Label label3;
        private Label label2;
        private Label label8;
        private TextBox txtMaPhong;
        private Label label6;
        private Label label5;
        private Label label1;
    }
}