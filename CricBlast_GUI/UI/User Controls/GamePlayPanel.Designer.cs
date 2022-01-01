
namespace CricBlast_GUI.UI.User_Controls
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
            this.userTeamScore.Location = new System.Drawing.Point(118, 11);
            this.userTeamScore.Name = "userTeamScore";
            this.userTeamScore.Size = new System.Drawing.Size(255, 54);
            this.userTeamScore.TabIndex = 22;
            this.userTeamScore.Text = "000/00 (00)";
            // 
            // userTeamLogo
            // 
            this.userTeamLogo.Image = global::CricBlast_GUI.Properties.Resources.Question_Mark;
            this.userTeamLogo.ImageRotate = 0F;
            this.userTeamLogo.Location = new System.Drawing.Point(50, 8);
            this.userTeamLogo.Name = "userTeamLogo";
            this.userTeamLogo.ShadowDecoration.Parent = this.userTeamLogo;
            this.userTeamLogo.Size = new System.Drawing.Size(60, 60);
            this.userTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userTeamLogo.TabIndex = 23;
            this.userTeamLogo.TabStop = false;
            // 
            // opponentTeamLogo
            // 
            this.opponentTeamLogo.Image = global::CricBlast_GUI.Properties.Resources.Question_Mark;
            this.opponentTeamLogo.ImageRotate = 0F;
            this.opponentTeamLogo.Location = new System.Drawing.Point(437, 11);
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
            this.opponentTeamScore.Location = new System.Drawing.Point(503, 14);
            this.opponentTeamScore.Name = "opponentTeamScore";
            this.opponentTeamScore.Size = new System.Drawing.Size(255, 54);
            this.opponentTeamScore.TabIndex = 24;
            this.opponentTeamScore.Text = "000/00 (00)";
            // 
            // matchResult
            // 
            this.matchResult.BackColor = System.Drawing.Color.Transparent;
            this.matchResult.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold);
            this.matchResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matchResult.Location = new System.Drawing.Point(3, 87);
            this.matchResult.Name = "matchResult";
            this.matchResult.Size = new System.Drawing.Size(832, 54);
            this.matchResult.TabIndex = 26;
            this.matchResult.Text = "Match result.";
            this.matchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GamePlayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.matchResult);
            this.Controls.Add(this.opponentTeamLogo);
            this.Controls.Add(this.opponentTeamScore);
            this.Controls.Add(this.userTeamLogo);
            this.Controls.Add(this.userTeamScore);
            this.DoubleBuffered = true;
            this.Name = "GamePlayPanel";
            this.Size = new System.Drawing.Size(838, 161);
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
    }
}
