namespace BloodManagementSystem
{
    partial class RequestDonor
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
            this.FlowPanelRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_per = new Guna.UI.WinForms.GunaLabel();
            this.lbl_3 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_72 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_id = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // FlowPanelRequests
            // 
            this.FlowPanelRequests.Location = new System.Drawing.Point(17, 95);
            this.FlowPanelRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlowPanelRequests.Name = "FlowPanelRequests";
            this.FlowPanelRequests.Size = new System.Drawing.Size(989, 404);
            this.FlowPanelRequests.TabIndex = 9;
            this.FlowPanelRequests.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowPanelRequests_Paint);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.gunaLabel1.Location = new System.Drawing.Point(68, 49);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(54, 26);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Date";
            // 
            // lbl_per
            // 
            this.lbl_per.AutoSize = true;
            this.lbl_per.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_per.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_per.Location = new System.Drawing.Point(586, 49);
            this.lbl_per.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_per.Name = "lbl_per";
            this.lbl_per.Size = new System.Drawing.Size(111, 26);
            this.lbl_per.TabIndex = 18;
            this.lbl_per.Text = "Permanent";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_3.Location = new System.Drawing.Point(435, 49);
            this.lbl_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(90, 26);
            this.lbl_3.TabIndex = 17;
            this.lbl_3.Text = "3 Month";
            // 
            // lbl_72
            // 
            this.lbl_72.AutoSize = true;
            this.lbl_72.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_72.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_72.Location = new System.Drawing.Point(303, 49);
            this.lbl_72.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_72.Name = "lbl_72";
            this.lbl_72.Size = new System.Drawing.Size(87, 26);
            this.lbl_72.TabIndex = 16;
            this.lbl_72.Text = "72 Hour";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_id.Location = new System.Drawing.Point(24, 49);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(36, 26);
            this.lbl_id.TabIndex = 15;
            this.lbl_id.Text = "ID";
            // 
            // RequestDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 654);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lbl_per);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_72);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.FlowPanelRequests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RequestDonor";
            this.Text = "RequestDonor";
            this.Load += new System.EventHandler(this.RequestDonor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlowPanelRequests;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbl_per;
        private Guna.UI.WinForms.GunaLabel lbl_3;
        private Guna.UI.WinForms.GunaLabel lbl_72;
        private Guna.UI.WinForms.GunaLabel lbl_id;
    }
}