
namespace CricBlast_GUI.UI
{
    partial class MatchHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.won = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.played = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.close = new Guna.UI2.WinForms.Guna2Button();
            this.MatchHistoryGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.UserTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchHistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.won);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.played);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.userPhoto);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.close);
            this.guna2Panel1.Controls.Add(this.MatchHistoryGrid);
            this.guna2Panel1.Controls.Add(this.welcomeLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(677, 615);
            this.guna2Panel1.TabIndex = 0;
            // 
            // won
            // 
            this.won.AutoSize = true;
            this.won.BackColor = System.Drawing.Color.Transparent;
            this.won.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.won.ForeColor = System.Drawing.Color.White;
            this.won.Location = new System.Drawing.Point(378, 45);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(24, 28);
            this.won.TabIndex = 55;
            this.won.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(327, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 54;
            this.label6.Text = "Won";
            // 
            // played
            // 
            this.played.AutoSize = true;
            this.played.BackColor = System.Drawing.Color.Transparent;
            this.played.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.played.ForeColor = System.Drawing.Color.White;
            this.played.Location = new System.Drawing.Point(398, 73);
            this.played.Name = "played";
            this.played.Size = new System.Drawing.Size(24, 28);
            this.played.TabIndex = 52;
            this.played.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(327, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 53;
            this.label5.Text = "Played";
            // 
            // userPhoto
            // 
            this.userPhoto.BackColor = System.Drawing.Color.Transparent;
            this.userPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPhoto.Image = global::CricBlast_GUI.Properties.Resources.User_Male_WhiteBack;
            this.userPhoto.ImageRotate = 0F;
            this.userPhoto.Location = new System.Drawing.Point(248, 43);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.ShadowDecoration.Enabled = true;
            this.userPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPhoto.ShadowDecoration.Parent = this.userPhoto;
            this.userPhoto.Size = new System.Drawing.Size(64, 64);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 51;
            this.userPhoto.TabStop = false;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(632, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 50;
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
            this.close.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.HoverState.Parent = this.close;
            this.close.Location = new System.Drawing.Point(248, 530);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(180, 45);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // MatchHistoryGrid
            // 
            this.MatchHistoryGrid.AllowUserToAddRows = false;
            this.MatchHistoryGrid.AllowUserToDeleteRows = false;
            this.MatchHistoryGrid.AllowUserToOrderColumns = true;
            this.MatchHistoryGrid.AllowUserToResizeColumns = false;
            this.MatchHistoryGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MatchHistoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MatchHistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatchHistoryGrid.BackgroundColor = System.Drawing.Color.White;
            this.MatchHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatchHistoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MatchHistoryGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.MatchHistoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MatchHistoryGrid.ColumnHeadersHeight = 40;
            this.MatchHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserTeam,
            this.MatchResult});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatchHistoryGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.MatchHistoryGrid.EnableHeadersVisualStyles = false;
            this.MatchHistoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MatchHistoryGrid.Location = new System.Drawing.Point(75, 185);
            this.MatchHistoryGrid.MultiSelect = false;
            this.MatchHistoryGrid.Name = "MatchHistoryGrid";
            this.MatchHistoryGrid.ReadOnly = true;
            this.MatchHistoryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MatchHistoryGrid.RowHeadersVisible = false;
            this.MatchHistoryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MatchHistoryGrid.RowTemplate.Height = 30;
            this.MatchHistoryGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MatchHistoryGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MatchHistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MatchHistoryGrid.Size = new System.Drawing.Size(526, 326);
            this.MatchHistoryGrid.TabIndex = 47;
            this.MatchHistoryGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MatchHistoryGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MatchHistoryGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MatchHistoryGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MatchHistoryGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MatchHistoryGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MatchHistoryGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MatchHistoryGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MatchHistoryGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MatchHistoryGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.MatchHistoryGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MatchHistoryGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MatchHistoryGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.MatchHistoryGrid.ThemeStyle.ReadOnly = true;
            this.MatchHistoryGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MatchHistoryGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MatchHistoryGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MatchHistoryGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MatchHistoryGrid.ThemeStyle.RowsStyle.Height = 30;
            this.MatchHistoryGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MatchHistoryGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UserTeam
            // 
            this.UserTeam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.UserTeam.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserTeam.HeaderText = "  USER TEAM";
            this.UserTeam.Name = "UserTeam";
            this.UserTeam.ReadOnly = true;
            this.UserTeam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserTeam.Width = 150;
            // 
            // MatchResult
            // 
            this.MatchResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MatchResult.HeaderText = "MATCH RESULT";
            this.MatchResult.Name = "MatchResult";
            this.MatchResult.ReadOnly = true;
            this.MatchResult.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MatchResult.Width = 400;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(191, 127);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(294, 46);
            this.welcomeLabel.TabIndex = 48;
            this.welcomeLabel.Text = "MATCH HISTORY";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // MatchHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.BackgroundHome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 615);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatchHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatchHistoryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button close;
        private Guna.UI2.WinForms.Guna2DataGridView MatchHistoryGrid;
        public System.Windows.Forms.Label welcomeLabel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchResult;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPhoto;
        private System.Windows.Forms.Label played;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label won;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}