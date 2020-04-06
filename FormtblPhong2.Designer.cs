namespace QuanLyKhachSan1
{
    partial class FormtblPhong2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaP = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_tblPhong = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tblPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // txtMaP
            // 
            this.txtMaP.Location = new System.Drawing.Point(180, 52);
            this.txtMaP.Name = "txtMaP";
            this.txtMaP.Size = new System.Drawing.Size(123, 26);
            this.txtMaP.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(180, 117);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(123, 26);
            this.txtDonGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn Giá";
            // 
            // txtTenP
            // 
            this.txtTenP.Location = new System.Drawing.Point(514, 52);
            this.txtTenP.Name = "txtTenP";
            this.txtTenP.Size = new System.Drawing.Size(123, 26);
            this.txtTenP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Phòng";
            // 
            // dataGridView_tblPhong
            // 
            this.dataGridView_tblPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_tblPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.DonGia});
            this.dataGridView_tblPhong.Location = new System.Drawing.Point(66, 237);
            this.dataGridView_tblPhong.Name = "dataGridView_tblPhong";
            this.dataGridView_tblPhong.RowHeadersWidth = 62;
            this.dataGridView_tblPhong.RowTemplate.Height = 28;
            this.dataGridView_tblPhong.Size = new System.Drawing.Size(571, 209);
            this.dataGridView_tblPhong.TabIndex = 6;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 8;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.Width = 150;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.MinimumWidth = 8;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // FormtblPhong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_tblPhong);
            this.Controls.Add(this.txtTenP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaP);
            this.Controls.Add(this.label1);
            this.Name = "FormtblPhong2";
            this.Text = "FormtblPhong2";
            this.Load += new System.EventHandler(this.FormtblPhong2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tblPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaP;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_tblPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}