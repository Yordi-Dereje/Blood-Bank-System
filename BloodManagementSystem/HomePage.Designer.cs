namespace BloodManagementSystem
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.timerChangeImage = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_Prev = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Next = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(21, 9);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(537, 31);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Hello and welcome to the national blood bank..\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(824, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 139);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 17.8F);
            this.gunaLabel3.Location = new System.Drawing.Point(877, 435);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 27);
            this.gunaLabel3.TabIndex = 28;
            this.gunaLabel3.Text = "Scan Me";
            // 
            // timerChangeImage
            // 
            this.timerChangeImage.Enabled = true;
            this.timerChangeImage.Interval = 2000;
            this.timerChangeImage.Tick += new System.EventHandler(this.timerChangeImage_Tick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(27, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(676, 376);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btn_Prev
            // 
            this.btn_Prev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Prev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Prev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Prev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Prev.FillColor = System.Drawing.SystemColors.Control;
            this.btn_Prev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Prev.ForeColor = System.Drawing.Color.White;
            this.btn_Prev.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prev.Image")));
            this.btn_Prev.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Prev.Location = new System.Drawing.Point(27, 219);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(53, 40);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Next.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Next.FillColor = System.Drawing.SystemColors.Control;
            this.btn_Next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next.Image")));
            this.btn_Next.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Next.Location = new System.Drawing.Point(650, 219);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(53, 40);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 461);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.gunaLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Timer timerChangeImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button btn_Prev;
        private Guna.UI2.WinForms.Guna2Button btn_Next;
    }
}