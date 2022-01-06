
namespace CricBlast_GUI.UI.User_Controls
{
    partial class Welcome
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
            this.components = new System.ComponentModel.Container();
            this.login = new Guna.UI2.WinForms.Guna2Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameRequired = new System.Windows.Forms.Label();
            this.passwordRequired = new System.Windows.Forms.Label();
            this.refreshPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.loginAsPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.eyePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.refreshPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BorderRadius = 4;
            this.login.CheckedState.Parent = this.login;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.CustomImages.Parent = this.login;
            this.login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login.DisabledState.Parent = this.login;
            this.login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.HoverState.Parent = this.login;
            this.login.Location = new System.Drawing.Point(736, 476);
            this.login.Name = "login";
            this.login.ShadowDecoration.Parent = this.login;
            this.login.Size = new System.Drawing.Size(409, 45);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(730, 158);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(420, 65);
            this.welcomeLabel.TabIndex = 19;
            this.welcomeLabel.Text = "Welcome!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(731, 248);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(205, 25);
            this.usernameLabel.TabIndex = 18;
            this.usernameLabel.Text = "USERNAME OR EMAIL";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Animated = true;
            this.usernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.usernameTextBox.BorderRadius = 3;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.Parent = this.usernameTextBox;
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
            this.usernameTextBox.Location = new System.Drawing.Point(736, 278);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "Enter your name or email...";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(409, 47);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            this.usernameTextBox.Load += new System.EventHandler(this.usernameTextBox_Load);
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(731, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "PASSWORD";
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.forgotPassword.Location = new System.Drawing.Point(731, 431);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(178, 21);
            this.forgotPassword.TabIndex = 16;
            this.forgotPassword.Text = "Forgot your password?";
            this.forgotPassword.Click += new System.EventHandler(this.forgotPassword_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(164)))), ((int)(((byte)(255)))));
            this.createAccountLabel.Location = new System.Drawing.Point(909, 534);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(148, 21);
            this.createAccountLabel.TabIndex = 15;
            this.createAccountLabel.Text = " Create an Account";
            this.createAccountLabel.Click += new System.EventHandler(this.createAccountLabel_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Animated = true;
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BorderRadius = 3;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.Parent = this.passwordTextBox;
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedState.Parent = this.passwordTextBox;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
            this.passwordTextBox.Location = new System.Drawing.Point(736, 379);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "Enter your password...";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
            this.passwordTextBox.Size = new System.Drawing.Size(409, 47);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(830, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "New here?";
            // 
            // usernameRequired
            // 
            this.usernameRequired.AutoSize = true;
            this.usernameRequired.BackColor = System.Drawing.Color.Transparent;
            this.usernameRequired.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameRequired.ForeColor = System.Drawing.Color.Red;
            this.usernameRequired.Location = new System.Drawing.Point(931, 248);
            this.usernameRequired.Name = "usernameRequired";
            this.usernameRequired.Size = new System.Drawing.Size(97, 25);
            this.usernameRequired.TabIndex = 28;
            this.usernameRequired.Text = "- required";
            this.usernameRequired.Visible = false;
            // 
            // passwordRequired
            // 
            this.passwordRequired.AutoSize = true;
            this.passwordRequired.BackColor = System.Drawing.Color.Transparent;
            this.passwordRequired.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordRequired.ForeColor = System.Drawing.Color.Red;
            this.passwordRequired.Location = new System.Drawing.Point(839, 349);
            this.passwordRequired.Name = "passwordRequired";
            this.passwordRequired.Size = new System.Drawing.Size(97, 25);
            this.passwordRequired.TabIndex = 28;
            this.passwordRequired.Text = "- required";
            this.passwordRequired.Visible = false;
            // 
            // refreshPicture
            // 
            this.refreshPicture.BackColor = System.Drawing.Color.Transparent;
            this.refreshPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshPicture.Image = global::CricBlast_GUI.Properties.Resources.Refresh_Colored;
            this.refreshPicture.ImageRotate = 0F;
            this.refreshPicture.Location = new System.Drawing.Point(1126, 250);
            this.refreshPicture.Name = "refreshPicture";
            this.refreshPicture.ShadowDecoration.Parent = this.refreshPicture;
            this.refreshPicture.Size = new System.Drawing.Size(18, 18);
            this.refreshPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshPicture.TabIndex = 27;
            this.refreshPicture.TabStop = false;
            this.refreshPicture.UseTransparentBackground = true;
            this.refreshPicture.Click += new System.EventHandler(this.refreshPicture_Click);
            // 
            // loginAsPicture
            // 
            this.loginAsPicture.BackColor = System.Drawing.Color.Transparent;
            this.loginAsPicture.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginAsPicture.Image = global::CricBlast_GUI.Properties.Resources.Unknown_User;
            this.loginAsPicture.ImageRotate = 0F;
            this.loginAsPicture.Location = new System.Drawing.Point(1095, 247);
            this.loginAsPicture.Name = "loginAsPicture";
            this.loginAsPicture.ShadowDecoration.Parent = this.loginAsPicture;
            this.loginAsPicture.Size = new System.Drawing.Size(25, 26);
            this.loginAsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginAsPicture.TabIndex = 25;
            this.loginAsPicture.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Black;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(639, 85);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(2, 551);
            this.guna2PictureBox3.TabIndex = 23;
            this.guna2PictureBox3.TabStop = false;
            // 
            // eyePicture
            // 
            this.eyePicture.BackColor = System.Drawing.Color.Transparent;
            this.eyePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyePicture.Image = global::CricBlast_GUI.Properties.Resources.Eye_Close;
            this.eyePicture.ImageRotate = 0F;
            this.eyePicture.Location = new System.Drawing.Point(1103, 385);
            this.eyePicture.Name = "eyePicture";
            this.eyePicture.ShadowDecoration.Parent = this.eyePicture;
            this.eyePicture.Size = new System.Drawing.Size(32, 34);
            this.eyePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyePicture.TabIndex = 22;
            this.eyePicture.TabStop = false;
            this.eyePicture.UseTransparentBackground = true;
            this.eyePicture.Click += new System.EventHandler(this.eyePicture_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.logo.Location = new System.Drawing.Point(118, 159);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(446, 402);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.Controls.Add(this.passwordRequired);
            this.Controls.Add(this.usernameRequired);
            this.Controls.Add(this.refreshPicture);
            this.Controls.Add(this.loginAsPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.eyePicture);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refreshPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button login;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forgotPassword;
        private System.Windows.Forms.Label createAccountLabel;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox eyePicture;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox loginAsPicture;
        private Guna.UI2.WinForms.Guna2PictureBox refreshPicture;
        private System.Windows.Forms.Label usernameRequired;
        private System.Windows.Forms.Label passwordRequired;
        public System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}
