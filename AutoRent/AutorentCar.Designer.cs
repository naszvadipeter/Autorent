namespace AutoRent
{
    partial class AutorentCar
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
            this.monthCalendar_date = new System.Windows.Forms.MonthCalendar();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox_carImage = new System.Windows.Forms.PictureBox();
            this.panel_imageBackground = new System.Windows.Forms.Panel();
            this.label_carSaleAmount = new System.Windows.Forms.Label();
            this.label_carPriceSale = new System.Windows.Forms.Label();
            this.label_carPriceOriginal = new System.Windows.Forms.Label();
            this.label_carCategory = new System.Windows.Forms.Label();
            this.label_carName = new System.Windows.Forms.Label();
            this.button_reserve = new System.Windows.Forms.Button();
            this.label_dailyPrice = new System.Windows.Forms.Label();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.label_carTotalPrice = new System.Windows.Forms.Label();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.textBox_unavailableDays = new System.Windows.Forms.TextBox();
            this.label_unavailableDays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carImage)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar_date
            // 
            this.monthCalendar_date.Location = new System.Drawing.Point(482, 146);
            this.monthCalendar_date.Name = "monthCalendar_date";
            this.monthCalendar_date.TabIndex = 0;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_back.ForeColor = System.Drawing.Color.Black;
            this.button_back.Location = new System.Drawing.Point(937, 22);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(133, 63);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox_carImage
            // 
            this.pictureBox_carImage.BackColor = System.Drawing.Color.White;
            this.pictureBox_carImage.Image = global::AutoRent.Properties.Resources.car;
            this.pictureBox_carImage.Location = new System.Drawing.Point(65, 64);
            this.pictureBox_carImage.Name = "pictureBox_carImage";
            this.pictureBox_carImage.Size = new System.Drawing.Size(293, 181);
            this.pictureBox_carImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_carImage.TabIndex = 8;
            this.pictureBox_carImage.TabStop = false;
            // 
            // panel_imageBackground
            // 
            this.panel_imageBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.panel_imageBackground.Location = new System.Drawing.Point(35, 35);
            this.panel_imageBackground.Name = "panel_imageBackground";
            this.panel_imageBackground.Size = new System.Drawing.Size(357, 238);
            this.panel_imageBackground.TabIndex = 7;
            // 
            // label_carSaleAmount
            // 
            this.label_carSaleAmount.AutoSize = true;
            this.label_carSaleAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label_carSaleAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carSaleAmount.Location = new System.Drawing.Point(281, 407);
            this.label_carSaleAmount.Name = "label_carSaleAmount";
            this.label_carSaleAmount.Size = new System.Drawing.Size(73, 29);
            this.label_carSaleAmount.TabIndex = 13;
            this.label_carSaleAmount.Text = "-15%";
            this.label_carSaleAmount.Visible = false;
            // 
            // label_carPriceSale
            // 
            this.label_carPriceSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_carPriceSale.AutoSize = true;
            this.label_carPriceSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carPriceSale.Location = new System.Drawing.Point(255, 446);
            this.label_carPriceSale.Name = "label_carPriceSale";
            this.label_carPriceSale.Size = new System.Drawing.Size(132, 29);
            this.label_carPriceSale.TabIndex = 12;
            this.label_carPriceSale.Text = "Sale price";
            this.label_carPriceSale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_carPriceSale.Visible = false;
            // 
            // label_carPriceOriginal
            // 
            this.label_carPriceOriginal.AutoSize = true;
            this.label_carPriceOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carPriceOriginal.Location = new System.Drawing.Point(60, 446);
            this.label_carPriceOriginal.Name = "label_carPriceOriginal";
            this.label_carPriceOriginal.Size = new System.Drawing.Size(172, 29);
            this.label_carPriceOriginal.TabIndex = 11;
            this.label_carPriceOriginal.Text = "Original price";
            // 
            // label_carCategory
            // 
            this.label_carCategory.AutoSize = true;
            this.label_carCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carCategory.Location = new System.Drawing.Point(60, 337);
            this.label_carCategory.Name = "label_carCategory";
            this.label_carCategory.Size = new System.Drawing.Size(92, 25);
            this.label_carCategory.TabIndex = 10;
            this.label_carCategory.Text = "Category";
            // 
            // label_carName
            // 
            this.label_carName.AutoSize = true;
            this.label_carName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carName.Location = new System.Drawing.Point(60, 299);
            this.label_carName.Name = "label_carName";
            this.label_carName.Size = new System.Drawing.Size(230, 29);
            this.label_carName.TabIndex = 9;
            this.label_carName.Text = "Car brand + model";
            // 
            // button_reserve
            // 
            this.button_reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(89)))), ((int)(((byte)(78)))));
            this.button_reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.button_reserve.Location = new System.Drawing.Point(694, 434);
            this.button_reserve.Name = "button_reserve";
            this.button_reserve.Size = new System.Drawing.Size(313, 71);
            this.button_reserve.TabIndex = 14;
            this.button_reserve.Text = "Make reservation";
            this.button_reserve.UseVisualStyleBackColor = false;
            // 
            // label_dailyPrice
            // 
            this.label_dailyPrice.AutoSize = true;
            this.label_dailyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dailyPrice.Location = new System.Drawing.Point(60, 407);
            this.label_dailyPrice.Name = "label_dailyPrice";
            this.label_dailyPrice.Size = new System.Drawing.Size(126, 29);
            this.label_dailyPrice.TabIndex = 17;
            this.label_dailyPrice.Text = "Daily price";
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_totalPrice.Location = new System.Drawing.Point(477, 431);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(128, 29);
            this.label_totalPrice.TabIndex = 18;
            this.label_totalPrice.Text = "Total price";
            // 
            // label_carTotalPrice
            // 
            this.label_carTotalPrice.AutoSize = true;
            this.label_carTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_carTotalPrice.Location = new System.Drawing.Point(477, 476);
            this.label_carTotalPrice.Name = "label_carTotalPrice";
            this.label_carTotalPrice.Size = new System.Drawing.Size(139, 29);
            this.label_carTotalPrice.TabIndex = 19;
            this.label_carTotalPrice.Text = "Total price";
            // 
            // textBox_info
            // 
            this.textBox_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.textBox_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_info.Location = new System.Drawing.Point(416, 35);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.Size = new System.Drawing.Size(497, 88);
            this.textBox_info.TabIndex = 21;
            this.textBox_info.Text = "To reserve the car, select the desired days. You can only select continuous days " +
    "up to a maximum of 7. Avoid unavailable days.";
            // 
            // textBox_unavailableDays
            // 
            this.textBox_unavailableDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.textBox_unavailableDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_unavailableDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_unavailableDays.Location = new System.Drawing.Point(825, 196);
            this.textBox_unavailableDays.Multiline = true;
            this.textBox_unavailableDays.Name = "textBox_unavailableDays";
            this.textBox_unavailableDays.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_unavailableDays.Size = new System.Drawing.Size(161, 203);
            this.textBox_unavailableDays.TabIndex = 22;
            this.textBox_unavailableDays.Text = "No results";
            // 
            // label_unavailableDays
            // 
            this.label_unavailableDays.AutoSize = true;
            this.label_unavailableDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_unavailableDays.Location = new System.Drawing.Point(803, 146);
            this.label_unavailableDays.Name = "label_unavailableDays";
            this.label_unavailableDays.Size = new System.Drawing.Size(195, 29);
            this.label_unavailableDays.TabIndex = 23;
            this.label_unavailableDays.Text = "Unavailable days";
            // 
            // AutorentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1092, 544);
            this.Controls.Add(this.label_unavailableDays);
            this.Controls.Add(this.textBox_unavailableDays);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.label_carTotalPrice);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.label_dailyPrice);
            this.Controls.Add(this.button_reserve);
            this.Controls.Add(this.label_carSaleAmount);
            this.Controls.Add(this.label_carPriceSale);
            this.Controls.Add(this.label_carPriceOriginal);
            this.Controls.Add(this.label_carCategory);
            this.Controls.Add(this.label_carName);
            this.Controls.Add(this.pictureBox_carImage);
            this.Controls.Add(this.panel_imageBackground);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.monthCalendar_date);
            this.Name = "AutorentCar";
            this.Text = "AutorentCar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_carImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar_date;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox_carImage;
        private System.Windows.Forms.Panel panel_imageBackground;
        private System.Windows.Forms.Label label_carSaleAmount;
        private System.Windows.Forms.Label label_carPriceSale;
        private System.Windows.Forms.Label label_carPriceOriginal;
        private System.Windows.Forms.Label label_carCategory;
        private System.Windows.Forms.Label label_carName;
        private System.Windows.Forms.Button button_reserve;
        private System.Windows.Forms.Label label_dailyPrice;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.Label label_carTotalPrice;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.TextBox textBox_unavailableDays;
        private System.Windows.Forms.Label label_unavailableDays;
    }
}