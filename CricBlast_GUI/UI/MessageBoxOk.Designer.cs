
namespace CricBlast_GUI.UI
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
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cricBlastPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // messageMark
            // 
            this.messageMark.Image = global::CricBlast_GUI.Properties.Resources.Check_Mark;
            this.messageMark.ImageRotate = 0F;
            this.messageMark.Location = new System.Drawing.Point(43, 72);
            this.messageMark.Name = "messageMark";
            this.messageMark.ShadowDecoration.Parent = this.messageMark;
            this.messageMark.Size = new System.Drawing.Size(80, 80);
            this.messageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messageMark.TabIndex = 0;
            this.messageMark.TabStop = false;
            // 
            // okButton
            // 
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
            this.okButton.Location = new System.Drawing.Point(163, 183);
            this.okButton.Name = "okButton";
            this.okButton.ShadowDecoration.Parent = this.okButton;
            this.okButton.Size = new System.Drawing.Size(180, 45);
            this.okButton.TabIndex = 1;
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
            this.message.Size = new System.Drawing.Size(339, 105);
            this.message.TabIndex = 29;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
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
            // cricBlastPicture
            // 
            this.cricBlastPicture.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastPicture.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.cricBlastPicture.Location = new System.Drawing.Point(8, 8);
            this.cricBlastPicture.Name = "cricBlastPicture";
            this.cricBlastPicture.Size = new System.Drawing.Size(25, 25);
            this.cricBlastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cricBlastPicture.TabIndex = 39;
            this.cricBlastPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "CricBlast";
            // 
            // MessageBoxOk
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
            this.Controls.Add(this.message);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.messageMark);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxOk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox messageMark;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cricBlastPicture;
    }
}