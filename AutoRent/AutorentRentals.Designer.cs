namespace AutoRent
{
    partial class AutorentRentals
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_content = new System.Windows.Forms.FlowLayoutPanel();
            this.label_carName = new System.Windows.Forms.Label();
            this.label_rentalStart = new System.Windows.Forms.Label();
            this.label_rentalEnd = new System.Windows.Forms.Label();
            this.label_totalCost = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.panel_header.Controls.Add(this.label_totalCost);
            this.panel_header.Controls.Add(this.label_rentalEnd);
            this.panel_header.Controls.Add(this.label_rentalStart);
            this.panel_header.Controls.Add(this.label_carName);
            this.panel_header.Location = new System.Drawing.Point(12, 12);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1068, 68);
            this.panel_header.TabIndex = 0;
            // 
            // flowLayoutPanel_content
            // 
            this.flowLayoutPanel_content.AutoScroll = true;
            this.flowLayoutPanel_content.Location = new System.Drawing.Point(12, 86);
            this.flowLayoutPanel_content.Name = "flowLayoutPanel_content";
            this.flowLayoutPanel_content.Size = new System.Drawing.Size(1068, 446);
            this.flowLayoutPanel_content.TabIndex = 1;
            // 
            // label_carName
            // 
            this.label_carName.AutoSize = true;
            this.label_carName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.label_carName.Location = new System.Drawing.Point(21, 22);
            this.label_carName.Name = "label_carName";
            this.label_carName.Size = new System.Drawing.Size(106, 25);
            this.label_carName.TabIndex = 0;
            this.label_carName.Text = "Car name";
            // 
            // label_rentalStart
            // 
            this.label_rentalStart.AutoSize = true;
            this.label_rentalStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rentalStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.label_rentalStart.Location = new System.Drawing.Point(401, 22);
            this.label_rentalStart.Name = "label_rentalStart";
            this.label_rentalStart.Size = new System.Drawing.Size(121, 25);
            this.label_rentalStart.TabIndex = 1;
            this.label_rentalStart.Text = "Rental start";
            // 
            // label_rentalEnd
            // 
            this.label_rentalEnd.AutoSize = true;
            this.label_rentalEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rentalEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.label_rentalEnd.Location = new System.Drawing.Point(591, 22);
            this.label_rentalEnd.Name = "label_rentalEnd";
            this.label_rentalEnd.Size = new System.Drawing.Size(115, 25);
            this.label_rentalEnd.TabIndex = 2;
            this.label_rentalEnd.Text = "Rental end";
            // 
            // label_totalCost
            // 
            this.label_totalCost.AutoSize = true;
            this.label_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_totalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.label_totalCost.Location = new System.Drawing.Point(860, 22);
            this.label_totalCost.Name = "label_totalCost";
            this.label_totalCost.Size = new System.Drawing.Size(107, 25);
            this.label_totalCost.TabIndex = 3;
            this.label_totalCost.Text = "Total cost";
            // 
            // AutorentRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1092, 544);
            this.Controls.Add(this.flowLayoutPanel_content);
            this.Controls.Add(this.panel_header);
            this.Name = "AutorentRentals";
            this.Text = "AutorentRentals";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_content;
        private System.Windows.Forms.Label label_carName;
        private System.Windows.Forms.Label label_totalCost;
        private System.Windows.Forms.Label label_rentalEnd;
        private System.Windows.Forms.Label label_rentalStart;
    }
}