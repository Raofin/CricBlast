
namespace CricBlast_GUI.UI
{
    partial class MessageBoxYesNo
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
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.message = new System.Windows.Forms.Label();
            this.yes = new Guna.UI2.WinForms.Guna2Button();
            this.messageMark = new Guna.UI2.WinForms.Guna2PictureBox();
            this.no = new Guna.UI2.WinForms.Guna2Button();
            this.cricBlastPicture = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cricBlastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(146, 56);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(322, 105);
            this.message.TabIndex = 32;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.Transparent;
            this.yes.BorderRadius = 4;
            this.yes.CheckedState.Parent = this.yes;
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.CustomImages.Parent = this.yes;
            this.yes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.yes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.yes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.yes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.yes.DisabledState.Parent = this.yes;
            this.yes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.yes.ForeColor = System.Drawing.Color.White;
            this.yes.HoverState.Parent = this.yes;
            this.yes.Location = new System.Drawing.Point(282, 179);
            this.yes.Name = "yes";
            this.yes.ShadowDecoration.Parent = this.yes;
            this.yes.Size = new System.Drawing.Size(153, 45);
            this.yes.TabIndex = 1;
            this.yes.Text = "Yes";
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // messageMark
            // 
            this.messageMark.Image = global::CricBlast_GUI.Properties.Resources.Warning_Mark;
            this.messageMark.ImageRotate = 0F;
            this.messageMark.Location = new System.Drawing.Point(43, 68);
            this.messageMark.Name = "messageMark";
            this.messageMark.ShadowDecoration.Parent = this.messageMark;
            this.messageMark.Size = new System.Drawing.Size(80, 80);
            this.messageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messageMark.TabIndex = 30;
            this.messageMark.TabStop = false;
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.Transparent;
            this.no.BorderRadius = 4;
            this.no.CheckedState.Parent = this.no;
            this.no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no.CustomImages.Parent = this.no;
            this.no.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no.DisabledState.Parent = this.no;
            this.no.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.no.ForeColor = System.Drawing.Color.White;
            this.no.HoverState.Parent = this.no;
            this.no.Location = new System.Drawing.Point(93, 179);
            this.no.Name = "no";
            this.no.ShadowDecoration.Parent = this.no;
            this.no.Size = new System.Drawing.Size(153, 45);
            this.no.TabIndex = 2;
            this.no.Text = "No";
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // cricBlastPicture
            // 
            this.cricBlastPicture.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastPicture.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.cricBlastPicture.Location = new System.Drawing.Point(8, 8);
            this.cricBlastPicture.Name = "cricBlastPicture";
            this.cricBlastPicture.Size = new System.Drawing.Size(25, 25);
            this.cricBlastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cricBlastPicture.TabIndex = 41;
            this.cricBlastPicture.TabStop = false;
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
            this.guna2ControlBox1.TabIndex = 43;
            // 
            // cricBlastLabel
            // 
            this.cricBlastLabel.AutoSize = true;
            this.cricBlastLabel.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cricBlastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cricBlastLabel.Location = new System.Drawing.Point(34, 10);
            this.cricBlastLabel.Name = "cricBlastLabel";
            this.cricBlastLabel.Size = new System.Drawing.Size(76, 21);
            this.cricBlastLabel.TabIndex = 44;
            this.cricBlastLabel.Text = "CricBlast";
            // 
            // MessageBoxYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 265);
            this.Controls.Add(this.cricBlastLabel);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.cricBlastPicture);
            this.Controls.Add(this.message);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.messageMark);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2Button no;
        private Guna.UI2.WinForms.Guna2Button yes;
        private Guna.UI2.WinForms.Guna2PictureBox messageMark;
        private System.Windows.Forms.PictureBox cricBlastPicture;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label cricBlastLabel;
    }
}