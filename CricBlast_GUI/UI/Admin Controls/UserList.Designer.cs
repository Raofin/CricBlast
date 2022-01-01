
namespace CricBlast_GUI.UI.Admin_Controls
{
    partial class UserList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserPreviewGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.User = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UserPreviewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPreviewGrid
            // 
            this.UserPreviewGrid.AllowUserToAddRows = false;
            this.UserPreviewGrid.AllowUserToDeleteRows = false;
            this.UserPreviewGrid.AllowUserToOrderColumns = true;
            this.UserPreviewGrid.AllowUserToResizeColumns = false;
            this.UserPreviewGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.UserPreviewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserPreviewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserPreviewGrid.BackgroundColor = System.Drawing.Color.White;
            this.UserPreviewGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPreviewGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserPreviewGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.UserPreviewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserPreviewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserPreviewGrid.ColumnHeadersHeight = 40;
            this.UserPreviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UserPreviewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.UserName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserPreviewGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserPreviewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPreviewGrid.EnableHeadersVisualStyles = false;
            this.UserPreviewGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserPreviewGrid.Location = new System.Drawing.Point(0, 0);
            this.UserPreviewGrid.MultiSelect = false;
            this.UserPreviewGrid.Name = "UserPreviewGrid";
            this.UserPreviewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserPreviewGrid.RowHeadersVisible = false;
            this.UserPreviewGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserPreviewGrid.RowTemplate.Height = 30;
            this.UserPreviewGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserPreviewGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserPreviewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserPreviewGrid.Size = new System.Drawing.Size(328, 401);
            this.UserPreviewGrid.TabIndex = 33;
            this.UserPreviewGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UserPreviewGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UserPreviewGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UserPreviewGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UserPreviewGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UserPreviewGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UserPreviewGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserPreviewGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.UserPreviewGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserPreviewGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.UserPreviewGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UserPreviewGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UserPreviewGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.UserPreviewGrid.ThemeStyle.ReadOnly = false;
            this.UserPreviewGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserPreviewGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserPreviewGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UserPreviewGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.UserPreviewGrid.ThemeStyle.RowsStyle.Height = 30;
            this.UserPreviewGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.UserPreviewGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.User.HeaderText = "";
            this.User.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.User.Name = "User";
            this.User.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.User.Width = 47;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.HeaderText = "EMAIL ADDRESS";
            this.UserName.Name = "UserName";
            this.UserName.Width = 290;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.UserPreviewGrid);
            this.DoubleBuffered = true;
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(328, 401);
            ((System.ComponentModel.ISupportInitialize)(this.UserPreviewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView UserPreviewGrid;
        private System.Windows.Forms.DataGridViewImageColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}
