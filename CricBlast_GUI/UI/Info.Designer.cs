
namespace CricBlast_GUI.UI
{
    partial class Info
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
            this.components = new System.ComponentModel.Container();
            this.infoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.infoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoPictureBox.Image = global::CricBlast_GUI.Properties.Resources.Project_Details;
            this.infoPictureBox.ImageRotate = 0F;
            this.infoPictureBox.Location = new System.Drawing.Point(37, 20);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.ShadowDecoration.Parent = this.infoPictureBox;
            this.infoPictureBox.Size = new System.Drawing.Size(876, 607);
            this.infoPictureBox.TabIndex = 1;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(912, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 22;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 627);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.infoPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox infoPictureBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}