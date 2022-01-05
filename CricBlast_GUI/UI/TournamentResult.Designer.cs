
namespace CricBlast_GUI.UI
{
    partial class TournamentResult
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
            this.close = new Guna.UI2.WinForms.Guna2Button();
            this.championTeamLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tournamentTitle = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.trophyPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.championTeamName = new System.Windows.Forms.Label();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.championTeamLogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BorderRadius = 4;
            this.close.CheckedState.Parent = this.close;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.CustomImages.Parent = this.close;
            this.close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close.DisabledState.Parent = this.close;
            this.close.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.HoverState.Parent = this.close;
            this.close.Location = new System.Drawing.Point(161, 562);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(200, 43);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // championTeamLogo
            // 
            this.championTeamLogo.BackColor = System.Drawing.Color.Transparent;
            this.championTeamLogo.Image = global::CricBlast_GUI.Properties.Resources.Question_Mark;
            this.championTeamLogo.ImageRotate = 0F;
            this.championTeamLogo.Location = new System.Drawing.Point(121, 117);
            this.championTeamLogo.Name = "championTeamLogo";
            this.championTeamLogo.ShadowDecoration.Parent = this.championTeamLogo;
            this.championTeamLogo.Size = new System.Drawing.Size(281, 304);
            this.championTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.championTeamLogo.TabIndex = 33;
            this.championTeamLogo.TabStop = false;
            this.championTeamLogo.UseTransparentBackground = true;
            // 
            // tournamentTitle
            // 
            this.tournamentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tournamentTitle.BackColor = System.Drawing.Color.Transparent;
            this.tournamentTitle.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.tournamentTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tournamentTitle.Location = new System.Drawing.Point(31, 40);
            this.tournamentTitle.Name = "tournamentTitle";
            this.tournamentTitle.Size = new System.Drawing.Size(475, 54);
            this.tournamentTitle.TabIndex = 32;
            this.tournamentTitle.Text = "TOURNAMENT TITLE";
            this.tournamentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.trophyPicture);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.championTeamName);
            this.guna2Panel1.Controls.Add(this.close);
            this.guna2Panel1.Controls.Add(this.tournamentTitle);
            this.guna2Panel1.Controls.Add(this.championTeamLogo);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(523, 656);
            this.guna2Panel1.TabIndex = 35;
            // 
            // trophyPicture
            // 
            this.trophyPicture.BackColor = System.Drawing.Color.Transparent;
            this.trophyPicture.Image = global::CricBlast_GUI.Properties.Resources.Question_Mark;
            this.trophyPicture.ImageRotate = 0F;
            this.trophyPicture.Location = new System.Drawing.Point(119, 443);
            this.trophyPicture.Name = "trophyPicture";
            this.trophyPicture.ShadowDecoration.Parent = this.trophyPicture;
            this.trophyPicture.Size = new System.Drawing.Size(75, 93);
            this.trophyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trophyPicture.TabIndex = 36;
            this.trophyPicture.TabStop = false;
            this.trophyPicture.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(478, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(192, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "CHAMPION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // championTeamName
            // 
            this.championTeamName.AutoSize = true;
            this.championTeamName.BackColor = System.Drawing.Color.Transparent;
            this.championTeamName.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.championTeamName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.championTeamName.Location = new System.Drawing.Point(189, 475);
            this.championTeamName.Name = "championTeamName";
            this.championTeamName.Size = new System.Drawing.Size(226, 46);
            this.championTeamName.TabIndex = 37;
            this.championTeamName.Text = "TEAM NAME";
            this.championTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.guna2Panel1;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // TournamentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(89)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 656);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TournamentResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            ((System.ComponentModel.ISupportInitialize)(this.championTeamLogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trophyPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button close;
        private Guna.UI2.WinForms.Guna2PictureBox championTeamLogo;
        private System.Windows.Forms.Label tournamentTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label championTeamName;
        private Guna.UI2.WinForms.Guna2PictureBox trophyPicture;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}