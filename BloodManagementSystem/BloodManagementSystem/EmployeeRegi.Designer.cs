namespace BloodManagementSystem
{
    partial class EmployeeRegi
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
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.rbMEmp = new Guna.UI.WinForms.GunaRadioButton();
            this.rbFEmp = new Guna.UI.WinForms.GunaRadioButton();
            this.dtpEmp = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbCiEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbRegEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbCoEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbPhoneEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbEmailEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbLNEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbFNEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Maroon;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(393, 2);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(175, 38);
            this.gunaLineTextBox1.TabIndex = 234;
            this.gunaLineTextBox1.Text = "New Employee";
            this.gunaLineTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.White;
            this.gunaGroupBox1.Controls.Add(this.rbMEmp);
            this.gunaGroupBox1.Controls.Add(this.rbFEmp);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.SystemColors.Window;
            this.gunaGroupBox1.Location = new System.Drawing.Point(517, 160);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(197, 71);
            this.gunaGroupBox1.TabIndex = 233;
            this.gunaGroupBox1.Text = "Gender";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbMEmp
            // 
            this.rbMEmp.BaseColor = System.Drawing.SystemColors.Control;
            this.rbMEmp.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbMEmp.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbMEmp.FillColor = System.Drawing.Color.White;
            this.rbMEmp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMEmp.Location = new System.Drawing.Point(113, 48);
            this.rbMEmp.Name = "rbMEmp";
            this.rbMEmp.Size = new System.Drawing.Size(63, 20);
            this.rbMEmp.TabIndex = 1;
            this.rbMEmp.Text = "Male";
            // 
            // rbFEmp
            // 
            this.rbFEmp.BaseColor = System.Drawing.SystemColors.Control;
            this.rbFEmp.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbFEmp.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbFEmp.FillColor = System.Drawing.Color.White;
            this.rbFEmp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFEmp.Location = new System.Drawing.Point(3, 48);
            this.rbFEmp.Name = "rbFEmp";
            this.rbFEmp.Size = new System.Drawing.Size(76, 20);
            this.rbFEmp.TabIndex = 0;
            this.rbFEmp.Text = "Female";
            // 
            // dtpEmp
            // 
            this.dtpEmp.BaseColor = System.Drawing.Color.White;
            this.dtpEmp.BorderColor = System.Drawing.Color.Silver;
            this.dtpEmp.CustomFormat = null;
            this.dtpEmp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEmp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEmp.ForeColor = System.Drawing.Color.Black;
            this.dtpEmp.Location = new System.Drawing.Point(255, 208);
            this.dtpEmp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEmp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEmp.Name = "dtpEmp";
            this.dtpEmp.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpEmp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpEmp.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpEmp.OnPressedColor = System.Drawing.Color.Black;
            this.dtpEmp.Size = new System.Drawing.Size(201, 30);
            this.dtpEmp.TabIndex = 232;
            this.dtpEmp.Text = "Monday, October 3, 2022";
            this.dtpEmp.Value = new System.DateTime(2022, 10, 3, 11, 59, 47, 359);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(255, 433);
            this.btnNext.Name = "btnNext";
            this.btnNext.OverrideDefault.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnNext.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnNext.OverrideDefault.Back.ColorAngle = 45F;
            this.btnNext.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNext.OverrideDefault.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnNext.OverrideDefault.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnNext.OverrideDefault.Border.ColorAngle = 45F;
            this.btnNext.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNext.OverrideDefault.Border.Rounding = 20;
            this.btnNext.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnNext.Size = new System.Drawing.Size(475, 38);
            this.btnNext.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnNext.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnNext.StateCommon.Back.ColorAngle = 45F;
            this.btnNext.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Border.ColorAngle = 45F;
            this.btnNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNext.StateCommon.Border.Width = 1;
            this.btnNext.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNext.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnNext.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.StatePressed.Content.ShortText.ColorAngle = 45F;
            this.btnNext.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.StateTracking.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnNext.StateTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnNext.StateTracking.Back.ColorAngle = 135F;
            this.btnNext.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNext.StateTracking.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnNext.StateTracking.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnNext.StateTracking.Border.ColorAngle = 135F;
            this.btnNext.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNext.StateTracking.Border.Rounding = 20;
            this.btnNext.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.TabIndex = 231;
            this.btnNext.Values.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(520, 256);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel12.Size = new System.Drawing.Size(57, 25);
            this.kryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel12.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel12.TabIndex = 230;
            this.kryptonLabel12.Values.Text = "Phone";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(422, 340);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel10.Size = new System.Drawing.Size(43, 25);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel10.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel10.TabIndex = 229;
            this.kryptonLabel10.Values.Text = "City";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(594, 340);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel1.Size = new System.Drawing.Size(62, 25);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 228;
            this.kryptonLabel1.Values.Text = "Region";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(255, 168);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel8.Size = new System.Drawing.Size(111, 25);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel8.TabIndex = 227;
            this.kryptonLabel8.Values.Text = "Date Of Birth";
            // 
            // tbCiEmp
            // 
            this.tbCiEmp.Location = new System.Drawing.Point(422, 385);
            this.tbCiEmp.Name = "tbCiEmp";
            this.tbCiEmp.Size = new System.Drawing.Size(146, 28);
            this.tbCiEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbCiEmp.TabIndex = 226;
            // 
            // tbRegEmp
            // 
            this.tbRegEmp.Location = new System.Drawing.Point(594, 385);
            this.tbRegEmp.Name = "tbRegEmp";
            this.tbRegEmp.Size = new System.Drawing.Size(136, 28);
            this.tbRegEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbRegEmp.TabIndex = 225;
            // 
            // tbCoEmp
            // 
            this.tbCoEmp.Location = new System.Drawing.Point(255, 385);
            this.tbCoEmp.Name = "tbCoEmp";
            this.tbCoEmp.Size = new System.Drawing.Size(146, 28);
            this.tbCoEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbCoEmp.TabIndex = 224;
            // 
            // tbPhoneEmp
            // 
            this.tbPhoneEmp.Location = new System.Drawing.Point(520, 290);
            this.tbPhoneEmp.Name = "tbPhoneEmp";
            this.tbPhoneEmp.Size = new System.Drawing.Size(197, 28);
            this.tbPhoneEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbPhoneEmp.TabIndex = 223;
            // 
            // tbEmailEmp
            // 
            this.tbEmailEmp.Location = new System.Drawing.Point(255, 290);
            this.tbEmailEmp.Name = "tbEmailEmp";
            this.tbEmailEmp.Size = new System.Drawing.Size(201, 28);
            this.tbEmailEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbEmailEmp.TabIndex = 222;
            // 
            // tbLNEmp
            // 
            this.tbLNEmp.Location = new System.Drawing.Point(517, 113);
            this.tbLNEmp.Name = "tbLNEmp";
            this.tbLNEmp.Size = new System.Drawing.Size(197, 28);
            this.tbLNEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbLNEmp.TabIndex = 221;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(517, 65);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(90, 23);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2.TabIndex = 220;
            this.kryptonLabel2.Values.Text = "Last Name";
            // 
            // tbFNEmp
            // 
            this.tbFNEmp.Location = new System.Drawing.Point(255, 113);
            this.tbFNEmp.Name = "tbFNEmp";
            this.tbFNEmp.Size = new System.Drawing.Size(197, 28);
            this.tbFNEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFNEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbFNEmp.TabIndex = 219;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(255, 65);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel4.Size = new System.Drawing.Size(93, 25);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel4.TabIndex = 235;
            this.kryptonLabel4.Values.Text = "First Name";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(255, 256);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel9.Size = new System.Drawing.Size(55, 25);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel9.TabIndex = 236;
            this.kryptonLabel9.Values.Text = "Email";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(255, 340);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel11.Size = new System.Drawing.Size(73, 25);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel11.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel11.TabIndex = 237;
            this.kryptonLabel11.Values.Text = "Country";
            // 
            // EmployeeRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 473);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.gunaLineTextBox1);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.dtpEmp);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.tbCiEmp);
            this.Controls.Add(this.tbRegEmp);
            this.Controls.Add(this.tbCoEmp);
            this.Controls.Add(this.tbPhoneEmp);
            this.Controls.Add(this.tbEmailEmp);
            this.Controls.Add(this.tbLNEmp);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.tbFNEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeRegi";
            this.Text = "EmployeeRegi";
            this.Load += new System.EventHandler(this.EmployeeRegi_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaRadioButton rbMEmp;
        private Guna.UI.WinForms.GunaRadioButton rbFEmp;
        private Guna.UI.WinForms.GunaDateTimePicker dtpEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNext;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbCiEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbRegEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbCoEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPhoneEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbEmailEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbLNEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbFNEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
    }
}