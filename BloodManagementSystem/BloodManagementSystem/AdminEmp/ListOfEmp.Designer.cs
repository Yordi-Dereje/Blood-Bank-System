namespace BloodManagementSystem.AdminEmp
{
    partial class ListOfEmp
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
            this.tbSearch = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_RegiEmp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.BaseColor = System.Drawing.Color.White;
            this.tbSearch.BorderColor = System.Drawing.Color.Silver;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.tbSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.Location = new System.Drawing.Point(37, 26);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(160, 30);
            this.tbSearch.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 349);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_RegiEmp
            // 
            this.btn_RegiEmp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_RegiEmp.Location = new System.Drawing.Point(594, 445);
            this.btn_RegiEmp.Name = "btn_RegiEmp";
            this.btn_RegiEmp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_RegiEmp.Size = new System.Drawing.Size(121, 38);
            this.btn_RegiEmp.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_RegiEmp.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_RegiEmp.StateCommon.Back.ColorAngle = 45F;
            this.btn_RegiEmp.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.btn_RegiEmp.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.btn_RegiEmp.StateCommon.Border.ColorAngle = 45F;
            this.btn_RegiEmp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_RegiEmp.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_RegiEmp.StateCommon.Border.Rounding = 20;
            this.btn_RegiEmp.StateCommon.Border.Width = 1;
            this.btn_RegiEmp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.btn_RegiEmp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegiEmp.StatePressed.Content.ShortText.ColorAngle = 45F;
            this.btn_RegiEmp.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegiEmp.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegiEmp.TabIndex = 29;
            this.btn_RegiEmp.Values.Text = "Register";
            this.btn_RegiEmp.Click += new System.EventHandler(this.btn_CreateAcc_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Search.Location = new System.Drawing.Point(225, 26);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.OverrideDefault.Back.Color1 = System.Drawing.Color.Maroon;
            this.btn_Search.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.btn_Search.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_Search.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Search.OverrideDefault.Border.Color1 = System.Drawing.Color.Maroon;
            this.btn_Search.OverrideDefault.Border.Color2 = System.Drawing.Color.Maroon;
            this.btn_Search.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_Search.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Search.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Search.OverrideDefault.Border.Rounding = 20;
            this.btn_Search.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_Search.Size = new System.Drawing.Size(94, 38);
            this.btn_Search.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.btn_Search.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.btn_Search.StateCommon.Back.ColorAngle = 45F;
            this.btn_Search.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btn_Search.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btn_Search.StateCommon.Border.ColorAngle = 45F;
            this.btn_Search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Search.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Search.StateCommon.Border.Rounding = 20;
            this.btn_Search.StateCommon.Border.Width = 1;
            this.btn_Search.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Search.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btn_Search.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.StatePressed.Content.ShortText.ColorAngle = 45F;
            this.btn_Search.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.StateTracking.Back.Color1 = System.Drawing.Color.Maroon;
            this.btn_Search.StateTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.btn_Search.StateTracking.Back.ColorAngle = 135F;
            this.btn_Search.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Search.StateTracking.Border.Color1 = System.Drawing.Color.Maroon;
            this.btn_Search.StateTracking.Border.Color2 = System.Drawing.Color.Maroon;
            this.btn_Search.StateTracking.Border.ColorAngle = 135F;
            this.btn_Search.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Search.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_Search.StateTracking.Border.Rounding = 20;
            this.btn_Search.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.TabIndex = 31;
            this.btn_Search.Values.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // ListOfEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 495);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_RegiEmp);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListOfEmp";
            this.ShowInTaskbar = false;
            this.Text = "ListOfEmp";
            this.Load += new System.EventHandler(this.ListOfEmp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RegiEmp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
    }
}