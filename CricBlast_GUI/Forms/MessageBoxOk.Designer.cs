
namespace CricBlast_GUI.Forms
{
    partial class MessageBoxOk
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
            this.messageMark = new Guna.UI2.WinForms.Guna2PictureBox();
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.message = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cricBlastLabel = new System.Windows.Forms.Label();
            this.cricBlastPicture = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // messageMark
            // 
            this.messageMark.Image = global::CricBlast_GUI.Properties.Resources.Check_Mark;
            this.messageMark.ImageRotate = 0F;
            this.messageMark.Location = new System.Drawing.Point(43, 76);
            this.messageMark.Name = "messageMark";
            this.messageMark.ShadowDecoration.Parent = this.messageMark;
            this.messageMark.Size = new System.Drawing.Size(80, 80);
            this.messageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messageMark.TabIndex = 0;
            this.messageMark.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Animated = true;
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BorderRadius = 4;
            this.okButton.CheckedState.Parent = this.okButton;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.CustomImages.Parent = this.okButton;
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.DisabledState.Parent = this.okButton;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.HoverState.Parent = this.okButton;
            this.okButton.Location = new System.Drawing.Point(163, 187);
            this.okButton.Name = "okButton";
            this.okButton.ShadowDecoration.Parent = this.okButton;
            this.okButton.Size = new System.Drawing.Size(180, 45);
            this.okButton.TabIndex = 28;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(147, 59);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(322, 105);
            this.message.TabIndex = 29;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // cricBlastLabel
            // 
            this.cricBlastLabel.AutoSize = true;
            this.cricBlastLabel.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastLabel.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold);
            this.cricBlastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cricBlastLabel.Location = new System.Drawing.Point(43, 10);
            this.cricBlastLabel.Name = "cricBlastLabel";
            this.cricBlastLabel.Size = new System.Drawing.Size(99, 28);
            this.cricBlastLabel.TabIndex = 40;
            this.cricBlastLabel.Text = "CricBlast";
            // 
            // cricBlastPicture
            // 
            this.cricBlastPicture.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastPicture.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.cricBlastPicture.Location = new System.Drawing.Point(12, 12);
            this.cricBlastPicture.Name = "cricBlastPicture";
            this.cricBlastPicture.Size = new System.Drawing.Size(25, 25);
            this.cricBlastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cricBlastPicture.TabIndex = 39;
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
            this.guna2ControlBox1.TabIndex = 41;
            // 
            // MessageBoxOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(518, 265);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.cricBlastLabel);
            this.Controls.Add(this.cricBlastPicture);
            this.Controls.Add(this.message);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.messageMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxOk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox messageMark;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label cricBlastLabel;
        private System.Windows.Forms.PictureBox cricBlastPicture;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}