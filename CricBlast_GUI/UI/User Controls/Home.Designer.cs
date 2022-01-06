
namespace CricBlast_GUI.UI.User_Controls
{
    partial class Home
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
            this.homeSubPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tournament = new Guna.UI2.WinForms.Guna2Button();
            this.availabilityIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.availability = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.customizeTeam = new Guna.UI2.WinForms.Guna2Button();
            this.playerStats = new Guna.UI2.WinForms.Guna2Button();
            this.playMatch = new Guna.UI2.WinForms.Guna2Button();
            this.addPlayers = new Guna.UI2.WinForms.Guna2Button();
            this.myTeam = new Guna.UI2.WinForms.Guna2Button();
            this.logout = new System.Windows.Forms.Label();
            this.cricBlastLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.loading = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // homeSubPanel
            // 
            this.homeSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.homeSubPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.BackgroundHome;
            this.homeSubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeSubPanel.Location = new System.Drawing.Point(308, 0);
            this.homeSubPanel.Name = "homeSubPanel";
            this.homeSubPanel.ShadowDecoration.Parent = this.homeSubPanel;
            this.homeSubPanel.Size = new System.Drawing.Size(972, 720);
            this.homeSubPanel.TabIndex = 12;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Home_Menu;
            this.menuPanel.Controls.Add(this.tournament);
            this.menuPanel.Controls.Add(this.availabilityIcon);
            this.menuPanel.Controls.Add(this.availability);
            this.menuPanel.Controls.Add(this.usernameLabel);
            this.menuPanel.Controls.Add(this.userPhoto);
            this.menuPanel.Controls.Add(this.customizeTeam);
            this.menuPanel.Controls.Add(this.playerStats);
            this.menuPanel.Controls.Add(this.playMatch);
            this.menuPanel.Controls.Add(this.addPlayers);
            this.menuPanel.Controls.Add(this.myTeam);
            this.menuPanel.Controls.Add(this.logout);
            this.menuPanel.Controls.Add(this.cricBlastLabel);
            this.menuPanel.Controls.Add(this.logoPicture);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.ShadowDecoration.Parent = this.menuPanel;
            this.menuPanel.Size = new System.Drawing.Size(308, 720);
            this.menuPanel.TabIndex = 11;
            // 
            // tournament
            // 
            this.tournament.BackColor = System.Drawing.Color.Transparent;
            this.tournament.BorderRadius = 10;
            this.tournament.CheckedState.Parent = this.tournament;
            this.tournament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tournament.CustomImages.Parent = this.tournament;
            this.tournament.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tournament.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tournament.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tournament.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tournament.DisabledState.Parent = this.tournament;
            this.tournament.FillColor = System.Drawing.Color.Transparent;
            this.tournament.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.tournament.ForeColor = System.Drawing.Color.White;
            this.tournament.HoverState.Parent = this.tournament;
            this.tournament.Image = global::CricBlast_GUI.Properties.Resources.Icon_Tournament;
            this.tournament.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tournament.ImageOffset = new System.Drawing.Point(3, 2);
            this.tournament.Location = new System.Drawing.Point(45, 482);
            this.tournament.Name = "tournament";
            this.tournament.ShadowDecoration.Parent = this.tournament;
            this.tournament.Size = new System.Drawing.Size(198, 45);
            this.tournament.TabIndex = 8;
            this.tournament.Text = "Tournament";
            this.tournament.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tournament.TextOffset = new System.Drawing.Point(2, 0);
            this.tournament.Click += new System.EventHandler(this.tournament_Click);
            // 
            // availabilityIcon
            // 
            this.availabilityIcon.FillColor = System.Drawing.Color.LimeGreen;
            this.availabilityIcon.ImageRotate = 0F;
            this.availabilityIcon.Location = new System.Drawing.Point(127, 602);
            this.availabilityIcon.Name = "availabilityIcon";
            this.availabilityIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.availabilityIcon.ShadowDecoration.Parent = this.availabilityIcon;
            this.availabilityIcon.Size = new System.Drawing.Size(14, 14);
            this.availabilityIcon.TabIndex = 7;
            this.availabilityIcon.TabStop = false;
            // 
            // availability
            // 
            this.availability.AutoSize = true;
            this.availability.BackColor = System.Drawing.Color.Transparent;
            this.availability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.availability.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availability.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.availability.Location = new System.Drawing.Point(141, 596);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(68, 25);
            this.availability.TabIndex = 6;
            this.availability.Text = "Online";
            this.availability.Click += new System.EventHandler(this.availability_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(119, 563);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(151, 32);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // userPhoto
            // 
            this.userPhoto.BackColor = System.Drawing.Color.Transparent;
            this.userPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPhoto.Image = global::CricBlast_GUI.Properties.Resources.User_Male_WhiteBack;
            this.userPhoto.ImageRotate = 0F;
            this.userPhoto.Location = new System.Drawing.Point(49, 563);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.ShadowDecoration.Enabled = true;
            this.userPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPhoto.ShadowDecoration.Parent = this.userPhoto;
            this.userPhoto.Size = new System.Drawing.Size(64, 64);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 5;
            this.userPhoto.TabStop = false;
            this.userPhoto.Click += new System.EventHandler(this.userPhoto_Click);
            // 
            // customizeTeam
            // 
            this.customizeTeam.BackColor = System.Drawing.Color.Transparent;
            this.customizeTeam.BorderRadius = 10;
            this.customizeTeam.CheckedState.Parent = this.customizeTeam;
            this.customizeTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customizeTeam.CustomImages.Parent = this.customizeTeam;
            this.customizeTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customizeTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customizeTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customizeTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customizeTeam.DisabledState.Parent = this.customizeTeam;
            this.customizeTeam.FillColor = System.Drawing.Color.Transparent;
            this.customizeTeam.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.customizeTeam.ForeColor = System.Drawing.Color.White;
            this.customizeTeam.HoverState.Parent = this.customizeTeam;
            this.customizeTeam.Image = global::CricBlast_GUI.Properties.Resources.Icon_CustomizeTeam;
            this.customizeTeam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customizeTeam.ImageOffset = new System.Drawing.Point(3, 1);
            this.customizeTeam.Location = new System.Drawing.Point(45, 342);
            this.customizeTeam.Name = "customizeTeam";
            this.customizeTeam.ShadowDecoration.Parent = this.customizeTeam;
            this.customizeTeam.Size = new System.Drawing.Size(215, 45);
            this.customizeTeam.TabIndex = 1;
            this.customizeTeam.Text = "Customize Team";
            this.customizeTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customizeTeam.TextOffset = new System.Drawing.Point(2, 0);
            this.customizeTeam.Click += new System.EventHandler(this.customizeTeam_Click);
            // 
            // playerStats
            // 
            this.playerStats.BackColor = System.Drawing.Color.Transparent;
            this.playerStats.BorderRadius = 10;
            this.playerStats.CheckedState.Parent = this.playerStats;
            this.playerStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerStats.CustomImages.Parent = this.playerStats;
            this.playerStats.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playerStats.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playerStats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playerStats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playerStats.DisabledState.Parent = this.playerStats;
            this.playerStats.FillColor = System.Drawing.Color.Transparent;
            this.playerStats.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.playerStats.ForeColor = System.Drawing.Color.White;
            this.playerStats.HoverState.Parent = this.playerStats;
            this.playerStats.Image = global::CricBlast_GUI.Properties.Resources.Icon_PlayerStats;
            this.playerStats.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playerStats.ImageOffset = new System.Drawing.Point(3, 0);
            this.playerStats.Location = new System.Drawing.Point(45, 202);
            this.playerStats.Name = "playerStats";
            this.playerStats.ShadowDecoration.Parent = this.playerStats;
            this.playerStats.Size = new System.Drawing.Size(198, 45);
            this.playerStats.TabIndex = 1;
            this.playerStats.Text = "Player Stats";
            this.playerStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playerStats.TextOffset = new System.Drawing.Point(2, 0);
            this.playerStats.Click += new System.EventHandler(this.playerStats_Click);
            // 
            // playMatch
            // 
            this.playMatch.BackColor = System.Drawing.Color.Transparent;
            this.playMatch.BorderRadius = 10;
            this.playMatch.CheckedState.Parent = this.playMatch;
            this.playMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playMatch.CustomImages.Parent = this.playMatch;
            this.playMatch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playMatch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playMatch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playMatch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playMatch.DisabledState.Parent = this.playMatch;
            this.playMatch.FillColor = System.Drawing.Color.Transparent;
            this.playMatch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.playMatch.ForeColor = System.Drawing.Color.White;
            this.playMatch.HoverState.Parent = this.playMatch;
            this.playMatch.Image = global::CricBlast_GUI.Properties.Resources.Icon_Play;
            this.playMatch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playMatch.ImageOffset = new System.Drawing.Point(3, 1);
            this.playMatch.Location = new System.Drawing.Point(45, 412);
            this.playMatch.Name = "playMatch";
            this.playMatch.ShadowDecoration.Parent = this.playMatch;
            this.playMatch.Size = new System.Drawing.Size(198, 45);
            this.playMatch.TabIndex = 1;
            this.playMatch.Text = "Play a Match";
            this.playMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.playMatch.TextOffset = new System.Drawing.Point(2, 0);
            this.playMatch.Click += new System.EventHandler(this.playMatch_Click);
            // 
            // addPlayers
            // 
            this.addPlayers.BackColor = System.Drawing.Color.Transparent;
            this.addPlayers.BorderRadius = 10;
            this.addPlayers.CheckedState.Parent = this.addPlayers;
            this.addPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPlayers.CustomImages.Parent = this.addPlayers;
            this.addPlayers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addPlayers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addPlayers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addPlayers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addPlayers.DisabledState.Parent = this.addPlayers;
            this.addPlayers.FillColor = System.Drawing.Color.Transparent;
            this.addPlayers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.addPlayers.ForeColor = System.Drawing.Color.White;
            this.addPlayers.HoverState.Parent = this.addPlayers;
            this.addPlayers.Image = global::CricBlast_GUI.Properties.Resources.Icon_AddUser;
            this.addPlayers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addPlayers.ImageOffset = new System.Drawing.Point(3, 1);
            this.addPlayers.Location = new System.Drawing.Point(45, 272);
            this.addPlayers.Name = "addPlayers";
            this.addPlayers.ShadowDecoration.Parent = this.addPlayers;
            this.addPlayers.Size = new System.Drawing.Size(198, 45);
            this.addPlayers.TabIndex = 1;
            this.addPlayers.Text = "Add Players";
            this.addPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addPlayers.TextOffset = new System.Drawing.Point(2, 0);
            this.addPlayers.Click += new System.EventHandler(this.addPlayers_Click);
            // 
            // myTeam
            // 
            this.myTeam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myTeam.BackColor = System.Drawing.Color.Transparent;
            this.myTeam.BorderRadius = 10;
            this.myTeam.CheckedState.Parent = this.myTeam;
            this.myTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myTeam.CustomImages.Parent = this.myTeam;
            this.myTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.myTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.myTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.myTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.myTeam.DisabledState.Parent = this.myTeam;
            this.myTeam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.myTeam.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.myTeam.ForeColor = System.Drawing.Color.White;
            this.myTeam.HoverState.Parent = this.myTeam;
            this.myTeam.Image = global::CricBlast_GUI.Properties.Resources.Icon_MyTeam;
            this.myTeam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.myTeam.ImageOffset = new System.Drawing.Point(3, 1);
            this.myTeam.Location = new System.Drawing.Point(45, 132);
            this.myTeam.Name = "myTeam";
            this.myTeam.ShadowDecoration.Parent = this.myTeam;
            this.myTeam.Size = new System.Drawing.Size(198, 45);
            this.myTeam.TabIndex = 1;
            this.myTeam.Text = "My Team";
            this.myTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.myTeam.TextOffset = new System.Drawing.Point(2, 0);
            this.myTeam.Click += new System.EventHandler(this.myTeam_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.logout.Location = new System.Drawing.Point(106, 640);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 30);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // cricBlastLabel
            // 
            this.cricBlastLabel.AutoSize = true;
            this.cricBlastLabel.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cricBlastLabel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.cricBlastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cricBlastLabel.Location = new System.Drawing.Point(103, 50);
            this.cricBlastLabel.Name = "cricBlastLabel";
            this.cricBlastLabel.Size = new System.Drawing.Size(165, 46);
            this.cricBlastLabel.TabIndex = 4;
            this.cricBlastLabel.Text = "CricBlast";
            this.cricBlastLabel.Click += new System.EventHandler(this.cricBlastLabel_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPicture.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.logoPicture.Location = new System.Drawing.Point(45, 41);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(57, 64);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            this.logoPicture.Click += new System.EventHandler(this.logoPicture_Click);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.menuPanel;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.homeSubPanel;
            this.DragControl2.TransparentWhileDrag = false;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.loading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loading.Location = new System.Drawing.Point(696, 337);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(176, 46);
            this.loading.TabIndex = 19;
            this.loading.Text = "Loading...";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.Controls.Add(this.loading);
            this.Controls.Add(this.homeSubPanel);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox availabilityIcon;
        private System.Windows.Forms.Label availability;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPhoto;
        private Guna.UI2.WinForms.Guna2Button customizeTeam;
        private Guna.UI2.WinForms.Guna2Button playerStats;
        private Guna.UI2.WinForms.Guna2Button playMatch;
        private Guna.UI2.WinForms.Guna2Button addPlayers;
        private Guna.UI2.WinForms.Guna2Button myTeam;
        private System.Windows.Forms.Label cricBlastLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private Guna.UI2.WinForms.Guna2Panel homeSubPanel;
        private System.Windows.Forms.Label logout;
        private Guna.UI2.WinForms.Guna2Button tournament;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private System.Windows.Forms.Label loading;
    }
}
