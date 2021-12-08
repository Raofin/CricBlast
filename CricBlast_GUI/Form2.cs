using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBlast_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool eye;
        private void Guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (eye)
            {
                guna2PictureBox2.Image = Properties.Resources.Eye_Close;
                eye = false;
                guna2TextBox2.UseSystemPasswordChar = true;
                return;
            }

            if (eye == false)
            {
                guna2PictureBox2.Image = Properties.Resources.Eye_Open;
                eye = true;
                guna2TextBox2.UseSystemPasswordChar = false;
            }


        }
    }
}
