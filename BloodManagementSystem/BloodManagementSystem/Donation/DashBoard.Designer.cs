namespace BloodManagementSystem
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btn_Donor = new Guna.UI.WinForms.GunaButton();
            this.btn_Transfer = new Guna.UI.WinForms.GunaButton();
            this.btn_Donations = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(565, 12);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(118, 28);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.Red;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 14;
            this.kryptonLabel5.Values.Text = "DashBoard";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(291, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 450);
            this.panel1.TabIndex = 17;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Maroon;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Times New Roman", 16.25F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(28, 413);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(208, 103);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "Blood Stock";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btn_Donor
            // 
            this.btn_Donor.AnimationHoverSpeed = 0.07F;
            this.btn_Donor.AnimationSpeed = 0.03F;
            this.btn_Donor.BaseColor = System.Drawing.Color.Maroon;
            this.btn_Donor.BorderColor = System.Drawing.Color.Black;
            this.btn_Donor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Donor.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Donor.Font = new System.Drawing.Font("Times New Roman", 16.25F);
            this.btn_Donor.ForeColor = System.Drawing.Color.White;
            this.btn_Donor.Image = ((System.Drawing.Image)(resources.GetObject("btn_Donor.Image")));
            this.btn_Donor.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Donor.Location = new System.Drawing.Point(28, 36);
            this.btn_Donor.Name = "btn_Donor";
            this.btn_Donor.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.btn_Donor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Donor.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Donor.OnHoverImage = null;
            this.btn_Donor.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Donor.Size = new System.Drawing.Size(208, 103);
            this.btn_Donor.TabIndex = 18;
            this.btn_Donor.Text = "Donor";
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.AnimationHoverSpeed = 0.07F;
            this.btn_Transfer.AnimationSpeed = 0.03F;
            this.btn_Transfer.BaseColor = System.Drawing.Color.Maroon;
            this.btn_Transfer.BorderColor = System.Drawing.Color.Black;
            this.btn_Transfer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Transfer.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Transfer.Font = new System.Drawing.Font("Times New Roman", 16.25F);
            this.btn_Transfer.ForeColor = System.Drawing.Color.White;
            this.btn_Transfer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Transfer.Image")));
            this.btn_Transfer.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Transfer.Location = new System.Drawing.Point(28, 163);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.btn_Transfer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Transfer.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Transfer.OnHoverImage = null;
            this.btn_Transfer.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Transfer.Size = new System.Drawing.Size(208, 103);
            this.btn_Transfer.TabIndex = 19;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // btn_Donations
            // 
            this.btn_Donations.AnimationHoverSpeed = 0.07F;
            this.btn_Donations.AnimationSpeed = 0.03F;
            this.btn_Donations.BaseColor = System.Drawing.Color.Maroon;
            this.btn_Donations.BorderColor = System.Drawing.Color.Black;
            this.btn_Donations.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Donations.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Donations.Font = new System.Drawing.Font("Times New Roman", 16.25F);
            this.btn_Donations.ForeColor = System.Drawing.Color.White;
            this.btn_Donations.Image = ((System.Drawing.Image)(resources.GetObject("btn_Donations.Image")));
            this.btn_Donations.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Donations.Location = new System.Drawing.Point(28, 289);
            this.btn_Donations.Name = "btn_Donations";
            this.btn_Donations.OnHoverBaseColor = System.Drawing.Color.Firebrick;
            this.btn_Donations.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Donations.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Donations.OnHoverImage = null;
            this.btn_Donations.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Donations.Size = new System.Drawing.Size(208, 103);
            this.btn_Donations.TabIndex = 20;
            this.btn_Donations.Text = "Donations";
            this.btn_Donations.Click += new System.EventHandler(this.btn_Donations_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 528);
            this.Controls.Add(this.btn_Donations);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.btn_Donor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.gunaButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton btn_Donor;
        private Guna.UI.WinForms.GunaButton btn_Transfer;
        private Guna.UI.WinForms.GunaButton btn_Donations;
    }
}