namespace KoinKekko
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            priceMax = new Label();
            priceMin = new Label();
            label2 = new Label();
            volumeMax = new Label();
            volumeMin = new Label();
            BullishEnd = new Label();
            bullishStart = new Label();
            bearishStart = new Label();
            bearishEnd = new Label();
            label5 = new Label();
            buy = new Label();
            sell = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            endDate = new Label();
            startDate = new Label();
            price = new GroupBox();
            volume = new GroupBox();
            bullish = new GroupBox();
            label6 = new Label();
            bearish = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            buySell = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            price.SuspendLayout();
            volume.SuspendLayout();
            bullish.SuspendLayout();
            bearish.SuspendLayout();
            buySell.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(874, 449);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(200, 64);
            button1.TabIndex = 0;
            button1.Text = "Fetch Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 151);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(851, 362);
            dataGridView1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 45);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 84);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 4;
            label1.Text = "0";
            // 
            // priceMax
            // 
            priceMax.AutoSize = true;
            priceMax.Location = new Point(8, 50);
            priceMax.Margin = new Padding(4, 0, 4, 0);
            priceMax.Name = "priceMax";
            priceMax.Size = new Size(45, 25);
            priceMax.TabIndex = 5;
            priceMax.Text = "Max";
            // 
            // priceMin
            // 
            priceMin.AutoSize = true;
            priceMin.Location = new Point(8, 90);
            priceMin.Margin = new Padding(4, 0, 4, 0);
            priceMin.Name = "priceMin";
            priceMin.Size = new Size(42, 25);
            priceMin.TabIndex = 6;
            priceMin.Text = "Min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 7;
            label2.Text = "0";
            // 
            // volumeMax
            // 
            volumeMax.AutoSize = true;
            volumeMax.Location = new Point(8, 45);
            volumeMax.Margin = new Padding(4, 0, 4, 0);
            volumeMax.Name = "volumeMax";
            volumeMax.Size = new Size(45, 25);
            volumeMax.TabIndex = 8;
            volumeMax.Text = "Max";
            // 
            // volumeMin
            // 
            volumeMin.AutoSize = true;
            volumeMin.Location = new Point(8, 84);
            volumeMin.Margin = new Padding(4, 0, 4, 0);
            volumeMin.Name = "volumeMin";
            volumeMin.Size = new Size(42, 25);
            volumeMin.TabIndex = 9;
            volumeMin.Text = "Min";
            // 
            // BullishEnd
            // 
            BullishEnd.AutoSize = true;
            BullishEnd.Location = new Point(8, 84);
            BullishEnd.Margin = new Padding(4, 0, 4, 0);
            BullishEnd.Name = "BullishEnd";
            BullishEnd.Size = new Size(42, 25);
            BullishEnd.TabIndex = 10;
            BullishEnd.Text = "End";
            // 
            // bullishStart
            // 
            bullishStart.AutoSize = true;
            bullishStart.Location = new Point(8, 45);
            bullishStart.Margin = new Padding(4, 0, 4, 0);
            bullishStart.Name = "bullishStart";
            bullishStart.Size = new Size(48, 25);
            bullishStart.TabIndex = 11;
            bullishStart.Text = "Start";
            // 
            // bearishStart
            // 
            bearishStart.AutoSize = true;
            bearishStart.Location = new Point(8, 45);
            bearishStart.Margin = new Padding(4, 0, 4, 0);
            bearishStart.Name = "bearishStart";
            bearishStart.Size = new Size(48, 25);
            bearishStart.TabIndex = 12;
            bearishStart.Text = "Start";
            // 
            // bearishEnd
            // 
            bearishEnd.AutoSize = true;
            bearishEnd.Location = new Point(8, 79);
            bearishEnd.Margin = new Padding(4, 0, 4, 0);
            bearishEnd.Name = "bearishEnd";
            bearishEnd.Size = new Size(42, 25);
            bearishEnd.TabIndex = 13;
            bearishEnd.Text = "End";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 45);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 14;
            label5.Text = "0";
            // 
            // buy
            // 
            buy.AutoSize = true;
            buy.Location = new Point(8, 39);
            buy.Margin = new Padding(4, 0, 4, 0);
            buy.Name = "buy";
            buy.Size = new Size(41, 25);
            buy.TabIndex = 15;
            buy.Text = "Buy";
            // 
            // sell
            // 
            sell.AutoSize = true;
            sell.Location = new Point(8, 79);
            sell.Margin = new Padding(4, 0, 4, 0);
            sell.Name = "sell";
            sell.Size = new Size(39, 25);
            sell.TabIndex = 16;
            sell.Text = "Sell";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(874, 318);
            dateTimePicker1.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(874, 398);
            dateTimePicker2.Margin = new Padding(4, 4, 4, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(299, 31);
            dateTimePicker2.TabIndex = 18;
            // 
            // endDate
            // 
            endDate.AutoSize = true;
            endDate.Location = new Point(874, 369);
            endDate.Margin = new Padding(4, 0, 4, 0);
            endDate.Name = "endDate";
            endDate.Size = new Size(88, 25);
            endDate.TabIndex = 19;
            endDate.Text = "End Date:";
            // 
            // startDate
            // 
            startDate.AutoSize = true;
            startDate.Location = new Point(874, 289);
            startDate.Margin = new Padding(4, 0, 4, 0);
            startDate.Name = "startDate";
            startDate.Size = new Size(94, 25);
            startDate.TabIndex = 20;
            startDate.Text = "Start Date:";
            // 
            // price
            // 
            price.Controls.Add(priceMax);
            price.Controls.Add(priceMin);
            price.Controls.Add(label1);
            price.Controls.Add(label2);
            price.Location = new Point(15, 4);
            price.Margin = new Padding(4, 4, 4, 4);
            price.Name = "price";
            price.Padding = new Padding(4, 4, 4, 4);
            price.Size = new Size(200, 140);
            price.TabIndex = 21;
            price.TabStop = false;
            price.Text = "Price";
            // 
            // volume
            // 
            volume.Controls.Add(volumeMax);
            volume.Controls.Add(volumeMin);
            volume.Controls.Add(label3);
            volume.Controls.Add(label4);
            volume.Location = new Point(235, 4);
            volume.Margin = new Padding(4, 4, 4, 4);
            volume.Name = "volume";
            volume.Padding = new Padding(4, 4, 4, 4);
            volume.Size = new Size(311, 140);
            volume.TabIndex = 22;
            volume.TabStop = false;
            volume.Text = "Volume";
            // 
            // bullish
            // 
            bullish.Controls.Add(label6);
            bullish.Controls.Add(bullishStart);
            bullish.Controls.Add(BullishEnd);
            bullish.Controls.Add(label5);
            bullish.Location = new Point(554, 4);
            bullish.Margin = new Padding(4, 4, 4, 4);
            bullish.Name = "bullish";
            bullish.Padding = new Padding(4, 4, 4, 4);
            bullish.Size = new Size(312, 140);
            bullish.TabIndex = 23;
            bullish.TabStop = false;
            bullish.Text = "Bullish";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 84);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 26;
            label6.Text = "0";
            // 
            // bearish
            // 
            bearish.Controls.Add(label8);
            bearish.Controls.Add(label7);
            bearish.Controls.Add(bearishStart);
            bearish.Controls.Add(bearishEnd);
            bearish.Location = new Point(874, 15);
            bearish.Margin = new Padding(4, 4, 4, 4);
            bearish.Name = "bearish";
            bearish.Padding = new Padding(4, 4, 4, 4);
            bearish.Size = new Size(312, 129);
            bearish.TabIndex = 24;
            bearish.TabStop = false;
            bearish.Text = "Bearish";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 79);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(22, 25);
            label8.TabIndex = 26;
            label8.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 45);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 26;
            label7.Text = "0";
            // 
            // buySell
            // 
            buySell.Controls.Add(label10);
            buySell.Controls.Add(buy);
            buySell.Controls.Add(label9);
            buySell.Controls.Add(sell);
            buySell.Location = new Point(874, 152);
            buySell.Margin = new Padding(4, 4, 4, 4);
            buySell.Name = "buySell";
            buySell.Padding = new Padding(4, 4, 4, 4);
            buySell.Size = new Size(312, 129);
            buySell.TabIndex = 25;
            buySell.TabStop = false;
            buySell.Text = "Best buy then sell";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(56, 79);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(22, 25);
            label10.TabIndex = 27;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(56, 39);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(22, 25);
            label9.TabIndex = 26;
            label9.Text = "0";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 536);
            Controls.Add(buySell);
            Controls.Add(bearish);
            Controls.Add(bullish);
            Controls.Add(volume);
            Controls.Add(price);
            Controls.Add(startDate);
            Controls.Add(endDate);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            price.ResumeLayout(false);
            price.PerformLayout();
            volume.ResumeLayout(false);
            volume.PerformLayout();
            bullish.ResumeLayout(false);
            bullish.PerformLayout();
            bearish.ResumeLayout(false);
            bearish.PerformLayout();
            buySell.ResumeLayout(false);
            buySell.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label priceMax;
        private Label priceMin;
        private Label label2;
        private Label volumeMax;
        private Label volumeMin;
        private Label BullishEnd;
        private Label bullishStart;
        private Label bearishStart;
        private Label bearishEnd;
        private Label label5;
        private Label buy;
        private Label sell;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label endDate;
        private Label startDate;
        private GroupBox price;
        private GroupBox volume;
        private GroupBox bullish;
        private GroupBox bearish;
        private GroupBox buySell;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
