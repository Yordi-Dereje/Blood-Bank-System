using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagementSystem
{
    public partial class Location : Form
    {
        Panel p;
        public Location(Panel p)
        {
            InitializeComponent();
            CustomizeDesign();
            this.p = p;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomizeDesign()
        {
            SubMenu_Panel1.Visible = false;
            SubMenu_Panel2.Visible = false;
            SubMenu_Panel3.Visible = false;
        }
        private void HideSubMenu()
        {
            if(SubMenu_Panel1.Visible == true)
                SubMenu_Panel1.Visible = false;
            else if (SubMenu_Panel2.Visible == true)
                SubMenu_Panel2.Visible = false;
            else if (SubMenu_Panel3.Visible == true)
                SubMenu_Panel3.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubMenu_Panel1);
            string add = "addis ababa branches of blood bank";
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                queryaddress.Append(add + "," + "+");
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //double click on the buttom n ShowSubMenu(SubMenu_Panel1);

    }
}
