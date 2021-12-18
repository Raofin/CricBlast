
namespace CricBlast_GUI.Forms.Admin_Controls
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
            this.AllUserGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.User = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AllUserGrid
            // 
            this.AllUserGrid.AllowUserToAddRows = false;
            this.AllUserGrid.AllowUserToDeleteRows = false;
            this.AllUserGrid.AllowUserToOrderColumns = true;
            this.AllUserGrid.AllowUserToResizeColumns = false;
            this.AllUserGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AllUserGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllUserGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllUserGrid.BackgroundColor = System.Drawing.Color.White;
            this.AllUserGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AllUserGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AllUserGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AllUserGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllUserGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllUserGrid.ColumnHeadersHeight = 40;
            this.AllUserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AllUserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.UserName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllUserGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.AllUserGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllUserGrid.EnableHeadersVisualStyles = false;
            this.AllUserGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllUserGrid.Location = new System.Drawing.Point(0, 0);
            this.AllUserGrid.MultiSelect = false;
            this.AllUserGrid.Name = "AllUserGrid";
            this.AllUserGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllUserGrid.RowHeadersVisible = false;
            this.AllUserGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AllUserGrid.RowTemplate.Height = 30;
            this.AllUserGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AllUserGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AllUserGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllUserGrid.Size = new System.Drawing.Size(310, 401);
            this.AllUserGrid.TabIndex = 33;
            this.AllUserGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AllUserGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AllUserGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AllUserGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AllUserGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AllUserGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AllUserGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllUserGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AllUserGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllUserGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.AllUserGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AllUserGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AllUserGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.AllUserGrid.ThemeStyle.ReadOnly = false;
            this.AllUserGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AllUserGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AllUserGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AllUserGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllUserGrid.ThemeStyle.RowsStyle.Height = 30;
            this.AllUserGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllUserGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.UserName.Width = 270;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.AllUserGrid);
            this.Name = "UserList";
            this.Size = new System.Drawing.Size(310, 401);
            ((System.ComponentModel.ISupportInitialize)(this.AllUserGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView AllUserGrid;
        private System.Windows.Forms.DataGridViewImageColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}
