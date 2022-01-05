
namespace CricBlast_GUI.UI
{
    partial class ExitMessage
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
            this.message = new System.Windows.Forms.Label();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.contributionsButton = new Guna.UI2.WinForms.Guna2Button();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cricBlastPicture = new System.Windows.Forms.PictureBox();
            this.messageMark = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).BeginInit();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(183, 68);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(254, 69);
            this.message.TabIndex = 45;
            this.message.Text = "Do you really want to exit?";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderRadius = 4;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.DisabledState.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Tomato;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(333, 176);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(110, 45);
            this.exitButton.TabIndex = 44;
            this.exitButton.Text = "Yes";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contributionsButton
            // 
            this.contributionsButton.BackColor = System.Drawing.Color.Transparent;
            this.contributionsButton.BorderRadius = 4;
            this.contributionsButton.CheckedState.Parent = this.contributionsButton;
            this.contributionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contributionsButton.CustomImages.Parent = this.contributionsButton;
            this.contributionsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.contributionsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.contributionsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.contributionsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.contributionsButton.DisabledState.Parent = this.contributionsButton;
            this.contributionsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.contributionsButton.ForeColor = System.Drawing.Color.White;
            this.contributionsButton.HoverState.Parent = this.contributionsButton;
            this.contributionsButton.Location = new System.Drawing.Point(69, 176);
            this.contributionsButton.Name = "contributionsButton";
            this.contributionsButton.ShadowDecoration.Parent = this.contributionsButton;
            this.contributionsButton.Size = new System.Drawing.Size(232, 45);
            this.contributionsButton.TabIndex = 50;
            this.contributionsButton.Text = "View Project Info";
            this.contributionsButton.Click += new System.EventHandler(this.contributionsButton_Click);
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 54;
            this.label1.Text = "CricBlast";
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(474, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 53;
            // 
            // cricBlastPicture
            // 
            this.cricBlastPicture.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastPicture.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.cricBlastPicture.Location = new System.Drawing.Point(8, 8);
            this.cricBlastPicture.Name = "cricBlastPicture";
            this.cricBlastPicture.Size = new System.Drawing.Size(25, 25);
            this.cricBlastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cricBlastPicture.TabIndex = 52;
            this.cricBlastPicture.TabStop = false;
            // 
            // messageMark
            // 
            this.messageMark.Image = global::CricBlast_GUI.Properties.Resources.Error_Mark;
            this.messageMark.ImageRotate = 0F;
            this.messageMark.Location = new System.Drawing.Point(90, 62);
            this.messageMark.Name = "messageMark";
            this.messageMark.ShadowDecoration.Parent = this.messageMark;
            this.messageMark.Size = new System.Drawing.Size(80, 80);
            this.messageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messageMark.TabIndex = 51;
            this.messageMark.TabStop = false;
            // 
            // ExitMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.cricBlastPicture);
            this.Controls.Add(this.messageMark);
            this.Controls.Add(this.contributionsButton);
            this.Controls.Add(this.message);
            this.Controls.Add(this.exitButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2Button contributionsButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.PictureBox cricBlastPicture;
        private Guna.UI2.WinForms.Guna2PictureBox messageMark;
    }
}