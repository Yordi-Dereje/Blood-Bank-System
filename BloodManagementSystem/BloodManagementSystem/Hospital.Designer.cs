namespace BloodManagementSystem
{
    partial class Hospital
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_NewReq = new Guna.UI.WinForms.GunaButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Location = new System.Drawing.Point(1, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 409);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(337, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 389);
            this.panel1.TabIndex = 21;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel1.Location = new System.Drawing.Point(73, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(156, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Hospital Transfer List";
            // 
            // btn_NewReq
            // 
            this.btn_NewReq.AnimationHoverSpeed = 0.07F;
            this.btn_NewReq.AnimationSpeed = 0.03F;
            this.btn_NewReq.BaseColor = System.Drawing.Color.Red;
            this.btn_NewReq.BorderColor = System.Drawing.Color.Black;
            this.btn_NewReq.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_NewReq.FocusedColor = System.Drawing.Color.Empty;
            this.btn_NewReq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewReq.ForeColor = System.Drawing.Color.Black;
            this.btn_NewReq.Image = null;
            this.btn_NewReq.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_NewReq.Location = new System.Drawing.Point(820, 12);
            this.btn_NewReq.Name = "btn_NewReq";
            this.btn_NewReq.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btn_NewReq.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_NewReq.OnHoverForeColor = System.Drawing.Color.Maroon;
            this.btn_NewReq.OnHoverImage = null;
            this.btn_NewReq.OnPressedColor = System.Drawing.Color.Black;
            this.btn_NewReq.Size = new System.Drawing.Size(136, 28);
            this.btn_NewReq.TabIndex = 0;
            this.btn_NewReq.Text = "New Request";
            this.btn_NewReq.Click += new System.EventHandler(this.btn_NewReq_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 434);
            this.Controls.Add(this.btn_NewReq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btn_NewReq;
    }
}