
namespace CricBlast_GUI.UI
{
    partial class ChooseTeam
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
            this.teamComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.teamSelectError = new System.Windows.Forms.Label();
            this.cricBlastLabel = new System.Windows.Forms.Label();
            this.cricBlastPicture = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // teamComboBox
            // 
            this.teamComboBox.BackColor = System.Drawing.Color.Transparent;
            this.teamComboBox.BorderRadius = 4;
            this.teamComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.teamComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.teamComboBox.FocusedState.Parent = this.teamComboBox;
            this.teamComboBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.teamComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.teamComboBox.HoverState.Parent = this.teamComboBox;
            this.teamComboBox.ItemHeight = 30;
            this.teamComboBox.Items.AddRange(new object[] {
            "Select...",
            "Australia",
            "Bangladesh",
            "India",
            "New Zealand",
            "Pakistan",
            "South Africa",
            "Sri Lanka",
            "West Indies"});
            this.teamComboBox.ItemsAppearance.Parent = this.teamComboBox;
            this.teamComboBox.Location = new System.Drawing.Point(90, 90);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.ShadowDecoration.Parent = this.teamComboBox;
            this.teamComboBox.Size = new System.Drawing.Size(293, 36);
            this.teamComboBox.StartIndex = 0;
            this.teamComboBox.TabIndex = 1;
            this.teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "CHOOSE YOUR TEAM";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BorderRadius = 4;
            this.okButton.CheckedState.Parent = this.okButton;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.CustomImages.Parent = this.okButton;
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.DisabledState.Parent = this.okButton;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.HoverState.Parent = this.okButton;
            this.okButton.Location = new System.Drawing.Point(137, 153);
            this.okButton.Name = "okButton";
            this.okButton.ShadowDecoration.Parent = this.okButton;
            this.okButton.Size = new System.Drawing.Size(180, 45);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // teamSelectError
            // 
            this.teamSelectError.AutoSize = true;
            this.teamSelectError.BackColor = System.Drawing.Color.Transparent;
            this.teamSelectError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSelectError.ForeColor = System.Drawing.Color.Red;
            this.teamSelectError.Location = new System.Drawing.Point(387, 92);
            this.teamSelectError.Name = "teamSelectError";
            this.teamSelectError.Size = new System.Drawing.Size(22, 32);
            this.teamSelectError.TabIndex = 35;
            this.teamSelectError.Text = "!";
            this.teamSelectError.Visible = false;
            // 
            // cricBlastLabel
            // 
            this.cricBlastLabel.AutoSize = true;
            this.cricBlastLabel.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cricBlastLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cricBlastLabel.Location = new System.Drawing.Point(34, 10);
            this.cricBlastLabel.Name = "cricBlastLabel";
            this.cricBlastLabel.Size = new System.Drawing.Size(76, 21);
            this.cricBlastLabel.TabIndex = 38;
            this.cricBlastLabel.Text = "CricBlast";
            // 
            // cricBlastPicture
            // 
            this.cricBlastPicture.BackColor = System.Drawing.Color.Transparent;
            this.cricBlastPicture.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.cricBlastPicture.Location = new System.Drawing.Point(8, 8);
            this.cricBlastPicture.Name = "cricBlastPicture";
            this.cricBlastPicture.Size = new System.Drawing.Size(25, 25);
            this.cricBlastPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cricBlastPicture.TabIndex = 37;
            this.cricBlastPicture.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.guna2ControlBox1.CustomClick = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(429, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 36;
            // 
            // ChooseTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(89)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 231);
            this.Controls.Add(this.cricBlastLabel);
            this.Controls.Add(this.cricBlastPicture);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.teamSelectError);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.teamComboBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            this.Load += new System.EventHandler(this.ChooseTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cricBlastPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox teamComboBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Label teamSelectError;
        private System.Windows.Forms.Label cricBlastLabel;
        private System.Windows.Forms.PictureBox cricBlastPicture;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}