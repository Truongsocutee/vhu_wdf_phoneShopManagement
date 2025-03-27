using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LastTermProject.Model;

namespace LastTermProject
{
    public partial class Main : Form
    {

        //Color define
        Color btnNonHoverClicked = Color.FromArgb(35, 104, 187);
        Color btnHoverClicked = Color.FromArgb(0, 65, 144);
        Color btnNonHoverNonClicked = Color.FromArgb(41, 78, 122);
        Color btnHoverNonClicked = Color.FromArgb(33, 59, 90);
        public Main()
        {
            InitializeComponent();


        }
      


        //Keo tha Form (Style Border == none)
        private bool dragging = false;
        private Point lastLoc;
        private Point formLoc;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(lastLoc));
                this.Location = Point.Add(formLoc, new Size(dif));

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
         
            dragging = true;
            lastLoc = Cursor.Position;
            formLoc = this.Location;
        }

     
        //Tat Mo Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(33, 59, 90);

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            updateControl(0);
            updateVision(new fmTrangChu());
        }

        bool[] select = new bool[8];
        int lastIdx = 0;
        Panel[] panels;
        private void Main_Load(object sender, EventArgs e)
        {
            for (int i=0; i<select.Length; i++)
            {
                select[i] = false;
            }
            panels = new Panel[8] {pnTrangChu, pnDangNhap, pnBanHang, pnBaoHanh, pnThietBi, pnPhanTich, pnTaiChinh, pnDonHang};
            
        }

        private void updateControl(int tab)
        {
            select[tab] = true;
            select[lastIdx] = false;
            //Update màu
            panels[lastIdx].BackColor = btnNonHoverNonClicked;
            panels[tab].BackColor = btnNonHoverClicked;
            //Cập nhật index
            lastIdx = tab;
        }

        private void btnHide_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(33, 59, 90);
        }

        private void btnHide_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            updateControl(1);
            updateVision(new fmDangNhap());

        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            updateControl(2);
            updateVision(new fmBanHang());
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            updateControl(3);
            updateVision(new fmBaoHanh());
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            updateControl(7);
            updateVision(new fmThietBi());
        }

        private void btnPhanTich_Click(object sender, EventArgs e)
        {
            updateControl(5);
            updateVision(new fmPhanTich());
        }

        private void btnTaiChinh_Click(object sender, EventArgs e)
        {
            updateControl(6);
            updateVision(new fmTaiChinh());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            updateControl(4);
            updateVision(new fmDonHang());
        }


        //Update Control
        private void updateVision(object form)
        {
            if (this.pnMain.Controls.Count > 0)
            {
                this.pnMain.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(f);
            this.pnMain.Tag = f;
            f.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
