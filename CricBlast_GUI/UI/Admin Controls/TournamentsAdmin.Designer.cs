
namespace CricBlast_GUI.UI.Admin_Controls
{
    partial class TournamentsAdmin
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
            this.matchTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.selectStadiums = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.selectTeams = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startTournament = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeTrophy = new Guna.UI2.WinForms.Guna2Button();
            this.formatComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trophyPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // matchTitle
            // 
            this.matchTitle.BackColor = System.Drawing.Color.Transparent;
            this.matchTitle.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold);
            this.matchTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matchTitle.Location = new System.Drawing.Point(92, 60);
            this.matchTitle.Name = "matchTitle";
            this.matchTitle.Size = new System.Drawing.Size(788, 66);
            this.matchTitle.TabIndex = 22;
            this.matchTitle.Text = "TOURNAMENT";
            this.matchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.selectStadiums);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.selectTeams);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.startTournament);
            this.guna2Panel1.Controls.Add(this.guna2ComboBox1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.changeTrophy);
            this.guna2Panel1.Controls.Add(this.formatComboBox);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.trophyPictureBox);
            this.guna2Panel1.Controls.Add(this.usernameTextBox);
            this.guna2Panel1.Controls.Add(this.usernameLabel);
            this.guna2Panel1.Controls.Add(this.matchTitle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(972, 720);
            this.guna2Panel1.TabIndex = 23;
            // 
            // selectStadiums
            // 
            this.selectStadiums.BackColor = System.Drawing.Color.Transparent;
            this.selectStadiums.BorderRadius = 4;
            this.selectStadiums.CheckedState.Parent = this.selectStadiums;
            this.selectStadiums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectStadiums.CustomImages.Parent = this.selectStadiums;
            this.selectStadiums.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectStadiums.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectStadiums.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectStadiums.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectStadiums.DisabledState.Parent = this.selectStadiums;
            this.selectStadiums.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.selectStadiums.ForeColor = System.Drawing.Color.White;
            this.selectStadiums.HoverState.Parent = this.selectStadiums;
            this.selectStadiums.Location = new System.Drawing.Point(443, 538);
            this.selectStadiums.Name = "selectStadiums";
            this.selectStadiums.ShadowDecoration.Parent = this.selectStadiums;
            this.selectStadiums.Size = new System.Drawing.Size(409, 43);
            this.selectStadiums.TabIndex = 40;
            this.selectStadiums.Text = "Select Stadiums ";
            this.selectStadiums.Click += new System.EventHandler(this.selectStadiums_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(438, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "STADIUMS";
            // 
            // selectTeams
            // 
            this.selectTeams.BackColor = System.Drawing.Color.Transparent;
            this.selectTeams.BorderRadius = 4;
            this.selectTeams.CheckedState.Parent = this.selectTeams;
            this.selectTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectTeams.CustomImages.Parent = this.selectTeams;
            this.selectTeams.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectTeams.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectTeams.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectTeams.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectTeams.DisabledState.Parent = this.selectTeams;
            this.selectTeams.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.selectTeams.ForeColor = System.Drawing.Color.White;
            this.selectTeams.HoverState.Parent = this.selectTeams;
            this.selectTeams.Location = new System.Drawing.Point(443, 445);
            this.selectTeams.Name = "selectTeams";
            this.selectTeams.ShadowDecoration.Parent = this.selectTeams;
            this.selectTeams.Size = new System.Drawing.Size(409, 43);
            this.selectTeams.TabIndex = 38;
            this.selectTeams.Text = "Select Teams";
            this.selectTeams.Click += new System.EventHandler(this.selectTeams_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(438, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "TEAMS";
            // 
            // startTournament
            // 
            this.startTournament.BackColor = System.Drawing.Color.Transparent;
            this.startTournament.BorderRadius = 4;
            this.startTournament.CheckedState.Parent = this.startTournament;
            this.startTournament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startTournament.CustomImages.Parent = this.startTournament;
            this.startTournament.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startTournament.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startTournament.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startTournament.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.startTournament.DisabledState.Parent = this.startTournament;
            this.startTournament.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(161)))), ((int)(((byte)(92)))));
            this.startTournament.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.startTournament.ForeColor = System.Drawing.Color.White;
            this.startTournament.HoverState.Parent = this.startTournament;
            this.startTournament.Location = new System.Drawing.Point(315, 611);
            this.startTournament.Name = "startTournament";
            this.startTournament.ShadowDecoration.Parent = this.startTournament;
            this.startTournament.Size = new System.Drawing.Size(314, 44);
            this.startTournament.TabIndex = 35;
            this.startTournament.Text = "Start Tournament";
            this.startTournament.Click += new System.EventHandler(this.startTournament_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 4;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Select...",
            "3",
            "4",
            "6",
            "8"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(443, 359);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(409, 36);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(438, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "TOTAL TEAMS";
            // 
            // changeTrophy
            // 
            this.changeTrophy.BackColor = System.Drawing.Color.Transparent;
            this.changeTrophy.BorderRadius = 4;
            this.changeTrophy.CheckedState.Parent = this.changeTrophy;
            this.changeTrophy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeTrophy.CustomImages.Parent = this.changeTrophy;
            this.changeTrophy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeTrophy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeTrophy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeTrophy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeTrophy.DisabledState.Parent = this.changeTrophy;
            this.changeTrophy.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.changeTrophy.ForeColor = System.Drawing.Color.White;
            this.changeTrophy.HoverState.Parent = this.changeTrophy;
            this.changeTrophy.Location = new System.Drawing.Point(111, 538);
            this.changeTrophy.Name = "changeTrophy";
            this.changeTrophy.ShadowDecoration.Parent = this.changeTrophy;
            this.changeTrophy.Size = new System.Drawing.Size(260, 43);
            this.changeTrophy.TabIndex = 31;
            this.changeTrophy.Text = "Change Trophy";
            this.changeTrophy.Click += new System.EventHandler(this.choosePhoto_Click);
            // 
            // formatComboBox
            // 
            this.formatComboBox.BackColor = System.Drawing.Color.Transparent;
            this.formatComboBox.BorderRadius = 4;
            this.formatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.formatComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.formatComboBox.FocusedState.Parent = this.formatComboBox;
            this.formatComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.formatComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.formatComboBox.HoverState.Parent = this.formatComboBox;
            this.formatComboBox.ItemHeight = 30;
            this.formatComboBox.Items.AddRange(new object[] {
            "Select...",
            "Australia",
            "Bangladesh",
            "England",
            "India",
            "New Zealand",
            "Pakistan",
            "South Africa",
            "Sri Lanka",
            "West Indies"});
            this.formatComboBox.ItemsAppearance.Parent = this.formatComboBox;
            this.formatComboBox.Location = new System.Drawing.Point(443, 273);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.ShadowDecoration.Parent = this.formatComboBox;
            this.formatComboBox.Size = new System.Drawing.Size(409, 36);
            this.formatComboBox.StartIndex = 0;
            this.formatComboBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(438, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 29;
            this.label6.Text = "HOSTING COUNTRY";
            // 
            // trophyPictureBox
            // 
            this.trophyPictureBox.Image = global::CricBlast_GUI.Properties.Resources.Trophy;
            this.trophyPictureBox.ImageRotate = 0F;
            this.trophyPictureBox.Location = new System.Drawing.Point(101, 146);
            this.trophyPictureBox.Name = "trophyPictureBox";
            this.trophyPictureBox.ShadowDecoration.Parent = this.trophyPictureBox;
            this.trophyPictureBox.Size = new System.Drawing.Size(281, 380);
            this.trophyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trophyPictureBox.TabIndex = 25;
            this.trophyPictureBox.TabStop = false;
            this.trophyPictureBox.UseTransparentBackground = true;
            // 
            // usernameTextBox
            // 
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
            this.usernameTextBox.Location = new System.Drawing.Point(443, 176);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderText = "Enter tournament title...";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(409, 47);
            this.usernameTextBox.TabIndex = 23;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(438, 146);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(57, 25);
            this.usernameLabel.TabIndex = 24;
            this.usernameLabel.Text = "TITLE";
            // 
            // TournamentsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.BackgroundHome;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "TournamentsAdmin";
            this.Size = new System.Drawing.Size(972, 720);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label matchTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox trophyPictureBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2ComboBox formatComboBox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button changeTrophy;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button selectStadiums;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button selectTeams;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button startTournament;
    }
}
