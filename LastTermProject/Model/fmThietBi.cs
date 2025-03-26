using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastTermProject.Model
{
    public partial class fmThietBi : Form
    {
        public fmThietBi()
        {
            InitializeComponent();
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

        private void txtMau_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!checkTu(txtMau.Text))
            {
                this.errorProvider1.SetError(ctr, "Phải nhập chữ");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!checkSo(txtSL.Text))
            {
                this.errorProvider1.SetError(ctr, "Phải nhập chữ");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnXT_Click(object sender, EventArgs e)
        {
            txtSP.ResetText();
            txtSP.Focus();
            txtTenSP.ResetText();
            txtKM.ResetText();
            txtDG.ResetText();
            txtSL.ResetText();
            txtMau.ResetText();
        }

        private void txtDG_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (!checkSo(txtDG.Text))
            {
                this.errorProvider1.SetError(ctr, "Phải nhập chữ");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
