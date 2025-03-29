namespace LastTermProject
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnTrangChu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Label();
            this.pnDangNhap = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnBanHang = new System.Windows.Forms.Panel();
            this.BtnBanHang = new System.Windows.Forms.Label();
            this.pnBaoHanh = new System.Windows.Forms.Panel();
            this.btnBaoHanh = new System.Windows.Forms.Label();
            this.pnThietBi = new System.Windows.Forms.Panel();
            this.btnDonHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDonHang = new System.Windows.Forms.Panel();
            this.btnThietBi = new System.Windows.Forms.Label();
            this.pnPhanTich = new System.Windows.Forms.Panel();
            this.btnPhanTich = new System.Windows.Forms.Label();
            this.pnTaiChinh = new System.Windows.Forms.Panel();
            this.btnTaiChinh = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnMain = new System.Windows.Forms.Panel();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnTrangChu.SuspendLayout();
            this.pnDangNhap.SuspendLayout();
            this.pnBanHang.SuspendLayout();
            this.pnBaoHanh.SuspendLayout();
            this.pnThietBi.SuspendLayout();
            this.pnDonHang.SuspendLayout();
            this.pnPhanTich.SuspendLayout();
            this.pnTaiChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 34);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LastTermProject.Properties.Resources.NonVer_small;
            this.pictureBox2.Location = new System.Drawing.Point(1069, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnHide
            // 
            this.btnHide.AutoSize = true;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHide.Location = new System.Drawing.Point(1098, 10);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(24, 17);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = " - ";
            this.btnHide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            this.btnHide.MouseLeave += new System.EventHandler(this.btnHide_MouseLeave);
            this.btnHide.MouseHover += new System.EventHandler(this.btnHide_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(1126, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 17);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LastTermProject.Properties.Resources.Rect_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.pnTrangChu);
            this.flowLayoutPanel1.Controls.Add(this.pnDangNhap);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.pnBanHang);
            this.flowLayoutPanel1.Controls.Add(this.pnBaoHanh);
            this.flowLayoutPanel1.Controls.Add(this.pnThietBi);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.pnDonHang);
            this.flowLayoutPanel1.Controls.Add(this.pnPhanTich);
            this.flowLayoutPanel1.Controls.Add(this.pnTaiChinh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 702);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(8, 10, 41, 6);
            this.label3.Size = new System.Drawing.Size(149, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "+ Quản lý chung";
            // 
            // pnTrangChu
            // 
            this.pnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.pnTrangChu.Controls.Add(this.btnHome);
            this.pnTrangChu.Location = new System.Drawing.Point(2, 36);
            this.pnTrangChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTrangChu.Name = "pnTrangChu";
            this.pnTrangChu.Size = new System.Drawing.Size(196, 49);
            this.pnTrangChu.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Image = global::LastTermProject.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1, 3);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(8, 10, 44, 6);
            this.btnHome.Size = new System.Drawing.Size(198, 41);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "      Trang chủ";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // pnDangNhap
            // 
            this.pnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.pnDangNhap.Controls.Add(this.btnDangNhap);
            this.pnDangNhap.Location = new System.Drawing.Point(2, 89);
            this.pnDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnDangNhap.Name = "pnDangNhap";
            this.pnDangNhap.Size = new System.Drawing.Size(196, 49);
            this.pnDangNhap.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoSize = true;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDangNhap.Image = global::LastTermProject.Properties.Resources.login;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(2, 0);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Padding = new System.Windows.Forms.Padding(8, 10, 32, 6);
            this.btnDangNhap.Size = new System.Drawing.Size(193, 41);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "      Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.MouseLeave += new System.EventHandler(this.btnDangNhap_MouseLeave);
            this.btnDangNhap.MouseHover += new System.EventHandler(this.btnDangNhap_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(2, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8, 10, 41, 6);
            this.label2.Size = new System.Drawing.Size(192, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "+ Hoạt động kinh doanh";
            // 
            // pnBanHang
            // 
            this.pnBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.pnBanHang.Controls.Add(this.BtnBanHang);
            this.pnBanHang.Location = new System.Drawing.Point(2, 176);
            this.pnBanHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnBanHang.Name = "pnBanHang";
            this.pnBanHang.Size = new System.Drawing.Size(196, 49);
            this.pnBanHang.TabIndex = 4;
            // 
            // BtnBanHang
            // 
            this.BtnBanHang.AutoSize = true;
            this.BtnBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBanHang.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBanHang.Image = global::LastTermProject.Properties.Resources.Sell;
            this.BtnBanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBanHang.Location = new System.Drawing.Point(2, 3);
            this.BtnBanHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnBanHang.Name = "BtnBanHang";
            this.BtnBanHang.Padding = new System.Windows.Forms.Padding(8, 10, 52, 6);
            this.BtnBanHang.Size = new System.Drawing.Size(200, 41);
            this.BtnBanHang.TabIndex = 4;
            this.BtnBanHang.Text = "      Bán hàng";
            this.BtnBanHang.Click += new System.EventHandler(this.BtnBanHang_Click);
            this.BtnBanHang.MouseLeave += new System.EventHandler(this.BtnBanHang_MouseLeave);
            this.BtnBanHang.MouseHover += new System.EventHandler(this.BtnBanHang_MouseHover);
            // 
            // pnBaoHanh
            // 
            this.pnBaoHanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.pnBaoHanh.Controls.Add(this.btnBaoHanh);
            this.pnBaoHanh.Location = new System.Drawing.Point(2, 229);
            this.pnBaoHanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnBaoHanh.Name = "pnBaoHanh";
            this.pnBaoHanh.Size = new System.Drawing.Size(196, 49);
            this.pnBaoHanh.TabIndex = 4;
            // 
            // btnBaoHanh
            // 
            this.btnBaoHanh.AutoSize = true;
            this.btnBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoHanh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBaoHanh.Image = global::LastTermProject.Properties.Resources.Fix;
            this.btnBaoHanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoHanh.Location = new System.Drawing.Point(2, 3);
            this.btnBaoHanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnBaoHanh.Name = "btnBaoHanh";
            this.btnBaoHanh.Padding = new System.Windows.Forms.Padding(8, 10, 48, 6);
            this.btnBaoHanh.Size = new System.Drawing.Size(196, 41);
            this.btnBaoHanh.TabIndex = 5;
            this.btnBaoHanh.Text = "      Bảo hành";
            this.btnBaoHanh.Click += new System.EventHandler(this.btnBaoHanh_Click);
            this.btnBaoHanh.MouseLeave += new System.EventHandler(this.btnBaoHanh_MouseLeave);
            this.btnBaoHanh.MouseHover += new System.EventHandler(this.btnBaoHanh_MouseHover);
            // 
            // pnThietBi
            // 
            this.pnThietBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.pnThietBi.Controls.Add(this.btnDonHang);
            this.pnThietBi.Location = new System.Drawing.Point(2, 282);
            this.pnThietBi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnThietBi.Name = "pnThietBi";
            this.pnThietBi.Size = new System.Drawing.Size(196, 49);
            this.pnThietBi.TabIndex = 4;
            // 
            // btnDonHang
            // 
            this.btnDonHang.AutoSize = true;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDonHang.Image = global::LastTermProject.Properties.Resources.work;
            this.btnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.Location = new System.Drawing.Point(2, 3);
            this.btnDonHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Padding = new System.Windows.Forms.Padding(8, 10, 48, 6);
            this.btnDonHang.Size = new System.Drawing.Size(191, 41);
            this.btnDonHang.TabIndex = 9;
            this.btnDonHang.Text = "      Đặt hàng";
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            this.btnDonHang.MouseLeave += new System.EventHandler(this.btnDonHang_MouseLeave);
            this.btnDonHang.MouseHover += new System.EventHandler(this.btnDonHang_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(2, 333);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 10, 41, 6);
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "+ Quản lý hệ thống";
            // 
            // pnDonHang
            // 
            this.pnDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.pnDonHang.Controls.Add(this.btnThietBi);
            this.pnDonHang.Location = new System.Drawing.Point(2, 369);
            this.pnDonHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnDonHang.Name = "pnDonHang";
            this.pnDonHang.Size = new System.Drawing.Size(196, 49);
            this.pnDonHang.TabIndex = 4;
            // 
            // btnThietBi
            // 
            this.btnThietBi.AutoSize = true;
            this.btnThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietBi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThietBi.Image = global::LastTermProject.Properties.Resources.Devices;
            this.btnThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietBi.Location = new System.Drawing.Point(2, 3);
            this.btnThietBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Padding = new System.Windows.Forms.Padding(8, 10, 61, 6);
            this.btnThietBi.Size = new System.Drawing.Size(195, 41);
            this.btnThietBi.TabIndex = 6;
            this.btnThietBi.Text = "       Thiết bị";
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            this.btnThietBi.MouseLeave += new System.EventHandler(this.btnThietBi_MouseLeave);
            this.btnThietBi.MouseHover += new System.EventHandler(this.btnThietBi_MouseHover);
            // 
            // pnPhanTich
            // 
            this.pnPhanTich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.pnPhanTich.Controls.Add(this.btnPhanTich);
            this.pnPhanTich.Location = new System.Drawing.Point(2, 422);
            this.pnPhanTich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnPhanTich.Name = "pnPhanTich";
            this.pnPhanTich.Size = new System.Drawing.Size(196, 49);
            this.pnPhanTich.TabIndex = 4;
            // 
            // btnPhanTich
            // 
            this.btnPhanTich.AutoSize = true;
            this.btnPhanTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanTich.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPhanTich.Image = global::LastTermProject.Properties.Resources.saved_search;
            this.btnPhanTich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanTich.Location = new System.Drawing.Point(2, 3);
            this.btnPhanTich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnPhanTich.Name = "btnPhanTich";
            this.btnPhanTich.Padding = new System.Windows.Forms.Padding(8, 10, 52, 6);
            this.btnPhanTich.Size = new System.Drawing.Size(198, 41);
            this.btnPhanTich.TabIndex = 7;
            this.btnPhanTich.Text = "      Phân tích";
            this.btnPhanTich.Click += new System.EventHandler(this.btnPhanTich_Click);
            this.btnPhanTich.MouseLeave += new System.EventHandler(this.btnPhanTich_MouseLeave);
            this.btnPhanTich.MouseHover += new System.EventHandler(this.btnPhanTich_MouseHover);
            // 
            // pnTaiChinh
            // 
            this.pnTaiChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.pnTaiChinh.Controls.Add(this.btnTaiChinh);
            this.pnTaiChinh.Location = new System.Drawing.Point(2, 475);
            this.pnTaiChinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTaiChinh.Name = "pnTaiChinh";
            this.pnTaiChinh.Size = new System.Drawing.Size(196, 49);
            this.pnTaiChinh.TabIndex = 4;
            // 
            // btnTaiChinh
            // 
            this.btnTaiChinh.AutoSize = true;
            this.btnTaiChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiChinh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTaiChinh.Image = global::LastTermProject.Properties.Resources.monetization_on;
            this.btnTaiChinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiChinh.Location = new System.Drawing.Point(1, 3);
            this.btnTaiChinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTaiChinh.Name = "btnTaiChinh";
            this.btnTaiChinh.Padding = new System.Windows.Forms.Padding(8, 10, 56, 6);
            this.btnTaiChinh.Size = new System.Drawing.Size(201, 41);
            this.btnTaiChinh.TabIndex = 8;
            this.btnTaiChinh.Text = "      Tài chính";
            this.btnTaiChinh.Click += new System.EventHandler(this.btnTaiChinh_Click);
            this.btnTaiChinh.MouseLeave += new System.EventHandler(this.btnTaiChinh_MouseLeave);
            this.btnTaiChinh.MouseHover += new System.EventHandler(this.btnTaiChinh_MouseHover);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(200, 34);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(952, 702);
            this.pnMain.TabIndex = 2;
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 30;
            this.sataEllipseControl1.TargetControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1152, 736);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnTrangChu.ResumeLayout(false);
            this.pnTrangChu.PerformLayout();
            this.pnDangNhap.ResumeLayout(false);
            this.pnDangNhap.PerformLayout();
            this.pnBanHang.ResumeLayout(false);
            this.pnBanHang.PerformLayout();
            this.pnBaoHanh.ResumeLayout(false);
            this.pnBaoHanh.PerformLayout();
            this.pnThietBi.ResumeLayout(false);
            this.pnThietBi.PerformLayout();
            this.pnDonHang.ResumeLayout(false);
            this.pnDonHang.PerformLayout();
            this.pnPhanTich.ResumeLayout(false);
            this.pnPhanTich.PerformLayout();
            this.pnTaiChinh.ResumeLayout(false);
            this.pnTaiChinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label btnHide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnTrangChu;
        private System.Windows.Forms.Label btnHome;
        private System.Windows.Forms.Panel pnDangNhap;
        private System.Windows.Forms.Panel pnBanHang;
        private System.Windows.Forms.Panel pnBaoHanh;
        private System.Windows.Forms.Panel pnThietBi;
        private System.Windows.Forms.Panel pnPhanTich;
        private System.Windows.Forms.Panel pnTaiChinh;
        private System.Windows.Forms.Panel pnDonHang;
        private System.Windows.Forms.Label btnDangNhap;
        private System.Windows.Forms.Label BtnBanHang;
        private System.Windows.Forms.Label btnBaoHanh;
        private System.Windows.Forms.Label btnThietBi;
        private System.Windows.Forms.Label btnPhanTich;
        private System.Windows.Forms.Label btnTaiChinh;
        private System.Windows.Forms.Label btnDonHang;
        private System.Windows.Forms.Panel pnMain;
        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

