namespace Desktop
{
    partial class Phong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTrangchu = new System.Windows.Forms.Panel();
            this.txtLoaiphong = new System.Windows.Forms.TextBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbTrangthai = new System.Windows.Forms.GroupBox();
            this.rdbDaduocdat = new System.Windows.Forms.RadioButton();
            this.rdbTrong = new System.Windows.Forms.RadioButton();
            this.btnSuaphong = new System.Windows.Forms.Button();
            this.btnXoaphong = new System.Windows.Forms.Button();
            this.btnThemphong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.pnlTrangchu.SuspendLayout();
            this.grbTrangthai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTrangchu
            // 
            this.pnlTrangchu.Controls.Add(this.dgvPhong);
            this.pnlTrangchu.Controls.Add(this.txtLoaiphong);
            this.pnlTrangchu.Controls.Add(this.txtTenphong);
            this.pnlTrangchu.Controls.Add(this.txtMaphong);
            this.pnlTrangchu.Controls.Add(this.label4);
            this.pnlTrangchu.Controls.Add(this.label3);
            this.pnlTrangchu.Controls.Add(this.label2);
            this.pnlTrangchu.Controls.Add(this.grbTrangthai);
            this.pnlTrangchu.Controls.Add(this.btnSuaphong);
            this.pnlTrangchu.Controls.Add(this.btnXoaphong);
            this.pnlTrangchu.Controls.Add(this.btnThemphong);
            this.pnlTrangchu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrangchu.Location = new System.Drawing.Point(0, 0);
            this.pnlTrangchu.Name = "pnlTrangchu";
            this.pnlTrangchu.Size = new System.Drawing.Size(863, 482);
            this.pnlTrangchu.TabIndex = 5;
            // 
            // txtLoaiphong
            // 
            this.txtLoaiphong.Location = new System.Drawing.Point(409, 335);
            this.txtLoaiphong.Name = "txtLoaiphong";
            this.txtLoaiphong.Size = new System.Drawing.Size(324, 22);
            this.txtLoaiphong.TabIndex = 4;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(409, 280);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(324, 22);
            this.txtTenphong.TabIndex = 4;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(409, 231);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(324, 22);
            this.txtMaphong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã phòng :";
            // 
            // grbTrangthai
            // 
            this.grbTrangthai.Controls.Add(this.rdbDaduocdat);
            this.grbTrangthai.Controls.Add(this.rdbTrong);
            this.grbTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTrangthai.Location = new System.Drawing.Point(6, 210);
            this.grbTrangthai.Name = "grbTrangthai";
            this.grbTrangthai.Size = new System.Drawing.Size(170, 90);
            this.grbTrangthai.TabIndex = 2;
            this.grbTrangthai.TabStop = false;
            this.grbTrangthai.Text = "Trạng thái";
            // 
            // rdbDaduocdat
            // 
            this.rdbDaduocdat.AutoSize = true;
            this.rdbDaduocdat.Location = new System.Drawing.Point(52, 59);
            this.rdbDaduocdat.Name = "rdbDaduocdat";
            this.rdbDaduocdat.Size = new System.Drawing.Size(110, 20);
            this.rdbDaduocdat.TabIndex = 0;
            this.rdbDaduocdat.TabStop = true;
            this.rdbDaduocdat.Text = "Đã có người";
            this.rdbDaduocdat.UseVisualStyleBackColor = true;
            // 
            // rdbTrong
            // 
            this.rdbTrong.AutoSize = true;
            this.rdbTrong.Location = new System.Drawing.Point(52, 21);
            this.rdbTrong.Name = "rdbTrong";
            this.rdbTrong.Size = new System.Drawing.Size(94, 20);
            this.rdbTrong.TabIndex = 0;
            this.rdbTrong.TabStop = true;
            this.rdbTrong.Text = "Còn trống";
            this.rdbTrong.UseVisualStyleBackColor = true;
            // 
            // btnSuaphong
            // 
            this.btnSuaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaphong.Location = new System.Drawing.Point(45, 386);
            this.btnSuaphong.Name = "btnSuaphong";
            this.btnSuaphong.Size = new System.Drawing.Size(107, 45);
            this.btnSuaphong.TabIndex = 1;
            this.btnSuaphong.Text = "Đặt phòng";
            this.btnSuaphong.UseVisualStyleBackColor = true;
            // 
            // btnXoaphong
            // 
            this.btnXoaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaphong.Location = new System.Drawing.Point(619, 382);
            this.btnXoaphong.Name = "btnXoaphong";
            this.btnXoaphong.Size = new System.Drawing.Size(114, 45);
            this.btnXoaphong.TabIndex = 1;
            this.btnXoaphong.Text = "Xóa phòng";
            this.btnXoaphong.UseVisualStyleBackColor = true;
            // 
            // btnThemphong
            // 
            this.btnThemphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemphong.Location = new System.Drawing.Point(418, 382);
            this.btnThemphong.Name = "btnThemphong";
            this.btnThemphong.Size = new System.Drawing.Size(121, 45);
            this.btnThemphong.TabIndex = 1;
            this.btnThemphong.Text = "Thêm phòng";
            this.btnThemphong.UseVisualStyleBackColor = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(863, 185);
            this.dgvPhong.TabIndex = 5;
            // 
            // Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTrangchu);
            this.Name = "Phong";
            this.Size = new System.Drawing.Size(863, 482);
            this.pnlTrangchu.ResumeLayout(false);
            this.pnlTrangchu.PerformLayout();
            this.grbTrangthai.ResumeLayout(false);
            this.grbTrangthai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrangchu;
        private System.Windows.Forms.TextBox txtLoaiphong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbTrangthai;
        private System.Windows.Forms.RadioButton rdbDaduocdat;
        private System.Windows.Forms.RadioButton rdbTrong;
        private System.Windows.Forms.Button btnSuaphong;
        private System.Windows.Forms.Button btnXoaphong;
        private System.Windows.Forms.Button btnThemphong;
        private System.Windows.Forms.DataGridView dgvPhong;
    }
}
