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
    public partial class fmPhanTich : Form
    {
        public fmPhanTich()
        {
            InitializeComponent();
        }

        private void fmPhanTich_Load(object sender, EventArgs e)
        {
            cbxPKG.Items.Add("Dưới 1 triệu");
            cbxPKG.Items.Add("1 - 5 triệu");
            cbxPKG.Items.Add("7 -10 triệu");
            cbxPKG.Items.Add("Trên 10 triệu");
            cbxDT.Items.Add("Dưới 15");
            cbxDT.Items.Add("15 - 24");
            cbxDT.Items.Add("25-35");
            cbxDT.Items.Add("Trên 35");
        }
    }
}
