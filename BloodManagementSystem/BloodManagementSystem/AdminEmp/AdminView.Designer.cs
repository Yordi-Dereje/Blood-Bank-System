namespace BloodManagementSystem
{
    partial class AdminView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminView));
            this.lbl_Donation = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Employee = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.lbl_Branch = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Hospital = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Home = new Guna.UI.WinForms.GunaLabel();
            this.PicDonProfile = new System.Windows.Forms.PictureBox();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.ManageAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_hi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.gunaContextMenuStrip2 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDonProfile)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.gunaContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Donation
            // 
            this.lbl_Donation.AutoSize = true;
            this.lbl_Donation.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Donation.ForeColor = System.Drawing.Color.Red;
            this.lbl_Donation.Location = new System.Drawing.Point(431, 32);
            this.lbl_Donation.Name = "lbl_Donation";
            this.lbl_Donation.Size = new System.Drawing.Size(77, 19);
            this.lbl_Donation.TabIndex = 13;
            this.lbl_Donation.Text = "Donation";
            this.lbl_Donation.Click += new System.EventHandler(this.lbl_Donation_Click);
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.ContextMenuStrip = this.gunaContextMenuStrip2;
            this.lbl_Employee.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee.Location = new System.Drawing.Point(533, 32);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(82, 19);
            this.lbl_Employee.TabIndex = 14;
            this.lbl_Employee.Text = "Employee";
            this.lbl_Employee.Click += new System.EventHandler(this.lbl_Employee_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.lbl_Branch);
            this.gunaPanel3.Controls.Add(this.gunaLabel2);
            this.gunaPanel3.Controls.Add(this.lbl_Hospital);
            this.gunaPanel3.Controls.Add(this.pictureBox2);
            this.gunaPanel3.Controls.Add(this.lbl_Donation);
            this.gunaPanel3.Controls.Add(this.lbl_Home);
            this.gunaPanel3.Controls.Add(this.PicDonProfile);
            this.gunaPanel3.Controls.Add(this.lbl_Employee);
            this.gunaPanel3.Controls.Add(this.lbl_hi);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(984, 85);
            this.gunaPanel3.TabIndex = 1;
            // 
            // lbl_Branch
            // 
            this.lbl_Branch.AutoSize = true;
            this.lbl_Branch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Branch.ForeColor = System.Drawing.Color.Red;
            this.lbl_Branch.Location = new System.Drawing.Point(719, 32);
            this.lbl_Branch.Name = "lbl_Branch";
            this.lbl_Branch.Size = new System.Drawing.Size(63, 19);
            this.lbl_Branch.TabIndex = 18;
            this.lbl_Branch.Text = "Branch";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.gunaLabel2.Location = new System.Drawing.Point(96, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(138, 58);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "National \r\nBlood Bank";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Hospital
            // 
            this.lbl_Hospital.AutoSize = true;
            this.lbl_Hospital.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hospital.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hospital.Location = new System.Drawing.Point(624, 32);
            this.lbl_Hospital.Name = "lbl_Hospital";
            this.lbl_Hospital.Size = new System.Drawing.Size(73, 19);
            this.lbl_Hospital.TabIndex = 17;
            this.lbl_Hospital.Text = "Hospital";
            this.lbl_Hospital.Click += new System.EventHandler(this.lbl_Hospital_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.ForeColor = System.Drawing.Color.Red;
            this.lbl_Home.Location = new System.Drawing.Point(351, 32);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(53, 19);
            this.lbl_Home.TabIndex = 12;
            this.lbl_Home.Text = "Home";
            this.lbl_Home.Click += new System.EventHandler(this.lbl_Home_Click);
            // 
            // PicDonProfile
            // 
            this.PicDonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicDonProfile.BackgroundImage")));
            this.PicDonProfile.ContextMenuStrip = this.gunaContextMenuStrip1;
            this.PicDonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicDonProfile.Location = new System.Drawing.Point(911, 21);
            this.PicDonProfile.Name = "PicDonProfile";
            this.PicDonProfile.Size = new System.Drawing.Size(56, 46);
            this.PicDonProfile.TabIndex = 7;
            this.PicDonProfile.TabStop = false;
            this.PicDonProfile.ContextMenuStripChanged += new System.EventHandler(this.PicDonProfile_MouseHover);
            this.PicDonProfile.Click += new System.EventHandler(this.PicDonProfile_Click);
            this.PicDonProfile.MouseHover += new System.EventHandler(this.PicDonProfile_MouseHover);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageAccToolStripMenuItem,
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
            // ManageAccToolStripMenuItem
            // 
            this.ManageAccToolStripMenuItem.Name = "ManageAccToolStripMenuItem";
            this.ManageAccToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ManageAccToolStripMenuItem.Text = "Manage Account";
            this.ManageAccToolStripMenuItem.Click += new System.EventHandler(this.ManageAccToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // lbl_hi
            // 
            this.lbl_hi.Location = new System.Drawing.Point(795, 32);
            this.lbl_hi.Name = "lbl_hi";
            this.lbl_hi.Size = new System.Drawing.Size(110, 26);
            this.lbl_hi.StateCommon.ShortText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hi.TabIndex = 6;
            this.lbl_hi.Values.Text = "AdminName";
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAdmin.Location = new System.Drawing.Point(0, 85);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(984, 473);
            this.PanelAdmin.TabIndex = 2;
            // 
            // gunaContextMenuStrip2
            // 
            this.gunaContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.eDITToolStripMenuItem});
            this.gunaContextMenuStrip2.Name = "gunaContextMenuStrip2";
            this.gunaContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip2.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip2.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip2.Size = new System.Drawing.Size(99, 48);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.aDDToolStripMenuItem.Text = "ADD";
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 558);
            this.Controls.Add(this.PanelAdmin);
            this.Controls.Add(this.gunaPanel3);
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminViews";
            this.Load += new System.EventHandler(this.AdminViews_Load);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDonProfile)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.gunaContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private System.Windows.Forms.PictureBox PicDonProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_hi;
        private Guna.UI.WinForms.GunaLabel lbl_Donation;
        private Guna.UI.WinForms.GunaLabel lbl_Employee;
        private Guna.UI.WinForms.GunaLabel lbl_Home;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManageAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PanelAdmin;
        private Guna.UI.WinForms.GunaLabel lbl_Branch;
        private Guna.UI.WinForms.GunaLabel lbl_Hospital;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
    }
}