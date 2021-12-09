
namespace CricBlast_GUI.Forms
{
    partial class MessageBox
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
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).BeginInit();
            this.SuspendLayout();
            // 
            // messageMark
            // 
            this.messageMark.Image = global::CricBlast_GUI.Properties.Resources.Check_Mark;
            this.messageMark.ImageRotate = 0F;
            this.messageMark.Location = new System.Drawing.Point(84, 78);
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
            this.okButton.CustomImages.Parent = this.okButton;
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.DisabledState.Parent = this.okButton;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.HoverState.Parent = this.okButton;
            this.okButton.Location = new System.Drawing.Point(204, 195);
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
            this.message.Location = new System.Drawing.Point(188, 61);
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
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(588, 295);
            this.Controls.Add(this.message);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.messageMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox messageMark;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}