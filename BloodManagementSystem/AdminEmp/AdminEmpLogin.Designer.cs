namespace BloodManagementSystem
{
    partial class AdminEmpLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEmpLogin));
            this.txt_usEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_UserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_pwEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_ForgotPassword = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usEmp
            // 
            this.txt_usEmp.Location = new System.Drawing.Point(477, 128);
            this.txt_usEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_usEmp.Name = "txt_usEmp";
            this.txt_usEmp.Size = new System.Drawing.Size(335, 39);
            this.txt_usEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.txt_usEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txt_usEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_usEmp.StateCommon.Border.Rounding = 20;
            this.txt_usEmp.TabIndex = 25;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Location = new System.Drawing.Point(477, 90);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(128, 31);
            this.lbl_UserName.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.lbl_UserName.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_UserName.TabIndex = 24;
            this.lbl_UserName.Values.Text = "User Name ";
            // 
            // txt_pwEmp
            // 
            this.txt_pwEmp.Location = new System.Drawing.Point(477, 249);
            this.txt_pwEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pwEmp.Name = "txt_pwEmp";
            this.txt_pwEmp.Size = new System.Drawing.Size(335, 39);
            this.txt_pwEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.txt_pwEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txt_pwEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_pwEmp.StateCommon.Border.Rounding = 20;
            this.txt_pwEmp.TabIndex = 41;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(477, 209);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(115, 32);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 40;
            this.kryptonLabel3.Values.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Login.Location = new System.Drawing.Point(555, 370);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.OverrideDefault.Back.Color1 = System.Drawing.Color.Maroon;
            this.btn_Login.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.btn_Login.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_Login.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Login.OverrideDefault.Border.Color1 = System.Drawing.Color.Maroon;
            this.btn_Login.OverrideDefault.Border.Color2 = System.Drawing.Color.Maroon;
            this.btn_Login.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_Login.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Login.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Login.OverrideDefault.Border.Rounding = 20;
            this.btn_Login.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Login.Size = new System.Drawing.Size(177, 47);
            this.btn_Login.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.btn_Login.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.btn_Login.StateCommon.Back.ColorAngle = 45F;
            this.btn_Login.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btn_Login.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btn_Login.StateCommon.Border.ColorAngle = 45F;
            this.btn_Login.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Login.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Login.StateCommon.Border.Rounding = 20;
            this.btn_Login.StateCommon.Border.Width = 1;
            this.btn_Login.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Login.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btn_Login.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.StatePressed.Content.ShortText.ColorAngle = 45F;
            this.btn_Login.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.StateTracking.Back.Color1 = System.Drawing.Color.Maroon;
            this.btn_Login.StateTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.btn_Login.StateTracking.Back.ColorAngle = 135F;
            this.btn_Login.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Login.StateTracking.Border.Color1 = System.Drawing.Color.Maroon;
            this.btn_Login.StateTracking.Border.Color2 = System.Drawing.Color.Maroon;
            this.btn_Login.StateTracking.Border.ColorAngle = 135F;
            this.btn_Login.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Login.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Login.StateTracking.Border.Rounding = 20;
            this.btn_Login.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.TabIndex = 42;
            this.btn_Login.Values.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // btn_ForgotPassword
            // 
            this.btn_ForgotPassword.Location = new System.Drawing.Point(689, 295);
            this.btn_ForgotPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ForgotPassword.Name = "btn_ForgotPassword";
            this.btn_ForgotPassword.Size = new System.Drawing.Size(123, 21);
            this.btn_ForgotPassword.StateCommon.LongText.Color1 = System.Drawing.SystemColors.Control;
            this.btn_ForgotPassword.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btn_ForgotPassword.StateCommon.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btn_ForgotPassword.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ForgotPassword.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ForgotPassword.TabIndex = 43;
            this.btn_ForgotPassword.Values.Text = "Forgot Password?";
            this.btn_ForgotPassword.LinkClicked += new System.EventHandler(this.btn_ForgotPassword_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.gunaLabel1.Location = new System.Drawing.Point(549, 37);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(197, 33);
            this.gunaLabel1.TabIndex = 45;
            this.gunaLabel1.Text = "Employee Login";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 1000;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // AdminEmpLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1336, 577);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_ForgotPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txt_pwEmp);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txt_usEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminEmpLogin";
            this.Text = "AdminEmpLogin";
            this.Load += new System.EventHandler(this.AdminEmpLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_usEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_UserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_pwEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Login;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel btn_ForgotPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}