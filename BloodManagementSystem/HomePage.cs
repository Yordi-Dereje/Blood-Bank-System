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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private int ImageNumber = 1;
        private void LoadNextImages()
        {
            try
            {
                timerChangeImage.Start();
                ImageNumber++;
                if (ImageNumber > 3)
                {
                    ImageNumber = 1;
                }
                pictureBox.ImageLocation = string.Format(@"C:\Users\hp\Documents\GitHub\lab projects\Blood-Bank-System\BloodManagementSystem\Images\" + ImageNumber + ".jpg");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPreviousImages()
        {
            timerChangeImage.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 3;
            }
            pictureBox.ImageLocation = string.Format(@"C:\Users\hp\Documents\GitHub\lab projects\Blood-Bank-System\BloodManagementSystem\Images\" + ImageNumber + ".jpg");
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = string.Format(@"C:\Users\hp\Documents\GitHub\lab projects\Blood-Bank-System\BloodManagementSystem\Images\" + ImageNumber + ".jpg");

        }

        private void timerChangeImage_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            timerChangeImage.Stop();
            LoadPreviousImages();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            timerChangeImage.Stop();
            LoadNextImages();
        }
    }
}
