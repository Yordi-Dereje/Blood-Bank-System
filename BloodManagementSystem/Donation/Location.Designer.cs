namespace BloodManagementSystem
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.btn_bahirdar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_adama = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SubMenu_Panel1 = new System.Windows.Forms.Panel();
            this.kryptonRadioButton2 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButton1 = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_addisababa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
            this.SubMenu_Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonLabel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // kryptonLabel1
            // 
            resources.ApplyResources(this.kryptonLabel1, "kryptonLabel1");
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.Values.Text = resources.GetString("kryptonLabel1.Values.Text");
            // 
            // Menu_Panel
            // 
            resources.ApplyResources(this.Menu_Panel, "Menu_Panel");
            this.Menu_Panel.Controls.Add(this.btn_bahirdar);
            this.Menu_Panel.Controls.Add(this.btn_adama);
            this.Menu_Panel.Controls.Add(this.SubMenu_Panel1);
            this.Menu_Panel.Controls.Add(this.btn_addisababa);
            this.Menu_Panel.Name = "Menu_Panel";
            // 
            // btn_bahirdar
            // 
            resources.ApplyResources(this.btn_bahirdar, "btn_bahirdar");
            this.btn_bahirdar.Name = "btn_bahirdar";
            this.btn_bahirdar.Values.Text = resources.GetString("btn_bahirdar.Values.Text");
            this.btn_bahirdar.Click += new System.EventHandler(this.btn_bahirdar_Click);
            // 
            // btn_adama
            // 
            resources.ApplyResources(this.btn_adama, "btn_adama");
            this.btn_adama.Name = "btn_adama";
            this.btn_adama.Values.Text = resources.GetString("btn_adama.Values.Text");
            this.btn_adama.Click += new System.EventHandler(this.btn_adama_Click);
            // 
            // SubMenu_Panel1
            // 
            this.SubMenu_Panel1.Controls.Add(this.kryptonRadioButton2);
            this.SubMenu_Panel1.Controls.Add(this.kryptonRadioButton1);
            resources.ApplyResources(this.SubMenu_Panel1, "SubMenu_Panel1");
            this.SubMenu_Panel1.Name = "SubMenu_Panel1";
            // 
            // kryptonRadioButton2
            // 
            resources.ApplyResources(this.kryptonRadioButton2, "kryptonRadioButton2");
            this.kryptonRadioButton2.Name = "kryptonRadioButton2";
            this.kryptonRadioButton2.Values.Text = resources.GetString("kryptonRadioButton2.Values.Text");
            // 
            // kryptonRadioButton1
            // 
            resources.ApplyResources(this.kryptonRadioButton1, "kryptonRadioButton1");
            this.kryptonRadioButton1.Name = "kryptonRadioButton1";
            this.kryptonRadioButton1.Values.Text = resources.GetString("kryptonRadioButton1.Values.Text");
            // 
            // btn_addisababa
            // 
            resources.ApplyResources(this.btn_addisababa, "btn_addisababa");
            this.btn_addisababa.Name = "btn_addisababa";
            this.btn_addisababa.Values.Text = resources.GetString("btn_addisababa.Values.Text");
            this.btn_addisababa.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webBrowser1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // webBrowser1
            // 
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.Name = "webBrowser1";
            // 
            // Location
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Location";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Menu_Panel.ResumeLayout(false);
            this.SubMenu_Panel1.ResumeLayout(false);
            this.SubMenu_Panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_addisababa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_bahirdar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_adama;
        private System.Windows.Forms.Panel SubMenu_Panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButton1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}