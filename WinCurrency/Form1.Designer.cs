namespace WinCurrency
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMonthMinRate = new System.Windows.Forms.Label();
            this.tbxMonthMinRate = new System.Windows.Forms.TextBox();
            this.lblHYearMinRate = new System.Windows.Forms.Label();
            this.tbxHYearMinRate = new System.Windows.Forms.TextBox();
            this.listCurrency = new System.Windows.Forms.ListBox();
            this.tbxMonthMinDate = new System.Windows.Forms.TextBox();
            this.tbxHYearMinDate = new System.Windows.Forms.TextBox();
            this.lblToday = new System.Windows.Forms.Label();
            this.tbxTodayRate = new System.Windows.Forms.TextBox();
            this.tbxTodayDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMonthMinRate
            // 
            this.lblMonthMinRate.AutoSize = true;
            this.lblMonthMinRate.Location = new System.Drawing.Point(47, 161);
            this.lblMonthMinRate.Name = "lblMonthMinRate";
            this.lblMonthMinRate.Size = new System.Drawing.Size(33, 12);
            this.lblMonthMinRate.TabIndex = 1;
            this.lblMonthMinRate.Text = "label1";
            // 
            // tbxMonthMinRate
            // 
            this.tbxMonthMinRate.Location = new System.Drawing.Point(124, 151);
            this.tbxMonthMinRate.Name = "tbxMonthMinRate";
            this.tbxMonthMinRate.Size = new System.Drawing.Size(100, 22);
            this.tbxMonthMinRate.TabIndex = 2;
            // 
            // lblHYearMinRate
            // 
            this.lblHYearMinRate.AutoSize = true;
            this.lblHYearMinRate.Location = new System.Drawing.Point(49, 204);
            this.lblHYearMinRate.Name = "lblHYearMinRate";
            this.lblHYearMinRate.Size = new System.Drawing.Size(33, 12);
            this.lblHYearMinRate.TabIndex = 3;
            this.lblHYearMinRate.Text = "label2";
            // 
            // tbxHYearMinRate
            // 
            this.tbxHYearMinRate.Location = new System.Drawing.Point(124, 204);
            this.tbxHYearMinRate.Name = "tbxHYearMinRate";
            this.tbxHYearMinRate.Size = new System.Drawing.Size(100, 22);
            this.tbxHYearMinRate.TabIndex = 4;
            // 
            // listCurrency
            // 
            this.listCurrency.FormattingEnabled = true;
            this.listCurrency.ItemHeight = 12;
            this.listCurrency.Location = new System.Drawing.Point(49, 12);
            this.listCurrency.Name = "listCurrency";
            this.listCurrency.Size = new System.Drawing.Size(120, 64);
            this.listCurrency.TabIndex = 5;
            this.listCurrency.SelectedIndexChanged += new System.EventHandler(this.listCurrency_SelectedIndexChanged);
            // 
            // tbxMonthMinDate
            // 
            this.tbxMonthMinDate.Location = new System.Drawing.Point(230, 151);
            this.tbxMonthMinDate.Name = "tbxMonthMinDate";
            this.tbxMonthMinDate.Size = new System.Drawing.Size(100, 22);
            this.tbxMonthMinDate.TabIndex = 6;
            // 
            // tbxHYearMinDate
            // 
            this.tbxHYearMinDate.Location = new System.Drawing.Point(230, 201);
            this.tbxHYearMinDate.Name = "tbxHYearMinDate";
            this.tbxHYearMinDate.Size = new System.Drawing.Size(100, 22);
            this.tbxHYearMinDate.TabIndex = 7;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(49, 116);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(33, 12);
            this.lblToday.TabIndex = 8;
            this.lblToday.Text = "label1";
            // 
            // tbxTodayRate
            // 
            this.tbxTodayRate.Location = new System.Drawing.Point(124, 105);
            this.tbxTodayRate.Name = "tbxTodayRate";
            this.tbxTodayRate.Size = new System.Drawing.Size(100, 22);
            this.tbxTodayRate.TabIndex = 9;
            // 
            // tbxTodayDate
            // 
            this.tbxTodayDate.Location = new System.Drawing.Point(230, 105);
            this.tbxTodayDate.Name = "tbxTodayDate";
            this.tbxTodayDate.Size = new System.Drawing.Size(100, 22);
            this.tbxTodayDate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 373);
            this.Controls.Add(this.tbxTodayDate);
            this.Controls.Add(this.tbxTodayRate);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.tbxHYearMinDate);
            this.Controls.Add(this.tbxMonthMinDate);
            this.Controls.Add(this.listCurrency);
            this.Controls.Add(this.tbxHYearMinRate);
            this.Controls.Add(this.lblHYearMinRate);
            this.Controls.Add(this.tbxMonthMinRate);
            this.Controls.Add(this.lblMonthMinRate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMonthMinRate;
        private System.Windows.Forms.TextBox tbxMonthMinRate;
        private System.Windows.Forms.Label lblHYearMinRate;
        private System.Windows.Forms.TextBox tbxHYearMinRate;
        private System.Windows.Forms.ListBox listCurrency;
        private System.Windows.Forms.TextBox tbxMonthMinDate;
        private System.Windows.Forms.TextBox tbxHYearMinDate;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.TextBox tbxTodayRate;
        private System.Windows.Forms.TextBox tbxTodayDate;
    }
}

