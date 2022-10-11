namespace BloodManagementSystem
{
    partial class UCHospitalReq
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_TRequest = new Guna.UI.WinForms.GunaLabel();
            this.lbl_HName = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(157, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(119, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Hospital Name";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.Location = new System.Drawing.Point(157, 48);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(109, 19);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Total Request";
            // 
            // lbl_TRequest
            // 
            this.lbl_TRequest.AutoSize = true;
            this.lbl_TRequest.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_TRequest.Location = new System.Drawing.Point(336, 48);
            this.lbl_TRequest.Name = "lbl_TRequest";
            this.lbl_TRequest.Size = new System.Drawing.Size(78, 19);
            this.lbl_TRequest.TabIndex = 3;
            this.lbl_TRequest.Text = "TRequest";
            // 
            // lbl_HName
            // 
            this.lbl_HName.AutoSize = true;
            this.lbl_HName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_HName.Location = new System.Drawing.Point(336, 12);
            this.lbl_HName.Name = "lbl_HName";
            this.lbl_HName.Size = new System.Drawing.Size(64, 19);
            this.lbl_HName.TabIndex = 4;
            this.lbl_HName.Text = "HName";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Location = new System.Drawing.Point(29, 12);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(27, 19);
            this.lbl_ID.TabIndex = 5;
            this.lbl_ID.Text = "ID";
            // 
            // UCHospitalReq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_HName);
            this.Controls.Add(this.lbl_TRequest);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "UCHospitalReq";
            this.Size = new System.Drawing.Size(619, 81);
            this.Load += new System.EventHandler(this.UCHospitalReq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lbl_TRequest;
        private System.Windows.Forms.Label lbl_HName;
        private System.Windows.Forms.Label lbl_ID;
    }
}
