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
    public partial class fmDangNhap : Form
    {
        bool passVisible = false;
        public fmDangNhap()
        {
            InitializeComponent();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (passVisible == false)
            {
                //txtPassword.UseSystemPasswordChar = false;
                btnVisible.Image = Properties.Resources.remove_red_eye;
                passVisible = true;
            }
            else
            {
                //txtPassword.UseSystemPasswordChar = true;
                btnVisible.Image = Properties.Resources.remove_red_eye_cover;
                passVisible = false;
            }
        }
    }
}
