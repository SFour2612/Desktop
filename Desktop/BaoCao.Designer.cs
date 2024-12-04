namespace Desktop
{
    partial class pnlBaocao
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
            this.components = new System.ComponentModel.Container();
            this.grbNhanvienBC = new System.Windows.Forms.GroupBox();
            this.grbDoanhthuBC = new System.Windows.Forms.GroupBox();
            this.txtTimkiemBC = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grbNhanvienBC
            // 
            this.grbNhanvienBC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbNhanvienBC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbNhanvienBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanvienBC.Location = new System.Drawing.Point(0, 294);
            this.grbNhanvienBC.Name = "grbNhanvienBC";
            this.grbNhanvienBC.Size = new System.Drawing.Size(863, 188);
            this.grbNhanvienBC.TabIndex = 1;
            this.grbNhanvienBC.TabStop = false;
            this.grbNhanvienBC.Text = "Nhân viên";
            // 
            // grbDoanhthuBC
            // 
            this.grbDoanhthuBC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grbDoanhthuBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDoanhthuBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDoanhthuBC.Location = new System.Drawing.Point(0, 0);
            this.grbDoanhthuBC.Name = "grbDoanhthuBC";
            this.grbDoanhthuBC.Size = new System.Drawing.Size(863, 220);
            this.grbDoanhthuBC.TabIndex = 2;
            this.grbDoanhthuBC.TabStop = false;
            this.grbDoanhthuBC.Text = "Doanh thu";
            // 
            // txtTimkiemBC
            // 
            this.txtTimkiemBC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimkiemBC.Location = new System.Drawing.Point(464, 262);
            this.txtTimkiemBC.Name = "txtTimkiemBC";
            this.txtTimkiemBC.Size = new System.Drawing.Size(288, 22);
            this.txtTimkiemBC.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(758, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlBaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimkiemBC);
            this.Controls.Add(this.grbDoanhthuBC);
            this.Controls.Add(this.grbNhanvienBC);
            this.Name = "pnlBaocao";
            this.Size = new System.Drawing.Size(863, 482);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNhanvienBC;
        private System.Windows.Forms.GroupBox grbDoanhthuBC;
        private System.Windows.Forms.TextBox txtTimkiemBC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
