namespace BloodManagementSystem
{
    partial class DonorInfo
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
            this.tbID = new Guna.UI.WinForms.GunaTextBox();
            this.PanelDonorInfo = new System.Windows.Forms.Panel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.BaseColor = System.Drawing.Color.White;
            this.tbID.BorderColor = System.Drawing.Color.Silver;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.FocusedBaseColor = System.Drawing.Color.White;
            this.tbID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbID.Location = new System.Drawing.Point(778, 24);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.SelectedText = "";
            this.tbID.Size = new System.Drawing.Size(126, 26);
            this.tbID.TabIndex = 0;
            this.tbID.Text = "ID";
            // 
            // PanelDonorInfo
            // 
            this.PanelDonorInfo.Location = new System.Drawing.Point(32, 65);
            this.PanelDonorInfo.Name = "PanelDonorInfo";
            this.PanelDonorInfo.Size = new System.Drawing.Size(917, 380);
            this.PanelDonorInfo.TabIndex = 1;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(405, 24);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(100, 22);
            this.gunaLabel7.TabIndex = 7;
            this.gunaLabel7.Text = "Donor Info";
            // 
            // DonorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 470);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.PanelDonorInfo);
            this.Controls.Add(this.tbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonorInfo";
            this.Text = "DonorInfo";
            this.Load += new System.EventHandler(this.DonorInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox tbID;
        private System.Windows.Forms.Panel PanelDonorInfo;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
    }
}