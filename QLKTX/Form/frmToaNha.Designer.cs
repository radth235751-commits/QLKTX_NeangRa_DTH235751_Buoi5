namespace QLKTX.Forms
{
    partial class frmToaNha
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
            txtTenToa = new TextBox();
            label2 = new Label();
            txtMaToa = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaToa = new DataGridViewTextBoxColumn();
            TenToa = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            groupBox1.Controls.Add(txtTenToa);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaToa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1253, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tòa nhà";
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
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(864, 245);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 31);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(996, 245);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 31);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(1122, 195);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(98, 31);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(1122, 148);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(98, 31);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(864, 195);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(98, 31);
            btnLuu.TabIndex = 11;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(864, 148);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 31);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(996, 195);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(98, 31);
            btnHuyBo.TabIndex = 13;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(996, 148);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 31);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTenToa
            // 
            txtTenToa.Location = new Point(563, 85);
            txtTenToa.Name = "txtTenToa";
            txtTenToa.Size = new Size(221, 29);
            txtTenToa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 93);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên tòa nhà (*):";
            // 
            // txtMaToa
            // 
            txtMaToa.Location = new Point(138, 90);
            txtMaToa.Name = "txtMaToa";
            txtMaToa.Size = new Size(221, 29);
            txtMaToa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 93);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã tòa nhà (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(24, 376);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1253, 309);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách tòa nhà ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, MaToa, TenToa });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.Size = new Size(1247, 281);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 7;
            ID.Name = "ID";
            // 
            // MaToa
            // 
            MaToa.DataPropertyName = "MaToa";
            MaToa.HeaderText = "Mã tòa nhà";
            MaToa.MinimumWidth = 7;
            MaToa.Name = "MaToa";
            // 
            // TenToa
            // 
            TenToa.DataPropertyName = "TenToa";
            TenToa.HeaderText = "Tên tòa nhà";
            TenToa.MinimumWidth = 7;
            TenToa.Name = "TenToa";
            // 
            // frmToaNha
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 719);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmToaNha";
            Text = "Tòa nhà";
            Load += frmToaNha_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTenToa;
        private Label label2;
        private TextBox txtMaToa;
        private Label label1;
        private GroupBox groupBox2;
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaToa;
        private DataGridViewTextBoxColumn TenToa;
    }
}