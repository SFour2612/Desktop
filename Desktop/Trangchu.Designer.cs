namespace Desktop
{
    partial class Trangchu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trangchu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnQuanly = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDichvu = new System.Windows.Forms.Button();
            this.btnHoadon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaidat = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.pnlTrangchu = new System.Windows.Forms.Panel();
            this.dichVu1 = new Desktop.DichVu();
            this.pnlBaocao1 = new Desktop.pnlBaocao();
            this.phong1 = new Desktop.Phong();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTrangchu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // btnBaocao
            // 
            this.btnBaocao.BackColor = System.Drawing.Color.Transparent;
            this.btnBaocao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaocao.BackgroundImage")));
            this.btnBaocao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBaocao.Location = new System.Drawing.Point(0, 245);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(200, 41);
            this.btnBaocao.TabIndex = 0;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = false;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnQuanly
            // 
            this.btnQuanly.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanly.BackgroundImage")));
            this.btnQuanly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanly.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuanly.Location = new System.Drawing.Point(0, 292);
            this.btnQuanly.Name = "btnQuanly";
            this.btnQuanly.Size = new System.Drawing.Size(200, 41);
            this.btnQuanly.TabIndex = 0;
            this.btnQuanly.Text = "Quản lý";
            this.btnQuanly.UseVisualStyleBackColor = false;
            this.btnQuanly.Click += new System.EventHandler(this.btnQuanly_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhong.BackgroundImage")));
            this.btnPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPhong.Location = new System.Drawing.Point(0, 151);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(200, 41);
            this.btnPhong.TabIndex = 0;
            this.btnPhong.Text = "Phòng hát";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnDichvu
            // 
            this.btnDichvu.BackColor = System.Drawing.Color.Transparent;
            this.btnDichvu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDichvu.BackgroundImage")));
            this.btnDichvu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichvu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDichvu.Location = new System.Drawing.Point(0, 198);
            this.btnDichvu.Name = "btnDichvu";
            this.btnDichvu.Size = new System.Drawing.Size(200, 41);
            this.btnDichvu.TabIndex = 0;
            this.btnDichvu.Text = "Dịch vụ";
            this.btnDichvu.UseVisualStyleBackColor = false;
            this.btnDichvu.Click += new System.EventHandler(this.btnDichvu_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.BackColor = System.Drawing.Color.Transparent;
            this.btnHoadon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoadon.BackgroundImage")));
            this.btnHoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHoadon.Location = new System.Drawing.Point(0, 339);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(200, 41);
            this.btnHoadon.TabIndex = 0;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.UseVisualStyleBackColor = false;
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Karaoke";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCaidat);
            this.panel1.Controls.Add(this.btnKhachhang);
            this.panel1.Controls.Add(this.btnHoadon);
            this.panel1.Controls.Add(this.btnDichvu);
            this.panel1.Controls.Add(this.btnPhong);
            this.panel1.Controls.Add(this.btnBaocao);
            this.panel1.Controls.Add(this.btnQuanly);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 482);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCaidat
            // 
            this.btnCaidat.BackColor = System.Drawing.Color.Transparent;
            this.btnCaidat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCaidat.BackgroundImage")));
            this.btnCaidat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaidat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaidat.Location = new System.Drawing.Point(0, 433);
            this.btnCaidat.Name = "btnCaidat";
            this.btnCaidat.Size = new System.Drawing.Size(200, 41);
            this.btnCaidat.TabIndex = 0;
            this.btnCaidat.Text = "Cài đặt";
            this.btnCaidat.UseVisualStyleBackColor = false;
            this.btnCaidat.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.BackgroundImage")));
            this.btnKhachhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKhachhang.Location = new System.Drawing.Point(0, 386);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(200, 41);
            this.btnKhachhang.TabIndex = 0;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = false;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // pnlTrangchu
            // 
            this.pnlTrangchu.Controls.Add(this.phong1);
            this.pnlTrangchu.Controls.Add(this.pnlBaocao1);
            this.pnlTrangchu.Controls.Add(this.dichVu1);
            this.pnlTrangchu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrangchu.Location = new System.Drawing.Point(200, 0);
            this.pnlTrangchu.Name = "pnlTrangchu";
            this.pnlTrangchu.Size = new System.Drawing.Size(863, 482);
            this.pnlTrangchu.TabIndex = 1;
            // 
            // dichVu1
            // 
            this.dichVu1.Location = new System.Drawing.Point(0, 0);
            this.dichVu1.Name = "dichVu1";
            this.dichVu1.Size = new System.Drawing.Size(863, 482);
            this.dichVu1.TabIndex = 0;
            // 
            // pnlBaocao1
            // 
            this.pnlBaocao1.Location = new System.Drawing.Point(-3, 0);
            this.pnlBaocao1.Name = "pnlBaocao1";
            this.pnlBaocao1.Size = new System.Drawing.Size(863, 482);
            this.pnlBaocao1.TabIndex = 1;
            // 
            // phong1
            // 
            this.phong1.Location = new System.Drawing.Point(0, 0);
            this.phong1.Name = "phong1";
            this.phong1.Size = new System.Drawing.Size(863, 482);
            this.phong1.TabIndex = 2;
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1063, 482);
            this.Controls.Add(this.pnlTrangchu);
            this.Controls.Add(this.panel1);
            this.Name = "Trangchu";
            this.Text = "Trangchu";
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTrangchu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnQuanly;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDichvu;
        private System.Windows.Forms.Button btnHoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnCaidat;
        private System.Windows.Forms.Panel pnlTrangchu;
        private pnlBaocao pnlBaocao1;
        private DichVu dichVu1;
        private Phong phong1;
    }
}