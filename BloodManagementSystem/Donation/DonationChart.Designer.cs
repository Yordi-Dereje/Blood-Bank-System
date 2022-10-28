namespace BloodManagementSystem.Donation
{
    partial class DonationChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tbyears = new Guna.UI.WinForms.GunaTextBox();
            this.chart_Donation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Donation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(63, 48);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(187, 19);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Please Enter Specific Year ";
            // 
            // tbyears
            // 
            this.tbyears.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbyears.BaseColor = System.Drawing.Color.White;
            this.tbyears.BorderColor = System.Drawing.Color.Silver;
            this.tbyears.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbyears.FocusedBaseColor = System.Drawing.Color.White;
            this.tbyears.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbyears.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbyears.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbyears.Location = new System.Drawing.Point(292, 37);
            this.tbyears.Name = "tbyears";
            this.tbyears.PasswordChar = '\0';
            this.tbyears.SelectedText = "";
            this.tbyears.Size = new System.Drawing.Size(91, 30);
            this.tbyears.TabIndex = 5;
            this.tbyears.TextChanged += new System.EventHandler(this.tbyears_TextChanged);
            this.tbyears.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbyears_keydown);
            // 
            // chart_Donation
            // 
            this.chart_Donation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart_Donation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chartArea2.Name = "ChartArea1";
            this.chart_Donation.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Donation.Legends.Add(legend2);
            this.chart_Donation.Location = new System.Drawing.Point(77, 93);
            this.chart_Donation.Name = "chart_Donation";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.Maroon;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Maroon;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series2.Name = "year";
            this.chart_Donation.Series.Add(series2);
            this.chart_Donation.Size = new System.Drawing.Size(673, 355);
            this.chart_Donation.TabIndex = 0;
            this.chart_Donation.Text = "chart1";
            this.chart_Donation.Click += new System.EventHandler(this.chart_Donation_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart_Donation);
            this.panel1.Controls.Add(this.tbyears);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 478);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DonationChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 478);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonationChart";
            this.Text = "DonationChart";
            this.Load += new System.EventHandler(this.DonationChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Donation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox tbyears;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Donation;
        private System.Windows.Forms.Panel panel1;
    }
}