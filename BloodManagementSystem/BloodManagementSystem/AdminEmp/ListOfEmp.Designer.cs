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
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_RegiEmp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(37, 26);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(160, 30);
            this.gunaTextBox1.TabIndex = 0;
            this.gunaTextBox1.Text = "gunaTextBox1";
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
            // ListOfEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 495);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_RegiEmp);
            this.Controls.Add(this.gunaTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListOfEmp";
            this.ShowInTaskbar = false;
            this.Text = "ListOfEmp";
            this.Load += new System.EventHandler(this.ListOfEmp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RegiEmp;
    }
}