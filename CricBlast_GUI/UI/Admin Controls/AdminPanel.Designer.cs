
namespace CricBlast_GUI.UI.Admin_Controls
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.adminSubPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.adminMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.availabilityIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.availability = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.manageUser = new Guna.UI2.WinForms.Guna2Button();
            this.tournament = new Guna.UI2.WinForms.Guna2Button();
            this.projectDetails = new Guna.UI2.WinForms.Guna2Button();
            this.addUser = new Guna.UI2.WinForms.Guna2Button();
            this.dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.logout = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.loading = new System.Windows.Forms.Label();
            this.adminMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // adminSubPanel
            // 
            this.adminSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.adminSubPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.BackgroundHome;
            this.adminSubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminSubPanel.Location = new System.Drawing.Point(308, 0);
            this.adminSubPanel.Name = "adminSubPanel";
            this.adminSubPanel.ShadowDecoration.Parent = this.adminSubPanel;
            this.adminSubPanel.Size = new System.Drawing.Size(972, 720);
            this.adminSubPanel.TabIndex = 14;
            // 
            // adminMenuPanel
            // 
            this.adminMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminMenuPanel.BackgroundImage")));
            this.adminMenuPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.adminMenuPanel.Controls.Add(this.availabilityIcon);
            this.adminMenuPanel.Controls.Add(this.availability);
            this.adminMenuPanel.Controls.Add(this.usernameLabel);
            this.adminMenuPanel.Controls.Add(this.manageUser);
            this.adminMenuPanel.Controls.Add(this.tournament);
            this.adminMenuPanel.Controls.Add(this.projectDetails);
            this.adminMenuPanel.Controls.Add(this.addUser);
            this.adminMenuPanel.Controls.Add(this.dashboard);
            this.adminMenuPanel.Controls.Add(this.logout);
            this.adminMenuPanel.Controls.Add(this.logoPicture);
            this.adminMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.adminMenuPanel.Name = "adminMenuPanel";
            this.adminMenuPanel.ShadowDecoration.Depth = 5;
            this.adminMenuPanel.ShadowDecoration.Parent = this.adminMenuPanel;
            this.adminMenuPanel.Size = new System.Drawing.Size(308, 720);
            this.adminMenuPanel.TabIndex = 13;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2CirclePictureBox1.Image = global::CricBlast_GUI.Properties.Resources.Admin_Gray_Background;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(61, 563);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Enabled = true;
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // availabilityIcon
            // 
            this.availabilityIcon.FillColor = System.Drawing.Color.LimeGreen;
            this.availabilityIcon.ImageRotate = 0F;
            this.availabilityIcon.Location = new System.Drawing.Point(139, 602);
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
            this.availability.Location = new System.Drawing.Point(153, 596);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(68, 25);
            this.availability.TabIndex = 6;
            this.availability.Text = "Online";
            this.availability.Click += new System.EventHandler(this.availability_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(136, 563);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(86, 32);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Admin";
            // 
            // manageUser
            // 
            this.manageUser.BackColor = System.Drawing.Color.Transparent;
            this.manageUser.BorderRadius = 10;
            this.manageUser.CheckedState.Parent = this.manageUser;
            this.manageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageUser.CustomImages.Parent = this.manageUser;
            this.manageUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageUser.DisabledState.Parent = this.manageUser;
            this.manageUser.FillColor = System.Drawing.Color.Transparent;
            this.manageUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.manageUser.ForeColor = System.Drawing.Color.White;
            this.manageUser.HoverState.Parent = this.manageUser;
            this.manageUser.Image = global::CricBlast_GUI.Properties.Resources.Icon_ManageUser;
            this.manageUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageUser.ImageOffset = new System.Drawing.Point(3, 1);
            this.manageUser.Location = new System.Drawing.Point(45, 365);
            this.manageUser.Name = "manageUser";
            this.manageUser.ShadowDecoration.Parent = this.manageUser;
            this.manageUser.Size = new System.Drawing.Size(198, 45);
            this.manageUser.TabIndex = 1;
            this.manageUser.Text = "Manage Users";
            this.manageUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageUser.TextOffset = new System.Drawing.Point(2, 0);
            this.manageUser.Click += new System.EventHandler(this.manageUser_Click);
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
            this.tournament.ImageOffset = new System.Drawing.Point(3, 1);
            this.tournament.Location = new System.Drawing.Point(45, 223);
            this.tournament.Name = "tournament";
            this.tournament.ShadowDecoration.Parent = this.tournament;
            this.tournament.Size = new System.Drawing.Size(198, 45);
            this.tournament.TabIndex = 1;
            this.tournament.Text = "Tournament";
            this.tournament.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tournament.TextOffset = new System.Drawing.Point(2, 0);
            this.tournament.Click += new System.EventHandler(this.tournaments_Click);
            // 
            // projectDetails
            // 
            this.projectDetails.BackColor = System.Drawing.Color.Transparent;
            this.projectDetails.BorderRadius = 10;
            this.projectDetails.CheckedState.Parent = this.projectDetails;
            this.projectDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectDetails.CustomImages.Parent = this.projectDetails;
            this.projectDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.projectDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.projectDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.projectDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.projectDetails.DisabledState.Parent = this.projectDetails;
            this.projectDetails.FillColor = System.Drawing.Color.Transparent;
            this.projectDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.projectDetails.ForeColor = System.Drawing.Color.White;
            this.projectDetails.HoverState.Parent = this.projectDetails;
            this.projectDetails.Image = global::CricBlast_GUI.Properties.Resources.Icon_Info;
            this.projectDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectDetails.ImageOffset = new System.Drawing.Point(3, 1);
            this.projectDetails.Location = new System.Drawing.Point(45, 436);
            this.projectDetails.Name = "projectDetails";
            this.projectDetails.ShadowDecoration.Parent = this.projectDetails;
            this.projectDetails.Size = new System.Drawing.Size(198, 45);
            this.projectDetails.TabIndex = 1;
            this.projectDetails.Text = "Project Info";
            this.projectDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectDetails.TextOffset = new System.Drawing.Point(2, 0);
            this.projectDetails.Click += new System.EventHandler(this.projectDetails_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.BorderRadius = 10;
            this.addUser.CheckedState.Parent = this.addUser;
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.CustomImages.Parent = this.addUser;
            this.addUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUser.DisabledState.Parent = this.addUser;
            this.addUser.FillColor = System.Drawing.Color.Transparent;
            this.addUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.addUser.ForeColor = System.Drawing.Color.White;
            this.addUser.HoverState.Parent = this.addUser;
            this.addUser.Image = global::CricBlast_GUI.Properties.Resources.Icon_AddUser;
            this.addUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addUser.ImageOffset = new System.Drawing.Point(3, 1);
            this.addUser.Location = new System.Drawing.Point(45, 294);
            this.addUser.Name = "addUser";
            this.addUser.ShadowDecoration.Parent = this.addUser;
            this.addUser.Size = new System.Drawing.Size(198, 45);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "Add Users";
            this.addUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addUser.TextOffset = new System.Drawing.Point(2, 0);
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // dashboard
            // 
            this.dashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dashboard.BackColor = System.Drawing.Color.Transparent;
            this.dashboard.BorderRadius = 10;
            this.dashboard.CheckedState.Parent = this.dashboard;
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.CustomImages.Parent = this.dashboard;
            this.dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboard.DisabledState.Parent = this.dashboard;
            this.dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.HoverState.Parent = this.dashboard;
            this.dashboard.Image = global::CricBlast_GUI.Properties.Resources.Icon_Dashboard;
            this.dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboard.ImageOffset = new System.Drawing.Point(3, 1);
            this.dashboard.Location = new System.Drawing.Point(45, 152);
            this.dashboard.Name = "dashboard";
            this.dashboard.ShadowDecoration.Parent = this.dashboard;
            this.dashboard.Size = new System.Drawing.Size(198, 45);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboard.TextOffset = new System.Drawing.Point(2, 0);
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.logout.Location = new System.Drawing.Point(110, 640);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 30);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPicture.Image = global::CricBlast_GUI.Properties.Resources.Admin_Panel;
            this.logoPicture.Location = new System.Drawing.Point(50, 52);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(188, 69);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            this.logoPicture.Click += new System.EventHandler(this.logoPicture_Click);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.adminMenuPanel;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.adminSubPanel;
            this.DragControl2.TransparentWhileDrag = false;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.BackColor = System.Drawing.Color.Transparent;
            this.loading.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.loading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loading.Location = new System.Drawing.Point(706, 337);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(176, 46);
            this.loading.TabIndex = 20;
            this.loading.Text = "Loading...";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.Controls.Add(this.loading);
            this.Controls.Add(this.adminSubPanel);
            this.Controls.Add(this.adminMenuPanel);
            this.DoubleBuffered = true;
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.adminMenuPanel.ResumeLayout(false);
            this.adminMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel adminSubPanel;
        private Guna.UI2.WinForms.Guna2Panel adminMenuPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox availabilityIcon;
        private System.Windows.Forms.Label availability;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2Button manageUser;
        private Guna.UI2.WinForms.Guna2Button tournament;
        private Guna.UI2.WinForms.Guna2Button projectDetails;
        private Guna.UI2.WinForms.Guna2Button addUser;
        private Guna.UI2.WinForms.Guna2Button dashboard;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.PictureBox logoPicture;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
        private System.Windows.Forms.Label loading;
    }
}
