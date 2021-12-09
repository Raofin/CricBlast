
namespace CricBlast_GUI.Forms.Controls
{
    partial class ChooseTeamDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTeamDelete));
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userCirclePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePicture)).BeginInit();
            this.SuspendLayout();
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
            this.okButton.Location = new System.Drawing.Point(388, 507);
            this.okButton.Name = "okButton";
            this.okButton.ShadowDecoration.Parent = this.okButton;
            this.okButton.Size = new System.Drawing.Size(180, 45);
            this.okButton.TabIndex = 28;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderRadius = 4;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Items.AddRange(new object[] {
            "Bangladesh",
            "India",
            "Pakistan",
            "Australia",
            "New Zealand",
            "England",
            "South Africa",
            "West Indies",
            "Sri Lanka",
            "Afghanistan"});
            this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Location = new System.Drawing.Point(339, 444);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
            this.guna2ComboBox2.Size = new System.Drawing.Size(279, 36);
            this.guna2ComboBox2.StartIndex = 0;
            this.guna2ComboBox2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(336, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "CHOOSE YOUR TEAM";
            // 
            // userCirclePicture
            // 
            this.userCirclePicture.BackColor = System.Drawing.Color.Transparent;
            this.userCirclePicture.Image = ((System.Drawing.Image)(resources.GetObject("userCirclePicture.Image")));
            this.userCirclePicture.ImageRotate = 0F;
            this.userCirclePicture.Location = new System.Drawing.Point(350, 128);
            this.userCirclePicture.Name = "userCirclePicture";
            this.userCirclePicture.ShadowDecoration.Depth = 15;
            this.userCirclePicture.ShadowDecoration.Enabled = true;
            this.userCirclePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userCirclePicture.ShadowDecoration.Parent = this.userCirclePicture;
            this.userCirclePicture.Size = new System.Drawing.Size(256, 256);
            this.userCirclePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userCirclePicture.TabIndex = 25;
            this.userCirclePicture.TabStop = false;
            // 
            // ChooseTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userCirclePicture);
            this.Name = "ChooseTeam";
            this.Size = new System.Drawing.Size(956, 681);
            ((System.ComponentModel.ISupportInitialize)(this.userCirclePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button okButton;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userCirclePicture;
    }
}
