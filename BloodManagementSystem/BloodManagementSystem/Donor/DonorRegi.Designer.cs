namespace BloodManagementSystem
{
    partial class DonorRegi
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
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.GroupBox = new Guna.UI.WinForms.GunaGroupBox();
            this.rbF = new Guna.UI.WinForms.GunaRadioButton();
            this.rbM = new Guna.UI.WinForms.GunaRadioButton();
            this.dtp = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbReg = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbCity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbCo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbPhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbLN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tbFN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaPanel2.SuspendLayout();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.GroupBox);
            this.gunaPanel2.Controls.Add(this.dtp);
            this.gunaPanel2.Controls.Add(this.btnNext);
            this.gunaPanel2.Controls.Add(this.kryptonLabel12);
            this.gunaPanel2.Controls.Add(this.kryptonLabel11);
            this.gunaPanel2.Controls.Add(this.kryptonLabel10);
            this.gunaPanel2.Controls.Add(this.kryptonLabel1);
            this.gunaPanel2.Controls.Add(this.kryptonLabel9);
            this.gunaPanel2.Controls.Add(this.kryptonLabel8);
            this.gunaPanel2.Controls.Add(this.tbReg);
            this.gunaPanel2.Controls.Add(this.tbCity);
            this.gunaPanel2.Controls.Add(this.tbCo);
            this.gunaPanel2.Controls.Add(this.tbPhone);
            this.gunaPanel2.Controls.Add(this.tbEmail);
            this.gunaPanel2.Controls.Add(this.tbLN);
            this.gunaPanel2.Controls.Add(this.kryptonLabel2);
            this.gunaPanel2.Controls.Add(this.tbFN);
            this.gunaPanel2.Controls.Add(this.kryptonLabel4);
            this.gunaPanel2.Location = new System.Drawing.Point(399, 21);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(591, 417);
            this.gunaPanel2.TabIndex = 2;
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox.BaseColor = System.Drawing.Color.White;
            this.GroupBox.BorderColor = System.Drawing.Color.White;
            this.GroupBox.Controls.Add(this.rbF);
            this.GroupBox.Controls.Add(this.rbM);
            this.GroupBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.LineColor = System.Drawing.SystemColors.Window;
            this.GroupBox.Location = new System.Drawing.Point(340, 99);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(197, 72);
            this.GroupBox.TabIndex = 217;
            this.GroupBox.Text = "Gender";
            this.GroupBox.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rbF
            // 
            this.rbF.BaseColor = System.Drawing.SystemColors.Control;
            this.rbF.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbF.CheckedOnColor = System.Drawing.Color.Maroon;
            this.rbF.FillColor = System.Drawing.Color.White;
            this.rbF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbF.Location = new System.Drawing.Point(14, 31);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(76, 20);
            this.rbF.TabIndex = 0;
            this.rbF.Text = "Female";
            // 
            // rbM
            // 
            this.rbM.BaseColor = System.Drawing.SystemColors.Control;
            this.rbM.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbM.CheckedOnColor = System.Drawing.Color.Maroon;
            this.rbM.FillColor = System.Drawing.Color.White;
            this.rbM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbM.Location = new System.Drawing.Point(105, 31);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(63, 20);
            this.rbM.TabIndex = 1;
            this.rbM.Text = "Male";
            // 
            // dtp
            // 
            this.dtp.BaseColor = System.Drawing.Color.White;
            this.dtp.BorderColor = System.Drawing.Color.Maroon;
            this.dtp.BorderSize = 1;
            this.dtp.CustomFormat = null;
            this.dtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp.ForeColor = System.Drawing.Color.Black;
            this.dtp.Location = new System.Drawing.Point(78, 148);
            this.dtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtp.OnPressedColor = System.Drawing.Color.Black;
            this.dtp.Size = new System.Drawing.Size(201, 23);
            this.dtp.TabIndex = 216;
            this.dtp.Text = "Monday, October 3, 2022";
            this.dtp.Value = new System.DateTime(2022, 10, 3, 11, 59, 47, 359);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(78, 372);
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
            this.btnNext.Size = new System.Drawing.Size(475, 31);
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
            this.btnNext.StatePressed.Content.Padding = new System.Windows.Forms.Padding(3);
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
            this.btnNext.TabIndex = 215;
            this.btnNext.Values.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(344, 196);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel12.Size = new System.Drawing.Size(57, 25);
            this.kryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel12.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel12.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel12.TabIndex = 214;
            this.kryptonLabel12.Values.Text = "Phone";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(78, 280);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel11.Size = new System.Drawing.Size(73, 25);
            this.kryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel11.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel11.TabIndex = 213;
            this.kryptonLabel11.Values.Text = "Country";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(245, 280);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel10.Size = new System.Drawing.Size(43, 25);
            this.kryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel10.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel10.TabIndex = 212;
            this.kryptonLabel10.Values.Text = "City";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(417, 280);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel1.Size = new System.Drawing.Size(62, 25);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 211;
            this.kryptonLabel1.Values.Text = "Region";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(78, 196);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel9.Size = new System.Drawing.Size(55, 25);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel9.TabIndex = 210;
            this.kryptonLabel9.Values.Text = "Email";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(78, 107);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel8.Size = new System.Drawing.Size(111, 25);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel8.TabIndex = 209;
            this.kryptonLabel8.Values.Text = "Date Of Birth";
            // 
            // tbReg
            // 
            this.tbReg.Location = new System.Drawing.Point(422, 324);
            this.tbReg.Name = "tbReg";
            this.tbReg.Size = new System.Drawing.Size(131, 28);
            this.tbReg.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbReg.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.tbReg.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbReg.StateCommon.Border.Width = 1;
            this.tbReg.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbReg.TabIndex = 208;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(252, 324);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(130, 28);
            this.tbCity.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbCity.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.tbCity.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCity.StateCommon.Border.Width = 1;
            this.tbCity.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbCity.TabIndex = 207;
            // 
            // tbCo
            // 
            this.tbCo.Location = new System.Drawing.Point(78, 324);
            this.tbCo.Name = "tbCo";
            this.tbCo.Size = new System.Drawing.Size(137, 28);
            this.tbCo.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbCo.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.tbCo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCo.StateCommon.Border.Width = 1;
            this.tbCo.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbCo.TabIndex = 206;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(344, 229);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(197, 28);
            this.tbPhone.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbPhone.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.tbPhone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPhone.StateCommon.Border.Width = 1;
            this.tbPhone.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbPhone.TabIndex = 205;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(78, 229);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(201, 28);
            this.tbEmail.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbEmail.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.tbEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEmail.StateCommon.Border.Width = 1;
            this.tbEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbEmail.TabIndex = 204;
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(340, 53);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(197, 28);
            this.tbLN.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbLN.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.tbLN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbLN.StateCommon.Border.Width = 1;
            this.tbLN.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbLN.TabIndex = 203;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(340, 5);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(90, 23);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2.TabIndex = 202;
            this.kryptonLabel2.Values.Text = "Last Name";
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(78, 53);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(197, 28);
            this.tbFN.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.tbFN.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.tbFN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbFN.StateCommon.Border.Width = 1;
            this.tbFN.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.tbFN.TabIndex = 201;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(78, 5);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonLabel4.Size = new System.Drawing.Size(93, 25);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel4.TabIndex = 200;
            this.kryptonLabel4.Values.Text = "First Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 467);
            this.panel3.TabIndex = 46;
            // 
            // DonorRegi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gunaPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(557, 150);
            this.Name = "DonorRegi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DonorRegi";
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaGroupBox GroupBox;
        private Guna.UI.WinForms.GunaRadioButton rbM;
        private Guna.UI.WinForms.GunaRadioButton rbF;
        private Guna.UI.WinForms.GunaDateTimePicker dtp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNext;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbReg;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbCity;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbCo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPhone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbLN;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbFN;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
    }
}