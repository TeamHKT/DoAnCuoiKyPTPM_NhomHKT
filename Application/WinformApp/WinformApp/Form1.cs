using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            DangNhap frmdangnhap = new DangNhap();
            frmdangnhap.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblQLV.Hide();
            lblQLND.Hide();

        }

        private void btnQuanLySuKien_CheckedChanged(object sender, EventArgs e)
        {
            if (btnQuanLySuKien.Checked == true)
            {
                lblQLSK.Show();
                txtMaSK.Visible = true;
                lblMaSK.Visible = true;
                lblTenSK.Visible = true;
                txtTenSK.Visible = true;
                lblMaVe.Visible = false;
                txtMaVe.Visible = false;
                lblMaKH.Visible = false;
                txtMaKH.Visible = false;
                lblTenKH.Visible = false;
                txtTenKH.Visible = false;

            }
            else
            {
                lblQLSK.Hide();
                lblTenSK.Visible = false;
                txtTenSK.Visible = false;    
            }

        }

        private void btnQuanLyVe_CheckedChanged(object sender, EventArgs e)
        {
            if (btnQuanLyVe.Checked == true)
            {
                txtMaSK.Visible = true;
                lblMaSK.Visible = true;
                lblQLV.Show();
                lblMaVe.Visible = true;
                txtMaVe.Visible = true;
                lblTenSK.Visible = false;
                txtTenSK.Visible = false;
                lblMaKH.Visible = false;
                txtMaKH.Visible = false;
                lblTenKH.Visible = false;
                txtTenKH.Visible = false;

            }
            else 
            {
             lblQLV.Hide();
             txtMaSK.Visible = false;
             lblMaSK.Visible = false;
             lblMaVe.Visible = false;
             txtMaVe.Visible = false;
             txtMaSK.Visible = false;     

            }

        }

        private void btnQuanLyNguoiDung_CheckedChanged(object sender, EventArgs e)
        {
            if (btnQuanLyNguoiDung.Checked == true)
            {
                lblQLND.Show();
                lblMaKH.Visible = true;
                txtMaKH.Visible = true;
                lblTenKH.Visible = true;
                txtTenKH.Visible = true;
            }
            else { 
                lblQLND.Hide();
                lblMaKH.Visible = false;
                txtMaKH.Visible = false;
                lblTenKH.Visible= false;
                txtTenKH.Visible=false;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnQuanLySuKien.Checked == true)
            {
                //ThongTinSuKien frmttsk = new ThongTinSuKien();
                //frmttsk.Show();
                this.Close();

            }
        }


    }
}
