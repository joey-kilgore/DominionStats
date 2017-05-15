namespace DominionStats
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.coinTotalLabel = new System.Windows.Forms.Label();
            this.coinTotalTextBox = new System.Windows.Forms.TextBox();
            this.victoryPointLabel = new System.Windows.Forms.Label();
            this.victoryPointTextBox = new System.Windows.Forms.TextBox();
            this.currentRoundLabel = new System.Windows.Forms.Label();
            this.currentRoundTracker = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // coinTotalLabel
            // 
            this.coinTotalLabel.AutoSize = true;
            this.coinTotalLabel.Location = new System.Drawing.Point(32, 104);
            this.coinTotalLabel.Name = "coinTotalLabel";
            this.coinTotalLabel.Size = new System.Drawing.Size(128, 13);
            this.coinTotalLabel.TabIndex = 0;
            this.coinTotalLabel.Text = "Coins Earned This Round";
            this.coinTotalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // coinTotalTextBox
            // 
            this.coinTotalTextBox.Location = new System.Drawing.Point(194, 104);
            this.coinTotalTextBox.Name = "coinTotalTextBox";
            this.coinTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.coinTotalTextBox.TabIndex = 1;
            // 
            // victoryPointLabel
            // 
            this.victoryPointLabel.AutoSize = true;
            this.victoryPointLabel.Location = new System.Drawing.Point(35, 142);
            this.victoryPointLabel.Name = "victoryPointLabel";
            this.victoryPointLabel.Size = new System.Drawing.Size(125, 13);
            this.victoryPointLabel.TabIndex = 2;
            this.victoryPointLabel.Text = "Victory Points Purchased";
            // 
            // victoryPointTextBox
            // 
            this.victoryPointTextBox.Location = new System.Drawing.Point(194, 142);
            this.victoryPointTextBox.Name = "victoryPointTextBox";
            this.victoryPointTextBox.Size = new System.Drawing.Size(100, 20);
            this.victoryPointTextBox.TabIndex = 3;
            // 
            // currentRoundLabel
            // 
            this.currentRoundLabel.AutoSize = true;
            this.currentRoundLabel.Location = new System.Drawing.Point(84, 67);
            this.currentRoundLabel.Name = "currentRoundLabel";
            this.currentRoundLabel.Size = new System.Drawing.Size(76, 13);
            this.currentRoundLabel.TabIndex = 4;
            this.currentRoundLabel.Text = "Current Round";
            // 
            // currentRoundTracker
            // 
            this.currentRoundTracker.AutoSize = true;
            this.currentRoundTracker.Location = new System.Drawing.Point(194, 67);
            this.currentRoundTracker.Name = "currentRoundTracker";
            this.currentRoundTracker.Size = new System.Drawing.Size(35, 13);
            this.currentRoundTracker.TabIndex = 5;
            this.currentRoundTracker.Text = "label1";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(277, 198);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.chart1.Series;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(59, 275);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(375, 169);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 456);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.currentRoundTracker);
            this.Controls.Add(this.currentRoundLabel);
            this.Controls.Add(this.victoryPointTextBox);
            this.Controls.Add(this.victoryPointLabel);
            this.Controls.Add(this.coinTotalTextBox);
            this.Controls.Add(this.coinTotalLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coinTotalLabel;
        private System.Windows.Forms.TextBox coinTotalTextBox;
        private System.Windows.Forms.Label victoryPointLabel;
        private System.Windows.Forms.TextBox victoryPointTextBox;
        private System.Windows.Forms.Label currentRoundLabel;
        private System.Windows.Forms.Label currentRoundTracker;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

