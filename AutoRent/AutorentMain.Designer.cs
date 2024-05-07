namespace AutoRent
{
    partial class AutorentMain
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_previousRents = new System.Windows.Forms.Button();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.button_showSale = new System.Windows.Forms.Button();
            this.button_showAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel_cars = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.panel_menu.Controls.Add(this.button_logout);
            this.panel_menu.Controls.Add(this.button_previousRents);
            this.panel_menu.Controls.Add(this.comboBox_category);
            this.panel_menu.Controls.Add(this.label_category);
            this.panel_menu.Controls.Add(this.button_showSale);
            this.panel_menu.Controls.Add(this.button_showAll);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(286, 544);
            this.panel_menu.TabIndex = 1;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.ForeColor = System.Drawing.Color.Black;
            this.button_logout.Location = new System.Drawing.Point(34, 463);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(222, 56);
            this.button_logout.TabIndex = 6;
            this.button_logout.Text = "Log out";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_previousRents
            // 
            this.button_previousRents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.button_previousRents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_previousRents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.button_previousRents.Location = new System.Drawing.Point(34, 328);
            this.button_previousRents.Name = "button_previousRents";
            this.button_previousRents.Size = new System.Drawing.Size(222, 90);
            this.button_previousRents.TabIndex = 4;
            this.button_previousRents.Text = "Show my previous rents";
            this.button_previousRents.UseVisualStyleBackColor = false;
            this.button_previousRents.Click += new System.EventHandler(this.button_previousRents_Click);
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(34, 212);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(222, 37);
            this.comboBox_category.TabIndex = 3;
            this.comboBox_category.SelectedIndexChanged += new System.EventHandler(this.comboBox_category_SelectedIndexChanged);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_category.Location = new System.Drawing.Point(29, 171);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(162, 29);
            this.label_category.TabIndex = 2;
            this.label_category.Text = "Category filter";
            // 
            // button_showSale
            // 
            this.button_showSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.button_showSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_showSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.button_showSale.Location = new System.Drawing.Point(34, 96);
            this.button_showSale.Name = "button_showSale";
            this.button_showSale.Size = new System.Drawing.Size(222, 56);
            this.button_showSale.TabIndex = 1;
            this.button_showSale.Text = "Show sale";
            this.button_showSale.UseVisualStyleBackColor = false;
            this.button_showSale.Click += new System.EventHandler(this.button_showSale_Click);
            // 
            // button_showAll
            // 
            this.button_showAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.button_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_showAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.button_showAll.Location = new System.Drawing.Point(34, 34);
            this.button_showAll.Name = "button_showAll";
            this.button_showAll.Size = new System.Drawing.Size(222, 56);
            this.button_showAll.TabIndex = 0;
            this.button_showAll.Text = "Show all";
            this.button_showAll.UseVisualStyleBackColor = false;
            this.button_showAll.Click += new System.EventHandler(this.button_showAll_Click);
            // 
            // flowLayoutPanel_cars
            // 
            this.flowLayoutPanel_cars.AutoScroll = true;
            this.flowLayoutPanel_cars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.flowLayoutPanel_cars.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel_cars.Location = new System.Drawing.Point(292, 0);
            this.flowLayoutPanel_cars.Name = "flowLayoutPanel_cars";
            this.flowLayoutPanel_cars.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flowLayoutPanel_cars.Size = new System.Drawing.Size(800, 544);
            this.flowLayoutPanel_cars.TabIndex = 2;
            // 
            // AutorentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1092, 544);
            this.Controls.Add(this.flowLayoutPanel_cars);
            this.Controls.Add(this.panel_menu);
            this.Name = "AutorentMain";
            this.Text = "Autorent - main";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_cars;
        private System.Windows.Forms.Button button_showAll;
        private System.Windows.Forms.Button button_showSale;
        private System.Windows.Forms.Button button_previousRents;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Button button_logout;
    }
}