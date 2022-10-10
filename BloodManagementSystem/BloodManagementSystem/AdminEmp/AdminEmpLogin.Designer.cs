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
            this.txt_usEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_UserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_pwEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLinkLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txt_usEmp
            // 
            this.txt_usEmp.Location = new System.Drawing.Point(206, 103);
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
            this.lbl_UserName.Location = new System.Drawing.Point(206, 64);
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
            this.txt_pwEmp.Location = new System.Drawing.Point(207, 222);
            this.txt_pwEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pwEmp.Name = "txt_pwEmp";
            this.txt_pwEmp.Size = new System.Drawing.Size(335, 39);
            this.txt_pwEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.txt_pwEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txt_pwEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_pwEmp.StateCommon.Border.Rounding = 20;
            this.txt_pwEmp.TabIndex = 33;
            // 
            // kryptonLinkLabel1
            // 
            this.kryptonLinkLabel1.Location = new System.Drawing.Point(431, 273);
            this.kryptonLinkLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            this.kryptonLinkLabel1.Size = new System.Drawing.Size(123, 21);
            this.kryptonLinkLabel1.StateCommon.LongText.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonLinkLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.kryptonLinkLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.kryptonLinkLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLinkLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLinkLabel1.TabIndex = 32;
            this.kryptonLinkLabel1.Values.Text = "Forgot Password?";
            this.kryptonLinkLabel1.LinkClicked += new System.EventHandler(this.kryptonLinkLabel1_LinkClicked);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(207, 183);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(115, 32);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 31;
            this.kryptonLabel3.Values.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Login.Location = new System.Drawing.Point(287, 344);
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
            this.btn_Login.TabIndex = 34;
            this.btn_Login.Values.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // AdminEmpLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 500);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_pwEmp);
            this.Controls.Add(this.kryptonLinkLabel1);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txt_usEmp);
            this.Controls.Add(this.lbl_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminEmpLogin";
            this.Text = "AdminEmpLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_usEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_UserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_pwEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Login;
    }
}