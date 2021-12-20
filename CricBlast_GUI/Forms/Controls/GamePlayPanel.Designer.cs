
namespace CricBlast_GUI.Forms.Controls
{
    partial class GamePlayPanel
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
            this.userTeamScore = new System.Windows.Forms.Label();
            this.userTeamLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.opponentTeamLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.opponentTeamScore = new System.Windows.Forms.Label();
            this.matchResult = new System.Windows.Forms.Label();
            this.playAgainButton = new Guna.UI2.WinForms.Guna2Button();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.userTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentTeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // userTeamScore
            // 
            this.userTeamScore.AutoSize = true;
            this.userTeamScore.BackColor = System.Drawing.Color.Transparent;
            this.userTeamScore.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.userTeamScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userTeamScore.Location = new System.Drawing.Point(118, 34);
            this.userTeamScore.Name = "userTeamScore";
            this.userTeamScore.Size = new System.Drawing.Size(250, 54);
            this.userTeamScore.TabIndex = 22;
            this.userTeamScore.Text = "300/10 (50)";
            // 
            // userTeamLogo
            // 
            this.userTeamLogo.Image = global::CricBlast_GUI.Properties.Resources.India;
            this.userTeamLogo.ImageRotate = 0F;
            this.userTeamLogo.Location = new System.Drawing.Point(50, 31);
            this.userTeamLogo.Name = "userTeamLogo";
            this.userTeamLogo.ShadowDecoration.Parent = this.userTeamLogo;
            this.userTeamLogo.Size = new System.Drawing.Size(60, 60);
            this.userTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userTeamLogo.TabIndex = 23;
            this.userTeamLogo.TabStop = false;
            // 
            // opponentTeamLogo
            // 
            this.opponentTeamLogo.Image = global::CricBlast_GUI.Properties.Resources.India;
            this.opponentTeamLogo.ImageRotate = 0F;
            this.opponentTeamLogo.Location = new System.Drawing.Point(437, 34);
            this.opponentTeamLogo.Name = "opponentTeamLogo";
            this.opponentTeamLogo.ShadowDecoration.Parent = this.opponentTeamLogo;
            this.opponentTeamLogo.Size = new System.Drawing.Size(60, 60);
            this.opponentTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opponentTeamLogo.TabIndex = 25;
            this.opponentTeamLogo.TabStop = false;
            // 
            // opponentTeamScore
            // 
            this.opponentTeamScore.AutoSize = true;
            this.opponentTeamScore.BackColor = System.Drawing.Color.Transparent;
            this.opponentTeamScore.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.opponentTeamScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opponentTeamScore.Location = new System.Drawing.Point(503, 37);
            this.opponentTeamScore.Name = "opponentTeamScore";
            this.opponentTeamScore.Size = new System.Drawing.Size(250, 54);
            this.opponentTeamScore.TabIndex = 24;
            this.opponentTeamScore.Text = "300/10 (50)";
            // 
            // matchResult
            // 
            this.matchResult.BackColor = System.Drawing.Color.Transparent;
            this.matchResult.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.matchResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matchResult.Location = new System.Drawing.Point(3, 110);
            this.matchResult.Name = "matchResult";
            this.matchResult.Size = new System.Drawing.Size(832, 54);
            this.matchResult.TabIndex = 26;
            this.matchResult.Text = "Bangladesh has lost by 3 wickets.";
            this.matchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Animated = true;
            this.playAgainButton.BackColor = System.Drawing.Color.Transparent;
            this.playAgainButton.BorderRadius = 4;
            this.playAgainButton.CheckedState.Parent = this.playAgainButton;
            this.playAgainButton.CustomImages.Parent = this.playAgainButton;
            this.playAgainButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playAgainButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playAgainButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playAgainButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playAgainButton.DisabledState.Parent = this.playAgainButton;
            this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.playAgainButton.ForeColor = System.Drawing.Color.White;
            this.playAgainButton.HoverState.Parent = this.playAgainButton;
            this.playAgainButton.Location = new System.Drawing.Point(437, 190);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.ShadowDecoration.Parent = this.playAgainButton;
            this.playAgainButton.Size = new System.Drawing.Size(180, 45);
            this.playAgainButton.TabIndex = 27;
            this.playAgainButton.Text = "Play Again";
            // 
            // backButton
            // 
            this.backButton.Animated = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BorderRadius = 4;
            this.backButton.CheckedState.Parent = this.backButton;
            this.backButton.CustomImages.Parent = this.backButton;
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.DisabledState.Parent = this.backButton;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.Parent = this.backButton;
            this.backButton.Location = new System.Drawing.Point(188, 190);
            this.backButton.Name = "backButton";
            this.backButton.ShadowDecoration.Parent = this.backButton;
            this.backButton.Size = new System.Drawing.Size(180, 45);
            this.backButton.TabIndex = 28;
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.matchResult);
            this.Controls.Add(this.opponentTeamLogo);
            this.Controls.Add(this.opponentTeamScore);
            this.Controls.Add(this.userTeamLogo);
            this.Controls.Add(this.userTeamScore);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(838, 259);
            ((System.ComponentModel.ISupportInitialize)(this.userTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentTeamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userTeamScore;
        private Guna.UI2.WinForms.Guna2PictureBox userTeamLogo;
        private Guna.UI2.WinForms.Guna2PictureBox opponentTeamLogo;
        private System.Windows.Forms.Label opponentTeamScore;
        private System.Windows.Forms.Label matchResult;
        private Guna.UI2.WinForms.Guna2Button playAgainButton;
        private Guna.UI2.WinForms.Guna2Button backButton;
    }
}
