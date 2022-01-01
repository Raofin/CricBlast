
namespace CricBlast_GUI.UI.User_Controls
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
            this.components = new System.ComponentModel.Container();
            this.opponentTeamLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.opponentTeamLabel = new System.Windows.Forms.Label();
            this.userTeamLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.userTeamLabel = new System.Windows.Forms.Label();
            this.matchTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.matchPreviewPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.matchHistoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.playButton = new Guna.UI2.WinForms.Guna2Button();
            this.gamePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.gameSelectPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.stadiumSelectError = new System.Windows.Forms.Label();
            this.pitchSelectError = new System.Windows.Forms.Label();
            this.formatSelectError = new System.Windows.Forms.Label();
            this.opponentSelectError = new System.Windows.Forms.Label();
            this.pitchComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.stadiumComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.formatComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.opponentComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.opponentTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTeamLogo)).BeginInit();
            this.matchPreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.gameSelectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // opponentTeamLogo
            // 
            this.opponentTeamLogo.BackColor = System.Drawing.Color.Transparent;
            this.opponentTeamLogo.Image = global::CricBlast_GUI.Properties.Resources.Question_Mark;
            this.opponentTeamLogo.ImageRotate = 0F;
            this.opponentTeamLogo.Location = new System.Drawing.Point(643, 141);
            this.opponentTeamLogo.Name = "opponentTeamLogo";
            this.opponentTeamLogo.ShadowDecoration.Parent = this.opponentTeamLogo;
            this.opponentTeamLogo.Size = new System.Drawing.Size(185, 185);
            this.opponentTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opponentTeamLogo.TabIndex = 19;
            this.opponentTeamLogo.TabStop = false;
            // 
            // opponentTeamLabel
            // 
            this.opponentTeamLabel.BackColor = System.Drawing.Color.Transparent;
            this.opponentTeamLabel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.opponentTeamLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.opponentTeamLabel.Location = new System.Drawing.Point(555, 331);
            this.opponentTeamLabel.Name = "opponentTeamLabel";
            this.opponentTeamLabel.Size = new System.Drawing.Size(340, 46);
            this.opponentTeamLabel.TabIndex = 17;
            this.opponentTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTeamLogo
            // 
            this.userTeamLogo.BackColor = System.Drawing.Color.Transparent;
            this.userTeamLogo.Image = global::CricBlast_GUI.Properties.Resources.Question_Mark;
            this.userTeamLogo.ImageRotate = 0F;
            this.userTeamLogo.Location = new System.Drawing.Point(137, 141);
            this.userTeamLogo.Name = "userTeamLogo";
            this.userTeamLogo.ShadowDecoration.Parent = this.userTeamLogo;
            this.userTeamLogo.Size = new System.Drawing.Size(185, 185);
            this.userTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userTeamLogo.TabIndex = 20;
            this.userTeamLogo.TabStop = false;
            // 
            // userTeamLabel
            // 
            this.userTeamLabel.BackColor = System.Drawing.Color.Transparent;
            this.userTeamLabel.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.userTeamLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.userTeamLabel.Location = new System.Drawing.Point(55, 331);
            this.userTeamLabel.Name = "userTeamLabel";
            this.userTeamLabel.Size = new System.Drawing.Size(340, 46);
            this.userTeamLabel.TabIndex = 18;
            this.userTeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchTitle
            // 
            this.matchTitle.BackColor = System.Drawing.Color.Transparent;
            this.matchTitle.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.matchTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matchTitle.Location = new System.Drawing.Point(88, 67);
            this.matchTitle.Name = "matchTitle";
            this.matchTitle.Size = new System.Drawing.Size(788, 66);
            this.matchTitle.TabIndex = 21;
            this.matchTitle.Text = "PLAY A MATCH";
            this.matchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(328, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(309, 177);
            this.label11.TabIndex = 16;
            this.label11.Text = "VS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchPreviewPanel
            // 
            this.matchPreviewPanel.BackColor = System.Drawing.Color.Transparent;
            this.matchPreviewPanel.Controls.Add(this.guna2PictureBox1);
            this.matchPreviewPanel.Controls.Add(this.matchHistoryButton);
            this.matchPreviewPanel.Controls.Add(this.playButton);
            this.matchPreviewPanel.Controls.Add(this.gamePanel);
            this.matchPreviewPanel.Controls.Add(this.opponentTeamLogo);
            this.matchPreviewPanel.Controls.Add(this.opponentTeamLabel);
            this.matchPreviewPanel.Controls.Add(this.userTeamLogo);
            this.matchPreviewPanel.Controls.Add(this.userTeamLabel);
            this.matchPreviewPanel.Controls.Add(this.matchTitle);
            this.matchPreviewPanel.Controls.Add(this.label11);
            this.matchPreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchPreviewPanel.Location = new System.Drawing.Point(0, 0);
            this.matchPreviewPanel.Name = "matchPreviewPanel";
            this.matchPreviewPanel.ShadowDecoration.Parent = this.matchPreviewPanel;
            this.matchPreviewPanel.Size = new System.Drawing.Size(972, 720);
            this.matchPreviewPanel.TabIndex = 38;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.DimGray;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(85, 397);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(788, 2);
            this.guna2PictureBox1.TabIndex = 47;
            this.guna2PictureBox1.TabStop = false;
            // 
            // matchHistoryButton
            // 
            this.matchHistoryButton.BackColor = System.Drawing.Color.Transparent;
            this.matchHistoryButton.BorderRadius = 4;
            this.matchHistoryButton.CheckedState.Parent = this.matchHistoryButton;
            this.matchHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matchHistoryButton.CustomImages.Parent = this.matchHistoryButton;
            this.matchHistoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.matchHistoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.matchHistoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.matchHistoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.matchHistoryButton.DisabledState.Parent = this.matchHistoryButton;
            this.matchHistoryButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.matchHistoryButton.ForeColor = System.Drawing.Color.White;
            this.matchHistoryButton.HoverState.Parent = this.matchHistoryButton;
            this.matchHistoryButton.Location = new System.Drawing.Point(266, 585);
            this.matchHistoryButton.Name = "matchHistoryButton";
            this.matchHistoryButton.ShadowDecoration.Parent = this.matchHistoryButton;
            this.matchHistoryButton.Size = new System.Drawing.Size(194, 45);
            this.matchHistoryButton.TabIndex = 6;
            this.matchHistoryButton.Text = "View History";
            this.matchHistoryButton.Click += new System.EventHandler(this.matchHistoryButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BorderRadius = 4;
            this.playButton.CheckedState.Parent = this.playButton;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.CustomImages.Parent = this.playButton;
            this.playButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playButton.DisabledState.Parent = this.playButton;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.HoverState.Parent = this.playButton;
            this.playButton.Location = new System.Drawing.Point(495, 585);
            this.playButton.Name = "playButton";
            this.playButton.ShadowDecoration.Parent = this.playButton;
            this.playButton.Size = new System.Drawing.Size(194, 45);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Transparent;
            this.gamePanel.Controls.Add(this.gameSelectPanel);
            this.gamePanel.Location = new System.Drawing.Point(60, 410);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.ShadowDecoration.Parent = this.gamePanel;
            this.gamePanel.Size = new System.Drawing.Size(838, 161);
            this.gamePanel.TabIndex = 43;
            // 
            // gameSelectPanel
            // 
            this.gameSelectPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameSelectPanel.Controls.Add(this.stadiumSelectError);
            this.gameSelectPanel.Controls.Add(this.pitchSelectError);
            this.gameSelectPanel.Controls.Add(this.formatSelectError);
            this.gameSelectPanel.Controls.Add(this.opponentSelectError);
            this.gameSelectPanel.Controls.Add(this.pitchComboBox);
            this.gameSelectPanel.Controls.Add(this.stadiumComboBox);
            this.gameSelectPanel.Controls.Add(this.formatComboBox);
            this.gameSelectPanel.Controls.Add(this.opponentComboBox);
            this.gameSelectPanel.Controls.Add(this.label8);
            this.gameSelectPanel.Controls.Add(this.label7);
            this.gameSelectPanel.Controls.Add(this.label6);
            this.gameSelectPanel.Controls.Add(this.label9);
            this.gameSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSelectPanel.Location = new System.Drawing.Point(0, 0);
            this.gameSelectPanel.Name = "gameSelectPanel";
            this.gameSelectPanel.ShadowDecoration.Parent = this.gameSelectPanel;
            this.gameSelectPanel.Size = new System.Drawing.Size(838, 161);
            this.gameSelectPanel.TabIndex = 40;
            // 
            // stadiumSelectError
            // 
            this.stadiumSelectError.AutoSize = true;
            this.stadiumSelectError.BackColor = System.Drawing.Color.Transparent;
            this.stadiumSelectError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stadiumSelectError.ForeColor = System.Drawing.Color.Red;
            this.stadiumSelectError.Location = new System.Drawing.Point(815, 109);
            this.stadiumSelectError.Name = "stadiumSelectError";
            this.stadiumSelectError.Size = new System.Drawing.Size(22, 32);
            this.stadiumSelectError.TabIndex = 39;
            this.stadiumSelectError.Text = "!";
            this.stadiumSelectError.Visible = false;
            // 
            // pitchSelectError
            // 
            this.pitchSelectError.AutoSize = true;
            this.pitchSelectError.BackColor = System.Drawing.Color.Transparent;
            this.pitchSelectError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchSelectError.ForeColor = System.Drawing.Color.Red;
            this.pitchSelectError.Location = new System.Drawing.Point(391, 109);
            this.pitchSelectError.Name = "pitchSelectError";
            this.pitchSelectError.Size = new System.Drawing.Size(22, 32);
            this.pitchSelectError.TabIndex = 38;
            this.pitchSelectError.Text = "!";
            this.pitchSelectError.Visible = false;
            // 
            // formatSelectError
            // 
            this.formatSelectError.AutoSize = true;
            this.formatSelectError.BackColor = System.Drawing.Color.Transparent;
            this.formatSelectError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatSelectError.ForeColor = System.Drawing.Color.Red;
            this.formatSelectError.Location = new System.Drawing.Point(815, 34);
            this.formatSelectError.Name = "formatSelectError";
            this.formatSelectError.Size = new System.Drawing.Size(22, 32);
            this.formatSelectError.TabIndex = 37;
            this.formatSelectError.Text = "!";
            this.formatSelectError.Visible = false;
            // 
            // opponentSelectError
            // 
            this.opponentSelectError.AutoSize = true;
            this.opponentSelectError.BackColor = System.Drawing.Color.Transparent;
            this.opponentSelectError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentSelectError.ForeColor = System.Drawing.Color.Red;
            this.opponentSelectError.Location = new System.Drawing.Point(391, 34);
            this.opponentSelectError.Name = "opponentSelectError";
            this.opponentSelectError.Size = new System.Drawing.Size(22, 32);
            this.opponentSelectError.TabIndex = 36;
            this.opponentSelectError.Text = "!";
            this.opponentSelectError.Visible = false;
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
            "Select...",
            "Green Pitch",
            "Dusty Pitch",
            "Dead Pitch"});
            this.pitchComboBox.ItemsAppearance.Parent = this.pitchComboBox;
            this.pitchComboBox.Location = new System.Drawing.Point(25, 107);
            this.pitchComboBox.Name = "pitchComboBox";
            this.pitchComboBox.ShadowDecoration.Parent = this.pitchComboBox;
            this.pitchComboBox.Size = new System.Drawing.Size(364, 36);
            this.pitchComboBox.StartIndex = 0;
            this.pitchComboBox.TabIndex = 3;
            this.pitchComboBox.SelectedIndexChanged += new System.EventHandler(this.pitchComboBox_SelectedIndexChanged);
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
            "Select...",
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
            this.stadiumComboBox.Location = new System.Drawing.Point(449, 107);
            this.stadiumComboBox.Name = "stadiumComboBox";
            this.stadiumComboBox.ShadowDecoration.Parent = this.stadiumComboBox;
            this.stadiumComboBox.Size = new System.Drawing.Size(364, 36);
            this.stadiumComboBox.StartIndex = 0;
            this.stadiumComboBox.TabIndex = 4;
            this.stadiumComboBox.SelectedIndexChanged += new System.EventHandler(this.stadiumComboBox_SelectedIndexChanged);
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
            "T20I",
            "ODI",
            "Test"});
            this.formatComboBox.ItemsAppearance.Parent = this.formatComboBox;
            this.formatComboBox.Location = new System.Drawing.Point(449, 32);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.ShadowDecoration.Parent = this.formatComboBox;
            this.formatComboBox.Size = new System.Drawing.Size(364, 36);
            this.formatComboBox.StartIndex = 0;
            this.formatComboBox.TabIndex = 2;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
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
            "Select...",
            "Australia",
            "Bangladesh",
            "India",
            "New Zealand",
            "Pakistan",
            "South Africa",
            "Sri Lanka",
            "West Indies"});
            this.opponentComboBox.ItemsAppearance.Parent = this.opponentComboBox;
            this.opponentComboBox.Location = new System.Drawing.Point(25, 32);
            this.opponentComboBox.Name = "opponentComboBox";
            this.opponentComboBox.ShadowDecoration.Parent = this.opponentComboBox;
            this.opponentComboBox.Size = new System.Drawing.Size(364, 36);
            this.opponentComboBox.StartIndex = 0;
            this.opponentComboBox.TabIndex = 1;
            this.opponentComboBox.SelectedIndexChanged += new System.EventHandler(this.opponentComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(20, 79);
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
            this.label7.Location = new System.Drawing.Point(444, 79);
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
            this.label6.Location = new System.Drawing.Point(444, 4);
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
            this.label9.Location = new System.Drawing.Point(20, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "OPPONENT";
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.matchPreviewPanel;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // PlayMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.BackgroundHome;
            this.Controls.Add(this.matchPreviewPanel);
            this.DoubleBuffered = true;
            this.Name = "PlayMatch";
            this.Size = new System.Drawing.Size(972, 720);
            ((System.ComponentModel.ISupportInitialize)(this.opponentTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTeamLogo)).EndInit();
            this.matchPreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gameSelectPanel.ResumeLayout(false);
            this.gameSelectPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label matchTitle;
        private System.Windows.Forms.Label label11;
        public Guna.UI2.WinForms.Guna2PictureBox opponentTeamLogo;
        public System.Windows.Forms.Label opponentTeamLabel;
        public Guna.UI2.WinForms.Guna2PictureBox userTeamLogo;
        public System.Windows.Forms.Label userTeamLabel;
        public Guna.UI2.WinForms.Guna2Panel matchPreviewPanel;
        private Guna.UI2.WinForms.Guna2Button matchHistoryButton;
        private Guna.UI2.WinForms.Guna2Button playButton;
        private Guna.UI2.WinForms.Guna2Panel gamePanel;
        public Guna.UI2.WinForms.Guna2Panel gameSelectPanel;
        private System.Windows.Forms.Label opponentSelectError;
        private Guna.UI2.WinForms.Guna2ComboBox pitchComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox stadiumComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox formatComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox opponentComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label formatSelectError;
        private System.Windows.Forms.Label stadiumSelectError;
        private System.Windows.Forms.Label pitchSelectError;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}
