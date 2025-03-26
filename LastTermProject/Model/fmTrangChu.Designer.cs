namespace LastTermProject.Model
{
    partial class fmTrangChu
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
            this.txtControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtControl
            // 
            this.txtControl.AutoSize = true;
            this.txtControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtControl.Image = global::LastTermProject.Properties.Resources.menu;
            this.txtControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtControl.Location = new System.Drawing.Point(12, 9);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(207, 29);
            this.txtControl.TabIndex = 3;
            this.txtControl.Text = "           Trang chủ";
            // 
            // fmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 934);
            this.Controls.Add(this.txtControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmTrangChu";
            this.Text = "fmTrangChu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtControl;
    }
}