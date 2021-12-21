
namespace CricBlast_GUI.Forms.Admin_Controls
{
    partial class ProjectDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPicture
            // 
            this.infoPicture.BackColor = System.Drawing.Color.Transparent;
            this.infoPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoPicture.Image = global::CricBlast_GUI.Properties.Resources.Project_Details;
            this.infoPicture.ImageRotate = 0F;
            this.infoPicture.Location = new System.Drawing.Point(36, 56);
            this.infoPicture.Name = "infoPicture";
            this.infoPicture.ShadowDecoration.Parent = this.infoPicture;
            this.infoPicture.Size = new System.Drawing.Size(901, 607);
            this.infoPicture.TabIndex = 0;
            this.infoPicture.TabStop = false;
            this.infoPicture.Click += new System.EventHandler(this.infoPicture_Click);
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.SubHome;
            this.Controls.Add(this.infoPicture);
            this.Name = "ProjectDetails";
            this.Size = new System.Drawing.Size(956, 681);
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox infoPicture;
    }
}
