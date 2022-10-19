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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Donation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tbyears = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Donation)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Donation
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Donation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Donation.Legends.Add(legend1);
            this.chart_Donation.Location = new System.Drawing.Point(99, 100);
            this.chart_Donation.Name = "chart_Donation";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "year";
            this.chart_Donation.Series.Add(series1);
            this.chart_Donation.Size = new System.Drawing.Size(523, 326);
            this.chart_Donation.TabIndex = 0;
            this.chart_Donation.Text = "chart1";
            this.chart_Donation.Click += new System.EventHandler(this.chart_Donation_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(34, 43);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(187, 19);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Please Enter Specific Year ";
            // 
            // tbyears
            // 
            this.tbyears.BaseColor = System.Drawing.Color.White;
            this.tbyears.BorderColor = System.Drawing.Color.Silver;
            this.tbyears.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbyears.FocusedBaseColor = System.Drawing.Color.White;
            this.tbyears.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbyears.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbyears.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbyears.Location = new System.Drawing.Point(227, 43);
            this.tbyears.Name = "tbyears";
            this.tbyears.PasswordChar = '\0';
            this.tbyears.SelectedText = "";
            this.tbyears.Size = new System.Drawing.Size(91, 30);
            this.tbyears.TabIndex = 5;
            this.tbyears.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbyears_keydown);
            // 
            // DonationChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbyears);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.chart_Donation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonationChart";
            this.Text = "DonationChart";
            this.Load += new System.EventHandler(this.DonationChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Donation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Donation;
       // private Guna.UI.WinForms.GunaTextBox tbyears;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox tbyears;
    }
}