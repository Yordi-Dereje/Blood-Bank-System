using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.btnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbSalEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.GroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.rbMEmp = new Guna.UI.WinForms.GunaRadioButton();
            this.rbFEmp = new Guna.UI.WinForms.GunaRadioButton();
            this.dtpEmp = new Guna.UI.WinForms.GunaDateTimePicker();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbRegEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbCiEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbCoEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbPhoneEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbEmailEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbLNEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel15 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbFNEmp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.rbEmp = new Guna.UI.WinForms.GunaRadioButton();
            this.rbAd = new Guna.UI.WinForms.GunaRadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(492, 591);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnNext.Size = new System.Drawing.Size(628, 47);
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
            this.btnNext.TabIndex = 9;
            this.btnNext.Values.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbSalEmp
            // 
            this.tbSalEmp.Location = new System.Drawing.Point(494, 514);
            this.tbSalEmp.Margin = new System.Windows.Forms.Padding(5);
            this.tbSalEmp.Name = "tbSalEmp";
            this.tbSalEmp.Size = new System.Drawing.Size(283, 44);
            this.tbSalEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbSalEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tbSalEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSalEmp.StateCommon.Border.Rounding = 20;
            this.tbSalEmp.StateCommon.Border.Width = 1;
            this.tbSalEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbSalEmp.TabIndex = 284;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(492, 456);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel1.Size = new System.Drawing.Size(72, 30);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 294;
            this.kryptonLabel1.Values.Text = "Salary";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.BaseColor = System.Drawing.Color.White;
            this.GroupBox1.BorderColor = System.Drawing.Color.White;
            this.GroupBox1.Controls.Add(this.rbMEmp);
            this.GroupBox1.Controls.Add(this.rbFEmp);
            this.GroupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.LineColor = System.Drawing.SystemColors.Window;
            this.GroupBox1.Location = new System.Drawing.Point(842, 113);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(263, 89);
            this.GroupBox1.TabIndex = 293;
            this.GroupBox1.Text = "Gender";
            this.GroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbMEmp
            // 
            this.rbMEmp.BaseColor = System.Drawing.SystemColors.Control;
            this.rbMEmp.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbMEmp.CheckedOnColor = System.Drawing.Color.Maroon;
            this.rbMEmp.FillColor = System.Drawing.Color.White;
            this.rbMEmp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMEmp.Location = new System.Drawing.Point(163, 48);
            this.rbMEmp.Margin = new System.Windows.Forms.Padding(4);
            this.rbMEmp.Name = "rbMEmp";
            this.rbMEmp.Size = new System.Drawing.Size(72, 25);
            this.rbMEmp.TabIndex = 1;
            this.rbMEmp.Text = "Male";
            // 
            // rbFEmp
            // 
            this.rbFEmp.BaseColor = System.Drawing.SystemColors.Control;
            this.rbFEmp.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbFEmp.CheckedOnColor = System.Drawing.Color.Maroon;
            this.rbFEmp.FillColor = System.Drawing.Color.White;
            this.rbFEmp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFEmp.Location = new System.Drawing.Point(19, 48);
            this.rbFEmp.Margin = new System.Windows.Forms.Padding(4);
            this.rbFEmp.Name = "rbFEmp";
            this.rbFEmp.Size = new System.Drawing.Size(89, 25);
            this.rbFEmp.TabIndex = 0;
            this.rbFEmp.Text = "Female";
            // 
            // dtpEmp
            // 
            this.dtpEmp.BackColor = System.Drawing.Color.Transparent;
            this.dtpEmp.BaseColor = System.Drawing.Color.White;
            this.dtpEmp.BorderColor = System.Drawing.Color.Maroon;
            this.dtpEmp.BorderSize = 1;
            this.dtpEmp.CustomFormat = null;
            this.dtpEmp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEmp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEmp.ForeColor = System.Drawing.Color.Black;
            this.dtpEmp.Location = new System.Drawing.Point(494, 161);
            this.dtpEmp.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEmp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEmp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEmp.Name = "dtpEmp";
            this.dtpEmp.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpEmp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpEmp.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpEmp.OnPressedColor = System.Drawing.Color.Black;
            this.dtpEmp.Radius = 20;
            this.dtpEmp.Size = new System.Drawing.Size(268, 46);
            this.dtpEmp.TabIndex = 278;
            this.dtpEmp.Text = "Monday, October 3, 2022";
            this.dtpEmp.Value = new System.DateTime(2022, 10, 3, 11, 59, 47, 359);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(842, 228);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel3.Size = new System.Drawing.Size(69, 30);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel3.TabIndex = 292;
            this.kryptonLabel3.Values.Text = "Phone";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(488, 324);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel5.Size = new System.Drawing.Size(89, 30);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel5.TabIndex = 291;
            this.kryptonLabel5.Values.Text = "Country";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(699, 324);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel6.Size = new System.Drawing.Size(52, 30);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel6.TabIndex = 290;
            this.kryptonLabel6.Values.Text = "City";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(925, 321);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel7.Size = new System.Drawing.Size(76, 30);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel7.TabIndex = 289;
            this.kryptonLabel7.Values.Text = "Region";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(494, 228);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel2.Size = new System.Drawing.Size(67, 30);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2.TabIndex = 288;
            this.kryptonLabel2.Values.Text = "Email";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(494, 124);
            this.kryptonLabel14.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel14.Size = new System.Drawing.Size(137, 30);
            this.kryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel14.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel14.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel14.TabIndex = 287;
            this.kryptonLabel14.Values.Text = "Date Of Birth";
            // 
            // tbRegEmp
            // 
            this.tbRegEmp.Location = new System.Drawing.Point(925, 373);
            this.tbRegEmp.Margin = new System.Windows.Forms.Padding(5);
            this.tbRegEmp.Name = "tbRegEmp";
            this.tbRegEmp.Size = new System.Drawing.Size(195, 44);
            this.tbRegEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbRegEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tbRegEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRegEmp.StateCommon.Border.Rounding = 20;
            this.tbRegEmp.StateCommon.Border.Width = 1;
            this.tbRegEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbRegEmp.TabIndex = 283;
            // 
            // tbCiEmp
            // 
            this.tbCiEmp.Location = new System.Drawing.Point(699, 373);
            this.tbCiEmp.Margin = new System.Windows.Forms.Padding(5);
            this.tbCiEmp.Name = "tbCiEmp";
            this.tbCiEmp.Size = new System.Drawing.Size(198, 44);
            this.tbCiEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbCiEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tbCiEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCiEmp.StateCommon.Border.Rounding = 20;
            this.tbCiEmp.StateCommon.Border.Width = 1;
            this.tbCiEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbCiEmp.TabIndex = 282;
            // 
            // tbCoEmp
            // 
            this.tbCoEmp.Location = new System.Drawing.Point(494, 373);
            this.tbCoEmp.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoEmp.Name = "tbCoEmp";
            this.tbCoEmp.Size = new System.Drawing.Size(183, 44);
            this.tbCoEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbCoEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tbCoEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCoEmp.StateCommon.Border.Rounding = 20;
            this.tbCoEmp.StateCommon.Border.Width = 1;
            this.tbCoEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbCoEmp.TabIndex = 281;
            // 
            // tbPhoneEmp
            // 
            this.tbPhoneEmp.Location = new System.Drawing.Point(842, 268);
            this.tbPhoneEmp.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneEmp.Name = "tbPhoneEmp";
            this.tbPhoneEmp.Size = new System.Drawing.Size(278, 44);
            this.tbPhoneEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbPhoneEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tbPhoneEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPhoneEmp.StateCommon.Border.Rounding = 20;
            this.tbPhoneEmp.StateCommon.Border.Width = 1;
            this.tbPhoneEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbPhoneEmp.TabIndex = 280;
            // 
            // tbEmailEmp
            // 
            this.tbEmailEmp.Location = new System.Drawing.Point(494, 268);
            this.tbEmailEmp.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmailEmp.Name = "tbEmailEmp";
            this.tbEmailEmp.Size = new System.Drawing.Size(268, 44);
            this.tbEmailEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbEmailEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tbEmailEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEmailEmp.StateCommon.Border.Rounding = 20;
            this.tbEmailEmp.StateCommon.Border.Width = 1;
            this.tbEmailEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbEmailEmp.TabIndex = 279;
            // 
            // tbLNEmp
            // 
            this.tbLNEmp.Location = new System.Drawing.Point(842, 53);
            this.tbLNEmp.Margin = new System.Windows.Forms.Padding(4);
            this.tbLNEmp.Name = "tbLNEmp";
            this.tbLNEmp.Size = new System.Drawing.Size(278, 44);
            this.tbLNEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbLNEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tbLNEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbLNEmp.StateCommon.Border.Rounding = 20;
            this.tbLNEmp.StateCommon.Border.Width = 1;
            this.tbLNEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbLNEmp.TabIndex = 277;
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(842, 17);
            this.kryptonLabel15.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(111, 28);
            this.kryptonLabel15.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel15.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel15.TabIndex = 286;
            this.kryptonLabel15.Values.Text = "Last Name";
            // 
            // tbFNEmp
            // 
            this.tbFNEmp.Location = new System.Drawing.Point(494, 53);
            this.tbFNEmp.Margin = new System.Windows.Forms.Padding(4);
            this.tbFNEmp.Name = "tbFNEmp";
            this.tbFNEmp.Size = new System.Drawing.Size(263, 44);
            this.tbFNEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbFNEmp.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.tbFNEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFNEmp.StateCommon.Border.Rounding = 20;
            this.tbFNEmp.StateCommon.Border.Width = 1;
            this.tbFNEmp.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbFNEmp.TabIndex = 276;
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(493, 17);
            this.kryptonLabel16.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel16.Size = new System.Drawing.Size(114, 30);
            this.kryptonLabel16.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel16.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel16.TabIndex = 285;
            this.kryptonLabel16.Values.Text = "First Name";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.White;
            this.gunaGroupBox1.Controls.Add(this.rbEmp);
            this.gunaGroupBox1.Controls.Add(this.rbAd);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.SystemColors.Window;
            this.gunaGroupBox1.Location = new System.Drawing.Point(841, 456);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(279, 110);
            this.gunaGroupBox1.TabIndex = 296;
            this.gunaGroupBox1.Text = "Status";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbEmp
            // 
            this.rbEmp.BaseColor = System.Drawing.SystemColors.Control;
            this.rbEmp.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbEmp.CheckedOnColor = System.Drawing.Color.Maroon;
            this.rbEmp.FillColor = System.Drawing.Color.White;
            this.rbEmp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmp.Location = new System.Drawing.Point(168, 73);
            this.rbEmp.Margin = new System.Windows.Forms.Padding(5);
            this.rbEmp.Name = "rbEmp";
            this.rbEmp.Size = new System.Drawing.Size(111, 25);
            this.rbEmp.TabIndex = 1;
            this.rbEmp.Text = "Employee";
            // 
            // rbAd
            // 
            this.rbAd.BaseColor = System.Drawing.SystemColors.Control;
            this.rbAd.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbAd.CheckedOnColor = System.Drawing.Color.Maroon;
            this.rbAd.FillColor = System.Drawing.Color.White;
            this.rbAd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAd.Location = new System.Drawing.Point(5, 73);
            this.rbAd.Margin = new System.Windows.Forms.Padding(5);
            this.rbAd.Name = "rbAd";
            this.rbAd.Size = new System.Drawing.Size(86, 25);
            this.rbAd.TabIndex = 0;
            this.rbAd.Text = "Admin";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EmployeeRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 651);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.tbSalEmp);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dtpEmp);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel14);
            this.Controls.Add(this.tbRegEmp);
            this.Controls.Add(this.tbCiEmp);
            this.Controls.Add(this.tbCoEmp);
            this.Controls.Add(this.tbPhoneEmp);
            this.Controls.Add(this.tbEmailEmp);
            this.Controls.Add(this.tbLNEmp);
            this.Controls.Add(this.kryptonLabel15);
            this.Controls.Add(this.tbFNEmp);
            this.Controls.Add(this.kryptonLabel16);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeRegi";
            this.Text = "EmployeeRegi";
            this.Load += new System.EventHandler(this.EmployeeRegi_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNext;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbSalEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Guna.UI.WinForms.GunaGroupBox GroupBox1;
        private Guna.UI.WinForms.GunaRadioButton rbMEmp;
        private Guna.UI.WinForms.GunaRadioButton rbFEmp;
        private Guna.UI.WinForms.GunaDateTimePicker dtpEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbRegEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbCiEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbCoEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPhoneEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbEmailEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbLNEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbFNEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaRadioButton rbEmp;
        private Guna.UI.WinForms.GunaRadioButton rbAd;
        private ErrorProvider errorProvider1;
        //private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}