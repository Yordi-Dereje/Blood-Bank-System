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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerChangeImage = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_signin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_signup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1228, 493);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 61);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // timerChangeImage
            // 
            this.timerChangeImage.Enabled = true;
            this.timerChangeImage.Interval = 2000;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Welcome to the blood bank app. Happy to have you on board.";
            // 
            // btn_signin
            // 
            this.btn_signin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_signin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_signin.Location = new System.Drawing.Point(643, 456);
            this.btn_signin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_signin.Size = new System.Drawing.Size(202, 47);
            this.btn_signin.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_signin.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_signin.StateCommon.Back.ColorAngle = 45F;
            this.btn_signin.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.btn_signin.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.btn_signin.StateCommon.Border.ColorAngle = 45F;
            this.btn_signin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_signin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_signin.StateCommon.Border.Rounding = 20;
            this.btn_signin.StateCommon.Border.Width = 1;
            this.btn_signin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btn_signin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.StatePressed.Content.ShortText.ColorAngle = 45F;
            this.btn_signin.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.TabIndex = 54;
            this.btn_signin.Values.Text = "SIGN IN";
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_signup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_signup.Location = new System.Drawing.Point(942, 456);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_signup.Size = new System.Drawing.Size(184, 47);
            this.btn_signup.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_signup.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_signup.StateCommon.Back.ColorAngle = 45F;
            this.btn_signup.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.btn_signup.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.btn_signup.StateCommon.Border.ColorAngle = 45F;
            this.btn_signup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_signup.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_signup.StateCommon.Border.Rounding = 20;
            this.btn_signup.StateCommon.Border.Width = 1;
            this.btn_signup.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btn_signup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.StatePressed.Content.ShortText.ColorAngle = 45F;
            this.btn_signup.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.TabIndex = 55;
            this.btn_signup.Values.Text = "SIGN UP";
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1340, 567);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerChangeImage;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_signin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_signup;
    }
}