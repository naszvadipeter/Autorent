namespace AutoRent
{
    partial class RentalCard
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
            this.label_carName = new System.Windows.Forms.Label();
            this.label_fromDate = new System.Windows.Forms.Label();
            this.label_toDate = new System.Windows.Forms.Label();
            this.label_totalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_carName
            // 
            this.label_carName.AutoSize = true;
            this.label_carName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carName.Location = new System.Drawing.Point(15, 26);
            this.label_carName.Name = "label_carName";
            this.label_carName.Size = new System.Drawing.Size(44, 25);
            this.label_carName.TabIndex = 0;
            this.label_carName.Text = "Car";
            // 
            // label_fromDate
            // 
            this.label_fromDate.AutoSize = true;
            this.label_fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_fromDate.Location = new System.Drawing.Point(405, 26);
            this.label_fromDate.Name = "label_fromDate";
            this.label_fromDate.Size = new System.Drawing.Size(100, 25);
            this.label_fromDate.TabIndex = 1;
            this.label_fromDate.Text = "From date";
            // 
            // label_toDate
            // 
            this.label_toDate.AutoSize = true;
            this.label_toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_toDate.Location = new System.Drawing.Point(600, 26);
            this.label_toDate.Name = "label_toDate";
            this.label_toDate.Size = new System.Drawing.Size(79, 25);
            this.label_toDate.TabIndex = 2;
            this.label_toDate.Text = "To date";
            // 
            // label_totalCost
            // 
            this.label_totalCost.AutoSize = true;
            this.label_totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_totalCost.Location = new System.Drawing.Point(865, 26);
            this.label_totalCost.Name = "label_totalCost";
            this.label_totalCost.Size = new System.Drawing.Size(97, 25);
            this.label_totalCost.TabIndex = 3;
            this.label_totalCost.Text = "Total cost";
            // 
            // RentalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.Controls.Add(this.label_totalCost);
            this.Controls.Add(this.label_toDate);
            this.Controls.Add(this.label_fromDate);
            this.Controls.Add(this.label_carName);
            this.Name = "RentalCard";
            this.Size = new System.Drawing.Size(1020, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_carName;
        private System.Windows.Forms.Label label_fromDate;
        private System.Windows.Forms.Label label_toDate;
        private System.Windows.Forms.Label label_totalCost;
    }
}
