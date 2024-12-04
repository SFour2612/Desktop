using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }
        private void ShowUserControl(UserControl userControl)
        {
            pnlTrangchu.Controls.Clear(); // Xóa nội dung hiện tại trong Panel
            userControl.Dock = DockStyle.Fill; // Đặt User Control chiếm toàn bộ Panel
            pnlTrangchu.Controls.Add(userControl); // Thêm User Control vào Panel
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Phong());



        }


        private void Trangchu_Load(object sender, EventArgs e)
        {

         
            pnlTrangchu.Visible = true;
        }

        private void grbTrangthai_Enter(object sender, EventArgs e)
        {

        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            ShowUserControl(new DichVu());


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            ShowUserControl(new pnlBaocao());
        }

        private void btnQuanly_Click(object sender, EventArgs e)
        {
            ShowUserControl(new QuanLy());
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            ShowUserControl(new HoaDon());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTrangchu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemphong_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaphong_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaphong_Click(object sender, EventArgs e)
        {

        }

        private void rdbTrong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDaduocdat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            ShowUserControl(new KhachHang());
        }

        private void dgvDIc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbLoaidichvu_Enter(object sender, EventArgs e)
        {

        }

        private void rdbDoan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbDouong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbKhac_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMasanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaisanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ngăn người dùng nhập ký tự không hợp lệ
            }
        }

        private void txtSodienthoai_TextChanged(object sender, EventArgs e)
        {
        //    if (txtSodienthoai.Text.Length > 10) // Giới hạn số ký tự
        //    {
        //        MessageBox.Show("Số điện thoại không được vượt quá 10 số.");
        //        txtSodienthoai.Text = txtSodienthoai.Text.Substring(0, 10);
        //    }
        }
    }
}
