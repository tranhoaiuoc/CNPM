namespace khothuoc
{
    partial class NhapThuoc
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
            this.dgvNhapThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtIDDonNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btbThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboIDThuoc = new System.Windows.Forms.ComboBox();
            this.IDThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDonNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhapThuoc
            // 
            this.dgvNhapThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDThuoc,
            this.IDDonNhap,
            this.NgayNhap,
            this.SoLuongNhap});
            this.dgvNhapThuoc.Location = new System.Drawing.Point(12, 295);
            this.dgvNhapThuoc.Name = "dgvNhapThuoc";
            this.dgvNhapThuoc.Size = new System.Drawing.Size(571, 227);
            this.dgvNhapThuoc.TabIndex = 1;
            this.dgvNhapThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapThuoc_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboIDThuoc);
            this.groupBox1.Controls.Add(this.txtNgayNhap);
            this.groupBox1.Controls.Add(this.txtIDDonNhap);
            this.groupBox1.Controls.Add(this.txtSoLuongNhap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 254);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhập Thuốc";
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNgayNhap.Location = new System.Drawing.Point(118, 87);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(147, 22);
            this.txtNgayNhap.TabIndex = 3;
            // 
            // txtIDDonNhap
            // 
            this.txtIDDonNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIDDonNhap.Location = new System.Drawing.Point(118, 58);
            this.txtIDDonNhap.Name = "txtIDDonNhap";
            this.txtIDDonNhap.Size = new System.Drawing.Size(147, 22);
            this.txtIDDonNhap.TabIndex = 2;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoLuongNhap.Location = new System.Drawing.Point(118, 119);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(147, 22);
            this.txtSoLuongNhap.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày Nhập Thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã Đơn Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Thuốc";
            // 
            // btbThem
            // 
            this.btbThem.AutoSize = true;
            this.btbThem.Location = new System.Drawing.Point(466, 28);
            this.btbThem.Name = "btbThem";
            this.btbThem.Size = new System.Drawing.Size(62, 24);
            this.btbThem.TabIndex = 34;
            this.btbThem.Text = "Thêm";
            this.btbThem.UseVisualStyleBackColor = true;
            this.btbThem.Click += new System.EventHandler(this.btbThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(466, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(62, 24);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.AutoSize = true;
            this.btnluu.Location = new System.Drawing.Point(466, 111);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(62, 24);
            this.btnluu.TabIndex = 36;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(466, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(62, 24);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(466, 204);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(62, 24);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboIDThuoc
            // 
            this.cboIDThuoc.FormattingEnabled = true;
            this.cboIDThuoc.Location = new System.Drawing.Point(118, 20);
            this.cboIDThuoc.Name = "cboIDThuoc";
            this.cboIDThuoc.Size = new System.Drawing.Size(104, 23);
            this.cboIDThuoc.TabIndex = 13;
            // 
            // IDThuoc
            // 
            this.IDThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDThuoc.DataPropertyName = "IDThuoc";
            this.IDThuoc.HeaderText = "IDThuoc";
            this.IDThuoc.Name = "IDThuoc";
            this.IDThuoc.Width = 74;
            // 
            // IDDonNhap
            // 
            this.IDDonNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDDonNhap.DataPropertyName = "IDDonNhap";
            this.IDDonNhap.HeaderText = "IDDonNhap";
            this.IDDonNhap.Name = "IDDonNhap";
            this.IDDonNhap.Width = 89;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 83;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "SoLuongNhap";
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // NhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 534);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btbThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNhapThuoc);
            this.Name = "NhapThuoc";
            this.Text = "NhapThuoc";
            this.Load += new System.EventHandler(this.NhapThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhapThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtIDDonNhap;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btbThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboIDThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDonNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
    }
}