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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
<<<<<<< HEAD
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.Panel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
=======
>>>>>>> 6c8045bb75e5fe5c16691cb1b7ce2b537a118c4d
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblHome = new Guna.UI.WinForms.GunaLabel();
            this.lblAboutUs = new Guna.UI.WinForms.GunaLabel();
            this.lblAdminView = new Guna.UI.WinForms.GunaLabel();
            this.lblDonor = new Guna.UI.WinForms.GunaLabel();
<<<<<<< HEAD
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.Panel3.SuspendLayout();
=======
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
>>>>>>> 6c8045bb75e5fe5c16691cb1b7ce2b537a118c4d
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 80);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
<<<<<<< HEAD
            this.Panel3.Controls.Add(this.gunaPanel3);
            this.Panel3.Controls.Add(this.pictureBox1);
            this.Panel3.Controls.Add(this.kryptonLabel1);
            this.Panel3.Controls.Add(this.lblHome);
            this.Panel3.Controls.Add(this.lblAboutUs);
            this.Panel3.Controls.Add(this.lblAdminView);
            this.Panel3.Controls.Add(this.lblDonor);
            this.Panel3.Controls.Add(this.gunaPanel2);
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1319, 687);
            this.Panel3.TabIndex = 2;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel3.Location = new System.Drawing.Point(509, 121);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(809, 500);
            this.gunaPanel3.TabIndex = 12;
=======
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.Location = new System.Drawing.Point(106, 23);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(279, 42);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "National Blood Bank";
            this.kryptonLabel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
>>>>>>> 6c8045bb75e5fe5c16691cb1b7ce2b537a118c4d
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1189, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 99);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.Location = new System.Drawing.Point(834, 13);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(347, 52);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "National Blood Bank";
            // 
            // lblHome
            // 
            this.lblHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Red;
            this.lblHome.Location = new System.Drawing.Point(625, 36);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(53, 19);
            this.lblHome.TabIndex = 16;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            this.lblHome.MouseLeave += new System.EventHandler(this.lblHome_MouseLeave);
            this.lblHome.MouseHover += new System.EventHandler(this.lblHome_MouseHover);
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.ForeColor = System.Drawing.Color.Red;
            this.lblAboutUs.Location = new System.Drawing.Point(916, 36);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(76, 19);
            this.lblAboutUs.TabIndex = 14;
            this.lblAboutUs.Text = "About Us";
            this.lblAboutUs.Click += new System.EventHandler(this.lblAboutUs_Click);
            this.lblAboutUs.MouseLeave += new System.EventHandler(this.lblAboutUs_MouseLeave);
            this.lblAboutUs.MouseHover += new System.EventHandler(this.lblAboutUs_MouseHover);
            // 
            // lblAdminView
            // 
            this.lblAdminView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminView.AutoSize = true;
            this.lblAdminView.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminView.ForeColor = System.Drawing.Color.Red;
            this.lblAdminView.Location = new System.Drawing.Point(808, 36);
            this.lblAdminView.Name = "lblAdminView";
            this.lblAdminView.Size = new System.Drawing.Size(58, 19);
            this.lblAdminView.TabIndex = 15;
            this.lblAdminView.Text = "Admin";
            this.lblAdminView.Click += new System.EventHandler(this.lbl_AdminView_Click_1);
            this.lblAdminView.MouseLeave += new System.EventHandler(this.lblAdminView_MouseLeave);
            this.lblAdminView.MouseHover += new System.EventHandler(this.lbl_AdminView_MouseHover);
            // 
            // lblDonor
            // 
            this.lblDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonor.AutoSize = true;
            this.lblDonor.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonor.ForeColor = System.Drawing.Color.Red;
            this.lblDonor.Location = new System.Drawing.Point(712, 36);
            this.lblDonor.Name = "lblDonor";
            this.lblDonor.Size = new System.Drawing.Size(56, 19);
            this.lblDonor.TabIndex = 13;
            this.lblDonor.Text = "Donor";
            this.lblDonor.Click += new System.EventHandler(this.lblDonor_Click);
            this.lblDonor.MouseLeave += new System.EventHandler(this.lblDonor_MouseLeave);
            this.lblDonor.MouseHover += new System.EventHandler(this.lblDonor_MouseHover);
            // 
<<<<<<< HEAD
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Maroon;
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(505, 687);
            this.gunaPanel2.TabIndex = 2;
=======
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 458);
            this.panel1.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 100000;
            //this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
>>>>>>> 6c8045bb75e5fe5c16691cb1b7ce2b537a118c4d
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblDonor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAboutUs);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblAdminView);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Guna.UI.WinForms.GunaLabel lblHome;
        private Guna.UI.WinForms.GunaLabel lblAboutUs;
        private Guna.UI.WinForms.GunaLabel lblAdminView;
        private Guna.UI.WinForms.GunaLabel lblDonor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}