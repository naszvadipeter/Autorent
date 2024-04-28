namespace AutoRent
{
    partial class AutorentAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_showAllUsers = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.dataGridView_AllUsers = new System.Windows.Forms.DataGridView();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // button_showAllUsers
            // 
            this.button_showAllUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.button_showAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_showAllUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.button_showAllUsers.Location = new System.Drawing.Point(288, 11);
            this.button_showAllUsers.Margin = new System.Windows.Forms.Padding(2);
            this.button_showAllUsers.Name = "button_showAllUsers";
            this.button_showAllUsers.Size = new System.Drawing.Size(148, 36);
            this.button_showAllUsers.TabIndex = 1;
            this.button_showAllUsers.Text = "Show all users";
            this.button_showAllUsers.UseVisualStyleBackColor = false;
            this.button_showAllUsers.Click += new System.EventHandler(this.button_showAllUsers_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.panel_menu.Controls.Add(this.button_showAllUsers);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(728, 60);
            this.panel_menu.TabIndex = 2;
            // 
            // dataGridView_AllUsers
            // 
            this.dataGridView_AllUsers.AllowUserToDeleteRows = false;
            this.dataGridView_AllUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_AllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_AllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllUsers.Location = new System.Drawing.Point(12, 76);
            this.dataGridView_AllUsers.Name = "dataGridView_AllUsers";
            this.dataGridView_AllUsers.RowHeadersVisible = false;
            this.dataGridView_AllUsers.Size = new System.Drawing.Size(704, 266);
            this.dataGridView_AllUsers.TabIndex = 3;
            // 
            // AutorentAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(728, 354);
            this.Controls.Add(this.dataGridView_AllUsers);
            this.Controls.Add(this.panel_menu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AutorentAdmin";
            this.Text = "Autorent - admin";
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_showAllUsers;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.DataGridView dataGridView_AllUsers;
    }
}