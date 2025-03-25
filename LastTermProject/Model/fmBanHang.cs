using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastTermProject.Model
{
    public partial class fmBanHang : Form
    {
        public fmBanHang()
        {
            InitializeComponent();
        }

        private void fmBanHang_Load(object sender, EventArgs e)
        {
            txtNgayGD.Text = DateTime.Now.ToString("dd / MM / yyyy");
            for (int i=1; i<11;  i++) 
                cbxSoLuong.Items.Add(i.ToString());
        }

        private void btnXT_Click(object sender, EventArgs e)
        {
            txtKH.ResetText();
            txtSoKH.ResetText();    
            txtKH.Focus();
        }

        static bool checkTu(string text)
        {
            foreach (char c in text)
            {
                if (c < 'A' || c > 'z') return false;
            }
            return true;
        }

        static bool checkSo(string text)
        {
            foreach (char c in text)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }

        private void txtKH_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!checkTu(txtKH.Text))
            {
                this.errorProvider1.SetError(ctr, "Phải nhập chữ");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtSoKH_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!checkSo(txtSoKH.Text))
            {
                this.errorProvider1.SetError(ctr, "Phải nhập số");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
