namespace AutoRent
{
    partial class CarCard
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
            this.label_carCategory = new System.Windows.Forms.Label();
            this.label_carPriceOriginal = new System.Windows.Forms.Label();
            this.button_seeAvailability = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_carImage = new System.Windows.Forms.PictureBox();
            this.label_carPriceSale = new System.Windows.Forms.Label();
            this.label_carSaleAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label_carName
            // 
            this.label_carName.AutoSize = true;
            this.label_carName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carName.Location = new System.Drawing.Point(212, 16);
            this.label_carName.Name = "label_carName";
            this.label_carName.Size = new System.Drawing.Size(230, 29);
            this.label_carName.TabIndex = 1;
            this.label_carName.Text = "Car brand + model";
            // 
            // label_carCategory
            // 
            this.label_carCategory.AutoSize = true;
            this.label_carCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carCategory.Location = new System.Drawing.Point(212, 54);
            this.label_carCategory.Name = "label_carCategory";
            this.label_carCategory.Size = new System.Drawing.Size(92, 25);
            this.label_carCategory.TabIndex = 2;
            this.label_carCategory.Text = "Category";
            // 
            // label_carPriceOriginal
            // 
            this.label_carPriceOriginal.AutoSize = true;
            this.label_carPriceOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carPriceOriginal.Location = new System.Drawing.Point(212, 92);
            this.label_carPriceOriginal.Name = "label_carPriceOriginal";
            this.label_carPriceOriginal.Size = new System.Drawing.Size(126, 25);
            this.label_carPriceOriginal.TabIndex = 3;
            this.label_carPriceOriginal.Text = "Original price";
            // 
            // button_seeAvailability
            // 
            this.button_seeAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.button_seeAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_seeAvailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.button_seeAvailability.Location = new System.Drawing.Point(497, 54);
            this.button_seeAvailability.Name = "button_seeAvailability";
            this.button_seeAvailability.Size = new System.Drawing.Size(236, 63);
            this.button_seeAvailability.TabIndex = 4;
            this.button_seeAvailability.Text = "See availability";
            this.button_seeAvailability.UseVisualStyleBackColor = false;
            this.button_seeAvailability.Click += new System.EventHandler(this.button_seeAvailability_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 143);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox_carImage
            // 
            this.pictureBox_carImage.BackColor = System.Drawing.Color.White;
            this.pictureBox_carImage.Image = global::AutoRent.Properties.Resources.car;
            this.pictureBox_carImage.Location = new System.Drawing.Point(17, 16);
            this.pictureBox_carImage.Name = "pictureBox_carImage";
            this.pictureBox_carImage.Size = new System.Drawing.Size(169, 112);
            this.pictureBox_carImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_carImage.TabIndex = 6;
            this.pictureBox_carImage.TabStop = false;
            // 
            // label_carPriceSale
            // 
            this.label_carPriceSale.AutoSize = true;
            this.label_carPriceSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carPriceSale.Location = new System.Drawing.Point(358, 92);
            this.label_carPriceSale.Name = "label_carPriceSale";
            this.label_carPriceSale.Size = new System.Drawing.Size(99, 25);
            this.label_carPriceSale.TabIndex = 7;
            this.label_carPriceSale.Text = "Sale price";
            // 
            // label_carSaleAmount
            // 
            this.label_carSaleAmount.AutoSize = true;
            this.label_carSaleAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_carSaleAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carSaleAmount.Location = new System.Drawing.Point(660, 16);
            this.label_carSaleAmount.Name = "label_carSaleAmount";
            this.label_carSaleAmount.Size = new System.Drawing.Size(73, 29);
            this.label_carSaleAmount.TabIndex = 8;
            this.label_carSaleAmount.Text = "-15%";
            // 
            // CarCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.Controls.Add(this.label_carSaleAmount);
            this.Controls.Add(this.label_carPriceSale);
            this.Controls.Add(this.pictureBox_carImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_seeAvailability);
            this.Controls.Add(this.label_carPriceOriginal);
            this.Controls.Add(this.label_carCategory);
            this.Controls.Add(this.label_carName);
            this.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.Name = "CarCard";
            this.Size = new System.Drawing.Size(766, 143);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_carName;
        private System.Windows.Forms.Label label_carCategory;
        private System.Windows.Forms.Label label_carPriceOriginal;
        private System.Windows.Forms.Button button_seeAvailability;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_carImage;
        private System.Windows.Forms.Label label_carPriceSale;
        private System.Windows.Forms.Label label_carSaleAmount;
    }
}
