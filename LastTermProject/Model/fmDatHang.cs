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
    public partial class fmDatHang : Form
    {
        public fmDatHang()
        {
            InitializeComponent();
        }

        private void fmDatHang_Load(object sender, EventArgs e)
        {
            txtNgayGD.Text = DateTime.Now.ToString("dd / MM / yyyy");
        }
    }
}
