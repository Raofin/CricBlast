
namespace CricBlast_GUI.Forms.Controls
{
    partial class PlayMatch
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
            this.opponentLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.userTeamLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pitchComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.stadiumComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.formatComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.opponentComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opponentLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // opponentLogo
            // 
            this.opponentLogo.BackColor = System.Drawing.Color.Transparent;
            this.opponentLogo.Image = global::CricBlast_GUI.Properties.Resources.India;
            this.opponentLogo.ImageRotate = 0F;
            this.opponentLogo.Location = new System.Drawing.Point(638, 119);
            this.opponentLogo.Name = "opponentLogo";
            this.opponentLogo.ShadowDecoration.Parent = this.opponentLogo;
            this.opponentLogo.Size = new System.Drawing.Size(185, 185);
            this.opponentLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opponentLogo.TabIndex = 19;
            this.opponentLogo.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(593, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 46);
            this.label12.TabIndex = 17;
            this.label12.Text = "INDIA";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTeamLogo
            // 
            this.userTeamLogo.BackColor = System.Drawing.Color.Transparent;
            this.userTeamLogo.Image = global::CricBlast_GUI.Properties.Resources.Bangladesh1;
            this.userTeamLogo.ImageRotate = 0F;
            this.userTeamLogo.Location = new System.Drawing.Point(138, 123);
            this.userTeamLogo.Name = "userTeamLogo";
            this.userTeamLogo.ShadowDecoration.Parent = this.userTeamLogo;
            this.userTeamLogo.Size = new System.Drawing.Size(185, 185);
            this.userTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userTeamLogo.TabIndex = 20;
            this.userTeamLogo.TabStop = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(93, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(275, 46);
            this.label10.TabIndex = 18;
            this.label10.Text = "BANGLADESH";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pitchComboBox
            // 
            this.pitchComboBox.BackColor = System.Drawing.Color.Transparent;
            this.pitchComboBox.BorderRadius = 4;
            this.pitchComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pitchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pitchComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pitchComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pitchComboBox.FocusedState.Parent = this.pitchComboBox;
            this.pitchComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.pitchComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.pitchComboBox.HoverState.Parent = this.pitchComboBox;
            this.pitchComboBox.ItemHeight = 30;
            this.pitchComboBox.Items.AddRange(new object[] {
            "Green Pitch",
            "Dusty Pitch",
            "Dead Pitch"});
            this.pitchComboBox.ItemsAppearance.Parent = this.pitchComboBox;
            this.pitchComboBox.Location = new System.Drawing.Point(87, 505);
            this.pitchComboBox.Name = "pitchComboBox";
            this.pitchComboBox.ShadowDecoration.Parent = this.pitchComboBox;
            this.pitchComboBox.Size = new System.Drawing.Size(364, 36);
            this.pitchComboBox.StartIndex = 0;
            this.pitchComboBox.TabIndex = 26;
            // 
            // stadiumComboBox
            // 
            this.stadiumComboBox.BackColor = System.Drawing.Color.Transparent;
            this.stadiumComboBox.BorderRadius = 4;
            this.stadiumComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.stadiumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stadiumComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stadiumComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stadiumComboBox.FocusedState.Parent = this.stadiumComboBox;
            this.stadiumComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.stadiumComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.stadiumComboBox.HoverState.Parent = this.stadiumComboBox;
            this.stadiumComboBox.ItemHeight = 30;
            this.stadiumComboBox.Items.AddRange(new object[] {
            "Sher-E-Bangla Cricket Stadium",
            "Narendra Modi Stadium",
            "Melbourne Cricket Ground",
            "Eden Gardens",
            "Shaheed Veer Narayan Singh International Cricket Stadium",
            "Perth Stadium",
            "Rajiv Gandhi International Cricket Stadium",
            "Greenfield International Stadium",
            "Adelaide Oval",
            "M. A. Chidambaram Stadium",
            "JSCA International Cricket Stadium",
            "Bharat Ratna Shri Atal Bihari Vajpayee Ekana Cricket Stadium",
            "Docklands Stadium",
            "Sydney Cricket Ground",
            "Vidarbha Cricket Association Stadium",
            "Barabati Stadium",
            "Saifai International Cricket Stadium",
            "Eden Park"});
            this.stadiumComboBox.ItemsAppearance.Parent = this.stadiumComboBox;
            this.stadiumComboBox.Location = new System.Drawing.Point(511, 505);
            this.stadiumComboBox.Name = "stadiumComboBox";
            this.stadiumComboBox.ShadowDecoration.Parent = this.stadiumComboBox;
            this.stadiumComboBox.Size = new System.Drawing.Size(364, 36);
            this.stadiumComboBox.StartIndex = 0;
            this.stadiumComboBox.TabIndex = 27;
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
            "Test",
            "ODI",
            "T20I"});
            this.formatComboBox.ItemsAppearance.Parent = this.formatComboBox;
            this.formatComboBox.Location = new System.Drawing.Point(511, 430);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.ShadowDecoration.Parent = this.formatComboBox;
            this.formatComboBox.Size = new System.Drawing.Size(364, 36);
            this.formatComboBox.StartIndex = 1;
            this.formatComboBox.TabIndex = 28;
            // 
            // opponentComboBox
            // 
            this.opponentComboBox.BackColor = System.Drawing.Color.Transparent;
            this.opponentComboBox.BorderRadius = 4;
            this.opponentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.opponentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opponentComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opponentComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opponentComboBox.FocusedState.Parent = this.opponentComboBox;
            this.opponentComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.opponentComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.opponentComboBox.HoverState.Parent = this.opponentComboBox;
            this.opponentComboBox.ItemHeight = 30;
            this.opponentComboBox.Items.AddRange(new object[] {
            "India",
            "Pakistan",
            "Australia",
            "New Zealand",
            "England",
            "South Africa",
            "West Indies",
            "Sri Lanka",
            "Afghanistan"});
            this.opponentComboBox.ItemsAppearance.Parent = this.opponentComboBox;
            this.opponentComboBox.Location = new System.Drawing.Point(87, 430);
            this.opponentComboBox.Name = "opponentComboBox";
            this.opponentComboBox.ShadowDecoration.Parent = this.opponentComboBox;
            this.opponentComboBox.Size = new System.Drawing.Size(364, 36);
            this.opponentComboBox.StartIndex = 0;
            this.opponentComboBox.TabIndex = 29;
            this.opponentComboBox.SelectedIndexChanged += new System.EventHandler(this.opponentComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(82, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "PITCH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(506, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "STADIUM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(506, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "FORMAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(82, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "OPPONENT";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(342, 57);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(273, 54);
            this.label23.TabIndex = 21;
            this.label23.Text = "Play a Match";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(388, 577);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Toss";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(359, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 177);
            this.label11.TabIndex = 16;
            this.label11.Text = "VS";
            // 
            // PlayMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.SubHome;
            this.Controls.Add(this.opponentLogo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userTeamLogo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pitchComboBox);
            this.Controls.Add(this.stadiumComboBox);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.opponentComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label11);
            this.Name = "PlayMatch";
            this.Size = new System.Drawing.Size(956, 681);
            ((System.ComponentModel.ISupportInitialize)(this.opponentLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTeamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox opponentLogo;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2PictureBox userTeamLogo;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox pitchComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox stadiumComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox formatComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox opponentComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label23;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label11;
    }
}
