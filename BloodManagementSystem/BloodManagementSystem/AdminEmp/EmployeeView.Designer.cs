namespace BloodManagementSystem
{
    partial class EmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            this.Panel_Emp = new System.Windows.Forms.Panel();
            this.PicDonProfile = new System.Windows.Forms.PictureBox();
            this.lbl_hi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Donation = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Blood = new Guna.UI.WinForms.GunaLabel();
            this.lbl_NewDon = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Home = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel_EmpDisplay = new System.Windows.Forms.Panel();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicDonProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Emp
            // 
            this.Panel_Emp.Controls.Add(this.PicDonProfile);
            this.Panel_Emp.Controls.Add(this.lbl_hi);
            this.Panel_Emp.Controls.Add(this.lbl_Donation);
            this.Panel_Emp.Controls.Add(this.lbl_Blood);
            this.Panel_Emp.Controls.Add(this.lbl_NewDon);
            this.Panel_Emp.Controls.Add(this.lbl_Home);
            this.Panel_Emp.Controls.Add(this.gunaLabel2);
            this.Panel_Emp.Controls.Add(this.pictureBox2);
            this.Panel_Emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Emp.Location = new System.Drawing.Point(0, 0);
            this.Panel_Emp.Name = "Panel_Emp";
            this.Panel_Emp.Size = new System.Drawing.Size(984, 88);
            this.Panel_Emp.TabIndex = 1;
            // 
            // PicDonProfile
            // 
            this.PicDonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicDonProfile.BackgroundImage")));
            this.PicDonProfile.ContextMenuStrip = this.gunaContextMenuStrip1;
            this.PicDonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicDonProfile.Location = new System.Drawing.Point(916, 18);
            this.PicDonProfile.Name = "PicDonProfile";
            this.PicDonProfile.Size = new System.Drawing.Size(56, 46);
            this.PicDonProfile.TabIndex = 26;
            this.PicDonProfile.TabStop = false;
            // 
            // lbl_hi
            // 
            this.lbl_hi.Location = new System.Drawing.Point(819, 29);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(91, 26);
            this.lbl_hi.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hi.TabIndex = 25;
            this.lbl_hi.Values.Text = "EmpName";
            // 
            // lbl_Donation
            // 
            this.lbl_Donation.AutoSize = true;
            this.lbl_Donation.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Donation.ForeColor = System.Drawing.Color.Red;
            this.lbl_Donation.Location = new System.Drawing.Point(599, 36);
            this.lbl_Donation.Name = "lbl_Donation";
            this.lbl_Donation.Size = new System.Drawing.Size(77, 19);
            this.lbl_Donation.TabIndex = 24;
            this.lbl_Donation.Text = "Donation";
            this.lbl_Donation.Click += new System.EventHandler(this.lbl_Donation_Click);
            // 
            // lbl_Blood
            // 
            this.lbl_Blood.AutoSize = true;
            this.lbl_Blood.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blood.ForeColor = System.Drawing.Color.Red;
            this.lbl_Blood.Location = new System.Drawing.Point(693, 36);
            this.lbl_Blood.Name = "lbl_Blood";
            this.lbl_Blood.Size = new System.Drawing.Size(99, 19);
            this.lbl_Blood.TabIndex = 23;
            this.lbl_Blood.Text = "Blood Stock";
            // 
            // lbl_NewDon
            // 
            this.lbl_NewDon.AutoSize = true;
            this.lbl_NewDon.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewDon.ForeColor = System.Drawing.Color.Red;
            this.lbl_NewDon.Location = new System.Drawing.Point(470, 36);
            this.lbl_NewDon.Name = "lbl_NewDon";
            this.lbl_NewDon.Size = new System.Drawing.Size(114, 19);
            this.lbl_NewDon.TabIndex = 22;
            this.lbl_NewDon.Text = "New Donation";
            this.lbl_NewDon.Click += new System.EventHandler(this.lbl_NewDon_Click);
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.Red;
            this.lbl_Home.Location = new System.Drawing.Point(392, 36);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(53, 19);
            this.lbl_Home.TabIndex = 21;
            this.lbl_Home.Text = "Home";
            this.lbl_Home.Click += new System.EventHandler(this.lbl_Home_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.gunaLabel2.Location = new System.Drawing.Point(90, 18);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(138, 58);
            this.gunaLabel2.TabIndex = 18;
            this.gunaLabel2.Text = "National \r\nBlood Bank";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Panel_EmpDisplay
            // 
            this.Panel_EmpDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_EmpDisplay.Location = new System.Drawing.Point(0, 88);
            this.Panel_EmpDisplay.Name = "Panel_EmpDisplay";
            this.Panel_EmpDisplay.Size = new System.Drawing.Size(984, 470);
            this.Panel_EmpDisplay.TabIndex = 2;
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(166, 48);
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            this.manageAccountToolStripMenuItem.Click += new System.EventHandler(this.manageAccountToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 558);
            this.Controls.Add(this.Panel_EmpDisplay);
            this.Controls.Add(this.Panel_Emp);
            this.Name = "EmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeView";
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            this.Panel_Emp.ResumeLayout(false);
            this.Panel_Emp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicDonProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Emp;
        private System.Windows.Forms.Panel Panel_EmpDisplay;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaLabel lbl_Donation;
        private Guna.UI.WinForms.GunaLabel lbl_Blood;
        private Guna.UI.WinForms.GunaLabel lbl_NewDon;
        private Guna.UI.WinForms.GunaLabel lbl_Home;
        private System.Windows.Forms.PictureBox PicDonProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_hi;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}