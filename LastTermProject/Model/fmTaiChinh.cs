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
    public partial class fmTaiChinh : Form
    {
        public fmTaiChinh()
        {
            InitializeComponent();
        }

        private void fmTaiChinh_Load(object sender, EventArgs e)
        {
            for (int i = 2017; i < 2030; i++)
                cbxNam.Items.Add(i.ToString());
            for (int i = 1; i < 5; i++)
                cbxQuy.Items.Add(i.ToString());
            for (int i = 1; i < 13; i++)
                cbxThang.Items.Add(i.ToString());
            for (int i = 1; i < 32; i++)
                cbxNgay.Items.Add(i.ToString());
        }
    }
}
