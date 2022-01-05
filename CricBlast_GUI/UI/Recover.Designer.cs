
namespace CricBlast_GUI.UI
{
    partial class Recover
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
            this.recoveredUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.recoverButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recoveredName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.recoveredPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.error = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.recoveredUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // recoveredUserPicture
            // 
            this.recoveredUserPicture.BackColor = System.Drawing.Color.Transparent;
            this.recoveredUserPicture.Image = global::CricBlast_GUI.Properties.Resources.User_Male_WhiteBack;
            this.recoveredUserPicture.ImageRotate = 0F;
            this.recoveredUserPicture.Location = new System.Drawing.Point(192, 52);
            this.recoveredUserPicture.Name = "recoveredUserPicture";
            this.recoveredUserPicture.ShadowDecoration.Enabled = true;
            this.recoveredUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.recoveredUserPicture.ShadowDecoration.Parent = this.recoveredUserPicture;
            this.recoveredUserPicture.Size = new System.Drawing.Size(200, 200);
            this.recoveredUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recoveredUserPicture.TabIndex = 0;
            this.recoveredUserPicture.TabStop = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.BorderRadius = 3;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.Parent = this.emailTextBox;
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.FocusedState.Parent = this.emailTextBox;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(88, 302);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Enter your email...";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(409, 47);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.Load += new System.EventHandler(this.emailTextBox_Load);
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTextBox_KeyDown);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(85, 272);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 25);
            this.usernameLabel.TabIndex = 23;
            this.usernameLabel.Text = "EMAIL";
            // 
            // recoverButton
            // 
            this.recoverButton.BackColor = System.Drawing.Color.Transparent;
            this.recoverButton.BorderRadius = 4;
            this.recoverButton.CheckedState.Parent = this.recoverButton;
            this.recoverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoverButton.CustomImages.Parent = this.recoverButton;
            this.recoverButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.recoverButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.recoverButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.recoverButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.recoverButton.DisabledState.Parent = this.recoverButton;
            this.recoverButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.recoverButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverButton.ForeColor = System.Drawing.Color.White;
            this.recoverButton.HoverState.Parent = this.recoverButton;
            this.recoverButton.Location = new System.Drawing.Point(171, 465);
            this.recoverButton.Name = "recoverButton";
            this.recoverButton.ShadowDecoration.Parent = this.recoverButton;
            this.recoverButton.Size = new System.Drawing.Size(242, 45);
            this.recoverButton.TabIndex = 2;
            this.recoverButton.Text = "Recover";
            this.recoverButton.Click += new System.EventHandler(this.recoverButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(83, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(83, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Password  :";
            // 
            // recoveredName
            // 
            this.recoveredName.BackColor = System.Drawing.Color.Transparent;
            this.recoveredName.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.recoveredName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.recoveredName.Location = new System.Drawing.Point(243, 366);
            this.recoveredName.Name = "recoveredName";
            this.recoveredName.Size = new System.Drawing.Size(24, 39);
            this.recoveredName.TabIndex = 25;
            this.recoveredName.Text = "...";
            // 
            // recoveredPassword
            // 
            this.recoveredPassword.BackColor = System.Drawing.Color.Transparent;
            this.recoveredPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.recoveredPassword.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.recoveredPassword.Location = new System.Drawing.Point(243, 403);
            this.recoveredPassword.Name = "recoveredPassword";
            this.recoveredPassword.Size = new System.Drawing.Size(24, 39);
            this.recoveredPassword.TabIndex = 25;
            this.recoveredPassword.Text = "...";
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.error.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(149, 272);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(73, 25);
            this.error.TabIndex = 23;
            this.error.Text = "- error!";
            this.error.Visible = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(540, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 26;
            // 
            // Recover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(90)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.recoveredPassword);
            this.Controls.Add(this.recoveredName);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.recoverButton);
            this.Controls.Add(this.recoveredUserPicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            ((System.ComponentModel.ISupportInitialize)(this.recoveredUserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox recoveredUserPicture;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2Button recoverButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel recoveredName;
        private Guna.UI2.WinForms.Guna2HtmlLabel recoveredPassword;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label error;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}