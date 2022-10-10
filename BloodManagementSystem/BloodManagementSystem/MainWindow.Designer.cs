namespace BloodManagementSystem
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblHome = new Guna.UI.WinForms.GunaLabel();
            this.lbl_AdminView = new Guna.UI.WinForms.GunaLabel();
            this.lblAboutUs = new Guna.UI.WinForms.GunaLabel();
            this.lblDonor = new Guna.UI.WinForms.GunaLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.Panel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Location = new System.Drawing.Point(505, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(813, 103);
            this.gunaPanel1.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Red;
            this.lblHome.Location = new System.Drawing.Point(120, 639);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(68, 25);
            this.lblHome.TabIndex = 10;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.lblHome.MouseLeave += new System.EventHandler(this.lblHome_MouseLeave);
            this.lblHome.MouseHover += new System.EventHandler(this.gunaLabel2_MouseHover);
            // 
            // lbl_AdminView
            // 
            this.lbl_AdminView.AutoSize = true;
            this.lbl_AdminView.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminView.ForeColor = System.Drawing.Color.Red;
            this.lbl_AdminView.Location = new System.Drawing.Point(477, 639);
            this.lbl_AdminView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AdminView.Name = "lbl_AdminView";
            this.lbl_AdminView.Size = new System.Drawing.Size(75, 25);
            this.lbl_AdminView.TabIndex = 9;
            this.lbl_AdminView.Text = "Admin";
            this.lbl_AdminView.Click += new System.EventHandler(this.lbl_AdminView_Click);
            this.lbl_AdminView.MouseLeave += new System.EventHandler(this.lbl_AdminView_MouseLeave);
            this.lbl_AdminView.MouseHover += new System.EventHandler(this.lbl_AdminView_MouseHover);
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.ForeColor = System.Drawing.Color.Red;
            this.lblAboutUs.Location = new System.Drawing.Point(648, 639);
            this.lblAboutUs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(100, 25);
            this.lblAboutUs.TabIndex = 8;
            this.lblAboutUs.Text = "About Us";
            this.lblAboutUs.MouseLeave += new System.EventHandler(this.lblAboutUs_MouseLeave);
            this.lblAboutUs.MouseHover += new System.EventHandler(this.lblAboutUs_MouseHover);
            // 
            // lblDonor
            // 
            this.lblDonor.AutoSize = true;
            this.lblDonor.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonor.ForeColor = System.Drawing.Color.Red;
            this.lblDonor.Location = new System.Drawing.Point(288, 639);
            this.lblDonor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(71, 25);
            this.lblDonor.TabIndex = 5;
            this.lblDonor.Text = "Donor";
            this.lblDonor.Click += new System.EventHandler(this.gunaLabel1_Click);
            this.lblDonor.MouseLeave += new System.EventHandler(this.lblDonor_MouseLeave);
            this.lblDonor.MouseHover += new System.EventHandler(this.lblDonor_MouseHover);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(319, 13);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(347, 52);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "National Blood Bank";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(684, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 99);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Maroon;
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(505, 687);
            this.gunaPanel2.TabIndex = 1;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.gunaPanel3);
            this.Panel3.Controls.Add(this.pictureBox1);
            this.Panel3.Controls.Add(this.kryptonLabel1);
            this.Panel3.Controls.Add(this.lblHome);
            this.Panel3.Controls.Add(this.lblAboutUs);
            this.Panel3.Controls.Add(this.lbl_AdminView);
            this.Panel3.Controls.Add(this.lblDonor);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(505, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(814, 687);
            this.Panel3.TabIndex = 2;
            this.Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Location = new System.Drawing.Point(4, 111);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(809, 500);
            this.gunaPanel3.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1319, 687);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel lblDonor;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel lbl_AdminView;
        private Guna.UI.WinForms.GunaLabel lblAboutUs;
        private Guna.UI.WinForms.GunaLabel lblHome;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel Panel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
    }
}