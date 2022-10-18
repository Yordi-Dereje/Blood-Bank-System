namespace BloodManagementSystem
{
    partial class RequestDon
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
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.CLB72h = new System.Windows.Forms.CheckedListBox();
            this.CLB3m = new System.Windows.Forms.CheckedListBox();
            this.CLBperm = new System.Windows.Forms.CheckedListBox();
            this.btnSubmit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // DTP
            // 
            this.DTP.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP.Location = new System.Drawing.Point(15, 25);
            this.DTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(316, 30);
            this.DTP.TabIndex = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(345, -39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 24);
            this.label5.TabIndex = 128;
            this.label5.Text = "Took any of these in the past 72 hours?";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(233, 303);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(418, 33);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 130;
            this.kryptonLabel1.Values.Text = "Had any of these in the past 3 months?\r\n";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(233, 528);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(211, 33);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2.TabIndex = 131;
            this.kryptonLabel2.Values.Text = "Have any of these?\r\n";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(233, 87);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(420, 33);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel3.TabIndex = 132;
            this.kryptonLabel3.Values.Text = "Took any of these in the past 72 hours?\r\n";
            // 
            // CLB72h
            // 
            this.CLB72h.BackColor = System.Drawing.Color.White;
            this.CLB72h.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLB72h.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.CLB72h.FormattingEnabled = true;
            this.CLB72h.Items.AddRange(new object[] {
            "Antibiotics",
            "Steroids",
            "Asprin",
            "Vaccination",
            "Alcohol"});
            this.CLB72h.Location = new System.Drawing.Point(253, 140);
            this.CLB72h.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CLB72h.Name = "CLB72h";
            this.CLB72h.Size = new System.Drawing.Size(392, 138);
            this.CLB72h.TabIndex = 168;
            // 
            // CLB3m
            // 
            this.CLB3m.BackColor = System.Drawing.Color.White;
            this.CLB3m.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLB3m.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.CLB3m.FormattingEnabled = true;
            this.CLB3m.Items.AddRange(new object[] {
            "Tattoo",
            "Ear Piercing",
            "Dental Extraction",
            "Major Surgery",
            "Minor Surgery"});
            this.CLB3m.Location = new System.Drawing.Point(253, 343);
            this.CLB3m.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CLB3m.Name = "CLB3m";
            this.CLB3m.Size = new System.Drawing.Size(347, 138);
            this.CLB3m.TabIndex = 169;
            this.CLB3m.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // CLBperm
            // 
            this.CLBperm.BackColor = System.Drawing.Color.White;
            this.CLBperm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLBperm.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.CLBperm.FormattingEnabled = true;
            this.CLBperm.Items.AddRange(new object[] {
            "Heart Disease",
            "HIV/AIDS",
            "Hepatitis B",
            "Hepatitis C",
            "STDs",
            "Cancer",
            "TuberCulosis",
            "Kidney Disease",
            "Abnormal Bleeding"});
            this.CLBperm.Location = new System.Drawing.Point(253, 591);
            this.CLBperm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CLBperm.Name = "CLBperm";
            this.CLBperm.Size = new System.Drawing.Size(411, 230);
            this.CLBperm.TabIndex = 170;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(822, 809);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OverrideDefault.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnSubmit.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnSubmit.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSubmit.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.OverrideDefault.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnSubmit.OverrideDefault.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnSubmit.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSubmit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.OverrideDefault.Border.Rounding = 20;
            this.btnSubmit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSubmit.Size = new System.Drawing.Size(129, 46);
            this.btnSubmit.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnSubmit.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnSubmit.StateCommon.Back.ColorAngle = 45F;
            this.btnSubmit.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.btnSubmit.StateCommon.Border.ColorAngle = 45F;
            this.btnSubmit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.StateCommon.Border.Rounding = 20;
            this.btnSubmit.StateCommon.Border.Width = 1;
            this.btnSubmit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSubmit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Maroon;
            this.btnSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.StatePressed.Content.ShortText.ColorAngle = 45F;
            this.btnSubmit.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.StateTracking.Back.Color1 = System.Drawing.Color.Maroon;
            this.btnSubmit.StateTracking.Back.Color2 = System.Drawing.Color.Maroon;
            this.btnSubmit.StateTracking.Back.ColorAngle = 135F;
            this.btnSubmit.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.StateTracking.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnSubmit.StateTracking.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnSubmit.StateTracking.Border.ColorAngle = 135F;
            this.btnSubmit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSubmit.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSubmit.StateTracking.Border.Rounding = 20;
            this.btnSubmit.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.TabIndex = 171;
            this.btnSubmit.Values.Text = "Submit";
            // 
            // RequestDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 571);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.CLBperm);
            this.Controls.Add(this.CLB3m);
            this.Controls.Add(this.CLB72h);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RequestDon";
            this.Text = "RequestDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.CheckedListBox CLB72h;
        private System.Windows.Forms.CheckedListBox CLB3m;
        private System.Windows.Forms.CheckedListBox CLBperm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSubmit;
    }
}