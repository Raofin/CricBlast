
namespace CricBlast_GUI.UI
{
    partial class MainForm
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
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.getStarted = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.infoButton = new Guna.UI2.WinForms.Guna2Button();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1189, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 19;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.Animated = true;
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBox.CustomClick = true;
            this.closeBox.FillColor = System.Drawing.Color.Transparent;
            this.closeBox.HoverState.Parent = this.closeBox;
            this.closeBox.IconColor = System.Drawing.Color.White;
            this.closeBox.Location = new System.Drawing.Point(1235, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.ShadowDecoration.Parent = this.closeBox;
            this.closeBox.Size = new System.Drawing.Size(45, 29);
            this.closeBox.TabIndex = 20;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.FillColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::CricBlast_GUI.Properties.Resources.Logo;
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(354, 103);
            this.logo.Name = "logo";
            this.logo.ShadowDecoration.Parent = this.logo;
            this.logo.Size = new System.Drawing.Size(572, 459);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 18;
            this.logo.TabStop = false;
            // 
            // getStarted
            // 
            this.getStarted.BackColor = System.Drawing.Color.Transparent;
            this.getStarted.BorderRadius = 4;
            this.getStarted.CheckedState.Parent = this.getStarted;
            this.getStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getStarted.CustomImages.Parent = this.getStarted;
            this.getStarted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.getStarted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.getStarted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.getStarted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.getStarted.DisabledState.Parent = this.getStarted;
            this.getStarted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.getStarted.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStarted.ForeColor = System.Drawing.Color.White;
            this.getStarted.HoverState.Parent = this.getStarted;
            this.getStarted.Location = new System.Drawing.Point(550, 590);
            this.getStarted.Name = "getStarted";
            this.getStarted.ShadowDecoration.Parent = this.getStarted;
            this.getStarted.Size = new System.Drawing.Size(180, 45);
            this.getStarted.TabIndex = 1;
            this.getStarted.Text = "Get Started";
            this.getStarted.Click += new System.EventHandler(this.GetStarted_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainPanel.Controls.Add(this.getStarted);
            this.mainPanel.Controls.Add(this.logo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(1280, 720);
            this.mainPanel.TabIndex = 0;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.CheckedState.Parent = this.infoButton;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.CustomImages.Parent = this.infoButton;
            this.infoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.infoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.infoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.infoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.infoButton.DisabledState.Parent = this.infoButton;
            this.infoButton.FillColor = System.Drawing.Color.Transparent;
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.HoverState.Parent = this.infoButton;
            this.infoButton.Location = new System.Drawing.Point(1153, 0);
            this.infoButton.Name = "infoButton";
            this.infoButton.ShadowDecoration.Parent = this.infoButton;
            this.infoButton.Size = new System.Drawing.Size(32, 29);
            this.infoButton.TabIndex = 21;
            this.infoButton.Text = "!";
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.mainPanel;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // DragControl2
            // 
            this.DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl2.TargetControl = this.logo;
            this.DragControl2.TransparentWhileDrag = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CricBlast";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox closeBox;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        public Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Button getStarted;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private Guna.UI2.WinForms.Guna2Button infoButton;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2DragControl DragControl2;
    }
}