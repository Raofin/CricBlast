
namespace CricBlast_GUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTeam));
            this.userCirclePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.teamComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.teamSelectError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userCirclePicture
            // 
            this.userCirclePicture.BackColor = System.Drawing.Color.Transparent;
            this.userCirclePicture.Image = ((System.Drawing.Image)(resources.GetObject("userCirclePicture.Image")));
            this.userCirclePicture.ImageRotate = 0F;
            this.userCirclePicture.Location = new System.Drawing.Point(108, 58);
            this.userCirclePicture.Name = "userCirclePicture";
            this.userCirclePicture.ShadowDecoration.Depth = 15;
            this.userCirclePicture.ShadowDecoration.Enabled = true;
            this.userCirclePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userCirclePicture.ShadowDecoration.Parent = this.userCirclePicture;
            this.userCirclePicture.Size = new System.Drawing.Size(256, 256);
            this.userCirclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userCirclePicture.TabIndex = 0;
            this.userCirclePicture.TabStop = false;
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
            "Afghanistan",
            "Australia",
            "Bangladesh",
            "England",
            "India",
            "New Zealand",
            "Pakistan",
            "South Africa",
            "Sri Lanka",
            "West Indies"});
            this.teamComboBox.ItemsAppearance.Parent = this.teamComboBox;
            this.teamComboBox.Location = new System.Drawing.Point(97, 374);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.ShadowDecoration.Parent = this.teamComboBox;
            this.teamComboBox.Size = new System.Drawing.Size(279, 36);
            this.teamComboBox.StartIndex = 0;
            this.teamComboBox.TabIndex = 23;
            this.teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(95, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "CHOOSE YOUR TEAM";
            // 
            // okButton
            // 
            this.okButton.Animated = true;
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BorderRadius = 4;
            this.okButton.CheckedState.Parent = this.okButton;
            this.okButton.CustomImages.Parent = this.okButton;
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.DisabledState.Parent = this.okButton;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.HoverState.Parent = this.okButton;
            this.okButton.Location = new System.Drawing.Point(146, 437);
            this.okButton.Name = "okButton";
            this.okButton.ShadowDecoration.Parent = this.okButton;
            this.okButton.Size = new System.Drawing.Size(180, 45);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // teamSelectError
            // 
            this.teamSelectError.AutoSize = true;
            this.teamSelectError.BackColor = System.Drawing.Color.Transparent;
            this.teamSelectError.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamSelectError.ForeColor = System.Drawing.Color.Red;
            this.teamSelectError.Location = new System.Drawing.Point(382, 376);
            this.teamSelectError.Name = "teamSelectError";
            this.teamSelectError.Size = new System.Drawing.Size(22, 32);
            this.teamSelectError.TabIndex = 35;
            this.teamSelectError.Text = "!";
            this.teamSelectError.Visible = false;
            // 
            // ChooseTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(89)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(473, 534);
            this.Controls.Add(this.teamSelectError);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.teamComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCirclePicture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChooseTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox userCirclePicture;
        private Guna.UI2.WinForms.Guna2ComboBox teamComboBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button okButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label teamSelectError;
    }
}