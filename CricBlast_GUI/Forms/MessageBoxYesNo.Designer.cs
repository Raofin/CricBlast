
namespace CricBlast_GUI.Forms
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.message = new System.Windows.Forms.Label();
            this.yes = new Guna.UI2.WinForms.Guna2Button();
            this.messageMark = new Guna.UI2.WinForms.Guna2PictureBox();
            this.no = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(185, 58);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(322, 105);
            this.message.TabIndex = 32;
            this.message.Text = "Message";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yes
            // 
            this.yes.Animated = true;
            this.yes.BackColor = System.Drawing.Color.Transparent;
            this.yes.BorderRadius = 4;
            this.yes.CheckedState.Parent = this.yes;
            this.yes.CustomImages.Parent = this.yes;
            this.yes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.yes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.yes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.yes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.yes.DisabledState.Parent = this.yes;
            this.yes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.yes.ForeColor = System.Drawing.Color.White;
            this.yes.HoverState.Parent = this.yes;
            this.yes.Location = new System.Drawing.Point(318, 192);
            this.yes.Name = "yes";
            this.yes.ShadowDecoration.Parent = this.yes;
            this.yes.Size = new System.Drawing.Size(153, 45);
            this.yes.TabIndex = 31;
            this.yes.Text = "Yes";
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // messageMark
            // 
            this.messageMark.Image = global::CricBlast_GUI.Properties.Resources.Warning_Mark;
            this.messageMark.ImageRotate = 0F;
            this.messageMark.Location = new System.Drawing.Point(81, 75);
            this.messageMark.Name = "messageMark";
            this.messageMark.ShadowDecoration.Parent = this.messageMark;
            this.messageMark.Size = new System.Drawing.Size(80, 80);
            this.messageMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.messageMark.TabIndex = 30;
            this.messageMark.TabStop = false;
            // 
            // no
            // 
            this.no.Animated = true;
            this.no.BackColor = System.Drawing.Color.Transparent;
            this.no.BorderRadius = 4;
            this.no.CheckedState.Parent = this.no;
            this.no.CustomImages.Parent = this.no;
            this.no.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.no.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.no.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.no.DisabledState.Parent = this.no;
            this.no.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.no.ForeColor = System.Drawing.Color.White;
            this.no.HoverState.Parent = this.no;
            this.no.Location = new System.Drawing.Point(129, 192);
            this.no.Name = "no";
            this.no.ShadowDecoration.Parent = this.no;
            this.no.Size = new System.Drawing.Size(153, 45);
            this.no.TabIndex = 31;
            this.no.Text = "No";
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // MessageBox2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(588, 295);
            this.Controls.Add(this.message);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.messageMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.messageMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2Button no;
        private Guna.UI2.WinForms.Guna2Button yes;
        private Guna.UI2.WinForms.Guna2PictureBox messageMark;
    }
}