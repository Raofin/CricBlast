
namespace CricBlast_GUI.Forms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.modifyButton = new Guna.UI2.WinForms.Guna2Button();
            this.userCirclePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.close = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.accountCreated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyButton
            // 
            this.modifyButton.Animated = true;
            this.modifyButton.BackColor = System.Drawing.Color.Transparent;
            this.modifyButton.BorderRadius = 4;
            this.modifyButton.CheckedState.Parent = this.modifyButton;
            this.modifyButton.CustomImages.Parent = this.modifyButton;
            this.modifyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modifyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modifyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modifyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modifyButton.DisabledState.Parent = this.modifyButton;
            this.modifyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(92)))));
            this.modifyButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.modifyButton.ForeColor = System.Drawing.Color.White;
            this.modifyButton.HoverState.Parent = this.modifyButton;
            this.modifyButton.Location = new System.Drawing.Point(289, 550);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.ShadowDecoration.Parent = this.modifyButton;
            this.modifyButton.Size = new System.Drawing.Size(180, 45);
            this.modifyButton.TabIndex = 27;
            this.modifyButton.Text = "Modify";
            this.modifyButton.Click += new System.EventHandler(this.modify_Click);
            // 
            // userCirclePicture
            // 
            this.userCirclePicture.BackColor = System.Drawing.Color.Transparent;
            this.userCirclePicture.Image = ((System.Drawing.Image)(resources.GetObject("userCirclePicture.Image")));
            this.userCirclePicture.ImageRotate = 0F;
            this.userCirclePicture.Location = new System.Drawing.Point(167, 46);
            this.userCirclePicture.Name = "userCirclePicture";
            this.userCirclePicture.ShadowDecoration.Depth = 15;
            this.userCirclePicture.ShadowDecoration.Enabled = true;
            this.userCirclePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userCirclePicture.ShadowDecoration.Parent = this.userCirclePicture;
            this.userCirclePicture.Size = new System.Drawing.Size(200, 200);
            this.userCirclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userCirclePicture.TabIndex = 25;
            this.userCirclePicture.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(89, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 32);
            this.label12.TabIndex = 32;
            this.label12.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(89, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(89, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(89, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(89, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "Username";
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
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
            this.usernameTextBox.Location = new System.Drawing.Point(226, 270);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "Username...";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(227, 35);
            this.usernameTextBox.TabIndex = 33;
            this.usernameTextBox.Visible = false;
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
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.HoverState.Parent = this.emailTextBox;
            this.emailTextBox.Location = new System.Drawing.Point(226, 316);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Email...";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(227, 35);
            this.emailTextBox.TabIndex = 33;
            this.emailTextBox.Visible = false;
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
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.HoverState.Parent = this.passwordTextBox;
            this.passwordTextBox.Location = new System.Drawing.Point(226, 362);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "Password...";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
            this.passwordTextBox.Size = new System.Drawing.Size(227, 35);
            this.passwordTextBox.TabIndex = 33;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Visible = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Animated = true;
            this.phoneTextBox.BackColor = System.Drawing.Color.Transparent;
            this.phoneTextBox.BorderRadius = 3;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.DefaultText = "";
            this.phoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.DisabledState.Parent = this.phoneTextBox;
            this.phoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.FocusedState.Parent = this.phoneTextBox;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.phoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.HoverState.Parent = this.phoneTextBox;
            this.phoneTextBox.Location = new System.Drawing.Point(226, 408);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PlaceholderText = "Phone number...";
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.ShadowDecoration.Parent = this.phoneTextBox;
            this.phoneTextBox.Size = new System.Drawing.Size(227, 35);
            this.phoneTextBox.TabIndex = 33;
            this.phoneTextBox.Visible = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(264, 455);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(71, 32);
            this.genderLabel.TabIndex = 32;
            this.genderLabel.Text = "Male";
            // 
            // genderPicture
            // 
            this.genderPicture.BackColor = System.Drawing.Color.Transparent;
            this.genderPicture.BorderRadius = 4;
            this.genderPicture.Image = global::CricBlast_GUI.Properties.Resources.Unknown_User;
            this.genderPicture.ImageRotate = 0F;
            this.genderPicture.Location = new System.Drawing.Point(228, 456);
            this.genderPicture.Name = "genderPicture";
            this.genderPicture.ShadowDecoration.Parent = this.genderPicture;
            this.genderPicture.Size = new System.Drawing.Size(30, 30);
            this.genderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.genderPicture.TabIndex = 34;
            this.genderPicture.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(222, 271);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(129, 32);
            this.usernameLabel.TabIndex = 28;
            this.usernameLabel.Text = "Username";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(222, 317);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(77, 32);
            this.emailLabel.TabIndex = 29;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(222, 409);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(87, 32);
            this.phoneLabel.TabIndex = 30;
            this.phoneLabel.Text = "Phone";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(222, 363);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(123, 32);
            this.passwordLabel.TabIndex = 31;
            this.passwordLabel.Text = "Password";
            // 
            // close
            // 
            this.close.Animated = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BorderRadius = 4;
            this.close.CheckedState.Parent = this.close;
            this.close.CustomImages.Parent = this.close;
            this.close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close.DisabledState.Parent = this.close;
            this.close.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.HoverState.Parent = this.close;
            this.close.Location = new System.Drawing.Point(72, 550);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(180, 45);
            this.close.TabIndex = 27;
            this.close.Text = "Close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(89, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Account Created";
            // 
            // accountCreated
            // 
            this.accountCreated.AutoSize = true;
            this.accountCreated.BackColor = System.Drawing.Color.Transparent;
            this.accountCreated.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.accountCreated.ForeColor = System.Drawing.Color.White;
            this.accountCreated.Location = new System.Drawing.Point(297, 501);
            this.accountCreated.Name = "accountCreated";
            this.accountCreated.Size = new System.Drawing.Size(149, 32);
            this.accountCreated.TabIndex = 32;
            this.accountCreated.Text = "10/12/2021";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(534, 647);
            this.Controls.Add(this.genderPicture);
            this.Controls.Add(this.accountCreated);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.userCirclePicture);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button modifyButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userCirclePicture;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label genderLabel;
        private Guna.UI2.WinForms.Guna2PictureBox genderPicture;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2Button close;
        private System.Windows.Forms.Label accountCreated;
        private System.Windows.Forms.Label label1;
    }
}