using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBlast_GUI.Forms.Controls
{
    public partial class AddPlayer : UserControl
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void choosePhotoButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = Properties.Resources.ImageFilter })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    playerPicture.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
