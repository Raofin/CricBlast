
namespace CricBlast_GUI.UI
{
    partial class AdminProfileView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfileView));
            this.closeMiddle = new Guna.UI2.WinForms.Guna2Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.changeProfilePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.won = new System.Windows.Forms.Label();
            this.genderPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.played = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modifyButton = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.accountCreated = new System.Windows.Forms.Label();
            this.userCirclePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordError = new System.Windows.Forms.Label();
            this.emailError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.mobileError = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.changeProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePicture)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeMiddle
            // 
            this.closeMiddle.BackColor = System.Drawing.Color.Transparent;
            this.closeMiddle.BorderRadius = 4;
            this.closeMiddle.CheckedState.Parent = this.closeMiddle;
            this.closeMiddle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeMiddle.CustomImages.Parent = this.closeMiddle;
            this.closeMiddle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeMiddle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeMiddle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeMiddle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeMiddle.DisabledState.Parent = this.closeMiddle;
            this.closeMiddle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.closeMiddle.ForeColor = System.Drawing.Color.White;
            this.closeMiddle.HoverState.Parent = this.closeMiddle;
            this.closeMiddle.Location = new System.Drawing.Point(177, 560);
            this.closeMiddle.Name = "closeMiddle";
            this.closeMiddle.ShadowDecoration.Parent = this.closeMiddle;
            this.closeMiddle.Size = new System.Drawing.Size(180, 45);
            this.closeMiddle.TabIndex = 44;
            this.closeMiddle.Text = "Close";
            this.closeMiddle.Visible = false;
            this.closeMiddle.Click += new System.EventHandler(this.closeMiddle_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(182, 382);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(87, 32);
            this.phoneLabel.TabIndex = 30;
            this.phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(172, 298);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(65, 29);
            this.emailLabel.TabIndex = 29;
            this.emailLabel.Text = "Email";
            // 
            // changeProfilePicture
            // 
            this.changeProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.changeProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeProfilePicture.Image = global::CricBlast_GUI.Properties.Resources.RefreshShadowed_Colored;
            this.changeProfilePicture.ImageRotate = 0F;
            this.changeProfilePicture.Location = new System.Drawing.Point(302, 184);
            this.changeProfilePicture.Name = "changeProfilePicture";
            this.changeProfilePicture.ShadowDecoration.Parent = this.changeProfilePicture;
            this.changeProfilePicture.Size = new System.Drawing.Size(40, 40);
            this.changeProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changeProfilePicture.TabIndex = 39;
            this.changeProfilePicture.TabStop = false;
            this.changeProfilePicture.UseTransparentBackground = true;
            this.changeProfilePicture.Visible = false;
            this.changeProfilePicture.Click += new System.EventHandler(this.changeProfilePicture_Click);
            // 
            // won
            // 
            this.won.AutoSize = true;
            this.won.BackColor = System.Drawing.Color.Transparent;
            this.won.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.won.ForeColor = System.Drawing.Color.White;
            this.won.Location = new System.Drawing.Point(411, 468);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(29, 32);
            this.won.TabIndex = 43;
            this.won.Text = "0";
            // 
            // genderPicture
            // 
            this.genderPicture.BackColor = System.Drawing.Color.Transparent;
            this.genderPicture.BorderRadius = 4;
            this.genderPicture.Image = global::CricBlast_GUI.Properties.Resources.Unknown_User;
            this.genderPicture.ImageRotate = 0F;
            this.genderPicture.Location = new System.Drawing.Point(196, 426);
            this.genderPicture.Name = "genderPicture";
            this.genderPicture.ShadowDecoration.Parent = this.genderPicture;
            this.genderPicture.Size = new System.Drawing.Size(30, 30);
            this.genderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.genderPicture.TabIndex = 34;
            this.genderPicture.TabStop = false;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.genderLabel.ForeColor = System.Drawing.Color.White;
            this.genderLabel.Location = new System.Drawing.Point(232, 425);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(71, 32);
            this.genderLabel.TabIndex = 32;
            this.genderLabel.Text = "Male";
            // 
            // played
            // 
            this.played.AutoSize = true;
            this.played.BackColor = System.Drawing.Color.Transparent;
            this.played.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.played.ForeColor = System.Drawing.Color.White;
            this.played.Location = new System.Drawing.Point(275, 468);
            this.played.Name = "played";
            this.played.Size = new System.Drawing.Size(29, 32);
            this.played.TabIndex = 41;
            this.played.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(351, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 42;
            this.label6.Text = "Won";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(89, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 32);
            this.label5.TabIndex = 42;
            this.label5.Text = "Matches Played";
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.Transparent;
            this.modifyButton.BorderRadius = 4;
            this.modifyButton.CheckedState.Parent = this.modifyButton;
            this.modifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.modifyButton.Location = new System.Drawing.Point(289, 560);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.ShadowDecoration.Parent = this.modifyButton;
            this.modifyButton.Size = new System.Drawing.Size(180, 45);
            this.modifyButton.TabIndex = 5;
            this.modifyButton.Text = "Modify";
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BorderRadius = 4;
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.CustomImages.Parent = this.closeButton;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.DisabledState.Parent = this.closeButton;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Location = new System.Drawing.Point(72, 560);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(180, 45);
            this.closeButton.TabIndex = 27;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(89, 511);
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
            this.accountCreated.Location = new System.Drawing.Point(291, 511);
            this.accountCreated.Name = "accountCreated";
            this.accountCreated.Size = new System.Drawing.Size(149, 32);
            this.accountCreated.TabIndex = 32;
            this.accountCreated.Text = "10/12/2021";
            // 
            // userCirclePicture
            // 
            this.userCirclePicture.BackColor = System.Drawing.Color.Transparent;
            this.userCirclePicture.Image = ((System.Drawing.Image)(resources.GetObject("userCirclePicture.Image")));
            this.userCirclePicture.ImageRotate = 0F;
            this.userCirclePicture.Location = new System.Drawing.Point(177, 44);
            this.userCirclePicture.Name = "userCirclePicture";
            this.userCirclePicture.ShadowDecoration.Depth = 15;
            this.userCirclePicture.ShadowDecoration.Enabled = true;
            this.userCirclePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userCirclePicture.ShadowDecoration.Parent = this.userCirclePicture;
            this.userCirclePicture.Size = new System.Drawing.Size(180, 180);
            this.userCirclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userCirclePicture.TabIndex = 25;
            this.userCirclePicture.TabStop = false;
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
            this.emailTextBox.Location = new System.Drawing.Point(177, 295);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Email...";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.ShadowDecoration.Parent = this.emailTextBox;
            this.emailTextBox.Size = new System.Drawing.Size(276, 35);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Visible = false;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
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
            this.phoneTextBox.Location = new System.Drawing.Point(188, 381);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PlaceholderText = "Phone number...";
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.ShadowDecoration.Parent = this.phoneTextBox;
            this.phoneTextBox.Size = new System.Drawing.Size(265, 35);
            this.phoneTextBox.TabIndex = 4;
            this.phoneTextBox.Visible = false;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.BackColor = System.Drawing.Color.Transparent;
            this.passwordError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(461, 339);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(22, 32);
            this.passwordError.TabIndex = 52;
            this.passwordError.Text = "!";
            this.passwordError.Visible = false;
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.BackColor = System.Drawing.Color.Transparent;
            this.emailError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailError.ForeColor = System.Drawing.Color.Red;
            this.emailError.Location = new System.Drawing.Point(461, 296);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(22, 32);
            this.emailError.TabIndex = 51;
            this.emailError.Text = "!";
            this.emailError.Visible = false;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.BackColor = System.Drawing.Color.Transparent;
            this.usernameError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(461, 253);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(22, 32);
            this.usernameError.TabIndex = 50;
            this.usernameError.Text = "!";
            this.usernameError.Visible = false;
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // mobileError
            // 
            this.mobileError.AutoSize = true;
            this.mobileError.BackColor = System.Drawing.Color.Transparent;
            this.mobileError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileError.ForeColor = System.Drawing.Color.Red;
            this.mobileError.Location = new System.Drawing.Point(461, 382);
            this.mobileError.Name = "mobileError";
            this.mobileError.Size = new System.Drawing.Size(22, 32);
            this.mobileError.TabIndex = 53;
            this.mobileError.Text = "!";
            this.mobileError.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(89, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 32);
            this.label12.TabIndex = 47;
            this.label12.Text = "Gender";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(216, 339);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(123, 32);
            this.passwordLabel.TabIndex = 45;
            this.passwordLabel.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(89, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(89, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 32);
            this.label8.TabIndex = 44;
            this.label8.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(89, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 32);
            this.label3.TabIndex = 43;
            this.label3.Text = "Email";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(224, 253);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(129, 32);
            this.usernameLabel.TabIndex = 41;
            this.usernameLabel.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(89, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 42;
            this.label2.Text = "Username";
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
            this.passwordTextBox.Location = new System.Drawing.Point(220, 338);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "Password...";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.ShadowDecoration.Parent = this.passwordTextBox;
            this.passwordTextBox.Size = new System.Drawing.Size(233, 35);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Visible = false;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
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
            this.usernameTextBox.Location = new System.Drawing.Point(226, 252);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "Username...";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(227, 35);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Visible = false;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            this.usernameTextBox.Load += new System.EventHandler(this.usernameTextBox_Load);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.closeMiddle);
            this.guna2Panel1.Controls.Add(this.phoneLabel);
            this.guna2Panel1.Controls.Add(this.emailLabel);
            this.guna2Panel1.Controls.Add(this.changeProfilePicture);
            this.guna2Panel1.Controls.Add(this.won);
            this.guna2Panel1.Controls.Add(this.genderPicture);
            this.guna2Panel1.Controls.Add(this.genderLabel);
            this.guna2Panel1.Controls.Add(this.played);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.modifyButton);
            this.guna2Panel1.Controls.Add(this.closeButton);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.accountCreated);
            this.guna2Panel1.Controls.Add(this.userCirclePicture);
            this.guna2Panel1.Controls.Add(this.emailTextBox);
            this.guna2Panel1.Controls.Add(this.phoneTextBox);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(534, 646);
            this.guna2Panel1.TabIndex = 54;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.guna2Panel1;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // AdminProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(534, 646);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.emailError);
            this.Controls.Add(this.usernameError);
            this.Controls.Add(this.mobileError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.guna2Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminProfileView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            ((System.ComponentModel.ISupportInitialize)(this.changeProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePicture)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button closeMiddle;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private Guna.UI2.WinForms.Guna2PictureBox changeProfilePicture;
        private System.Windows.Forms.Label won;
        private Guna.UI2.WinForms.Guna2PictureBox genderPicture;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label played;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button modifyButton;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountCreated;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userCirclePicture;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label usernameError;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label mobileError;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}