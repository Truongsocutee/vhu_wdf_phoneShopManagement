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
    public partial class fmDonHang : Form
    {
        public fmDonHang()
        {
            InitializeComponent();
        }

        private void fmDonHang_Load(object sender, EventArgs e)
        {
            txtNgayGD.Text = DateTime.Now.ToString("dd / MM / yyyy");
            for (int i = 1; i < 11; i++)
                cbxSoLuong.Items.Add(i.ToString());
        }
    }
}
