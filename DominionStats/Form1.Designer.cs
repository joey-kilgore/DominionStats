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
            this.currentRoundLabel = new System.Windows.Forms.Label();
            this.currentRoundTracker = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.TreasureGeneratedThisRoundChartLabel = new System.Windows.Forms.Label();
            this.VictoryPointsPurchasedChartLabel = new System.Windows.Forms.Label();
            this.DeckSizeChartLabel1 = new System.Windows.Forms.Label();
            this.DeckSizeChartLabel2 = new System.Windows.Forms.Label();
            this.PlayerNumberChartLabel = new System.Windows.Forms.Label();
            this.Player1ChartLabel = new System.Windows.Forms.Label();
            this.Player2ChartLabel = new System.Windows.Forms.Label();
            this.Player3ChartLabel = new System.Windows.Forms.Label();
            this.Player4ChartLabel = new System.Windows.Forms.Label();
            this.TreasureGeneratedP1 = new System.Windows.Forms.TextBox();
            this.VictoryPointsP1 = new System.Windows.Forms.TextBox();
            this.DeckSizeP1 = new System.Windows.Forms.TextBox();
            this.DeckSizeP2 = new System.Windows.Forms.TextBox();
            this.VictoryPointsP2 = new System.Windows.Forms.TextBox();
            this.TreasureGeneratedP2 = new System.Windows.Forms.TextBox();
            this.DeckSizeP3 = new System.Windows.Forms.TextBox();
            this.VictoryPointsP3 = new System.Windows.Forms.TextBox();
            this.TreasureGeneratedP3 = new System.Windows.Forms.TextBox();
            this.DeckSizeP4 = new System.Windows.Forms.TextBox();
            this.VictoryPointsP4 = new System.Windows.Forms.TextBox();
            this.TreasureGeneratedP4 = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.GameOver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentRoundLabel
            // 
            this.currentRoundLabel.AutoSize = true;
            this.currentRoundLabel.Location = new System.Drawing.Point(12, 9);
            this.currentRoundLabel.Name = "currentRoundLabel";
            this.currentRoundLabel.Size = new System.Drawing.Size(76, 13);
            this.currentRoundLabel.TabIndex = 4;
            this.currentRoundLabel.Text = "Current Round";
            // 
            // currentRoundTracker
            // 
            this.currentRoundTracker.AutoSize = true;
            this.currentRoundTracker.Location = new System.Drawing.Point(94, 9);
            this.currentRoundTracker.Name = "currentRoundTracker";
            this.currentRoundTracker.Size = new System.Drawing.Size(13, 13);
            this.currentRoundTracker.TabIndex = 5;
            this.currentRoundTracker.Text = "0";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(245, 313);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // TreasureGeneratedThisRoundChartLabel
            // 
            this.TreasureGeneratedThisRoundChartLabel.AutoSize = true;
            this.TreasureGeneratedThisRoundChartLabel.Location = new System.Drawing.Point(49, 97);
            this.TreasureGeneratedThisRoundChartLabel.Name = "TreasureGeneratedThisRoundChartLabel";
            this.TreasureGeneratedThisRoundChartLabel.Size = new System.Drawing.Size(160, 13);
            this.TreasureGeneratedThisRoundChartLabel.TabIndex = 7;
            this.TreasureGeneratedThisRoundChartLabel.Text = "Treasure Generated This Round";
            // 
            // VictoryPointsPurchasedChartLabel
            // 
            this.VictoryPointsPurchasedChartLabel.AutoSize = true;
            this.VictoryPointsPurchasedChartLabel.Location = new System.Drawing.Point(84, 142);
            this.VictoryPointsPurchasedChartLabel.Name = "VictoryPointsPurchasedChartLabel";
            this.VictoryPointsPurchasedChartLabel.Size = new System.Drawing.Size(125, 13);
            this.VictoryPointsPurchasedChartLabel.TabIndex = 8;
            this.VictoryPointsPurchasedChartLabel.Text = "Victory Points Purchased";
            // 
            // DeckSizeChartLabel1
            // 
            this.DeckSizeChartLabel1.AutoSize = true;
            this.DeckSizeChartLabel1.Location = new System.Drawing.Point(101, 186);
            this.DeckSizeChartLabel1.Name = "DeckSizeChartLabel1";
            this.DeckSizeChartLabel1.Size = new System.Drawing.Size(108, 13);
            this.DeckSizeChartLabel1.TabIndex = 9;
            this.DeckSizeChartLabel1.Text = "Change In Deck Size";
            // 
            // DeckSizeChartLabel2
            // 
            this.DeckSizeChartLabel2.AutoSize = true;
            this.DeckSizeChartLabel2.Location = new System.Drawing.Point(12, 199);
            this.DeckSizeChartLabel2.Name = "DeckSizeChartLabel2";
            this.DeckSizeChartLabel2.Size = new System.Drawing.Size(197, 13);
            this.DeckSizeChartLabel2.TabIndex = 10;
            this.DeckSizeChartLabel2.Text = "(positive for bought negative for trashed)";
            // 
            // PlayerNumberChartLabel
            // 
            this.PlayerNumberChartLabel.AutoSize = true;
            this.PlayerNumberChartLabel.Location = new System.Drawing.Point(133, 57);
            this.PlayerNumberChartLabel.Name = "PlayerNumberChartLabel";
            this.PlayerNumberChartLabel.Size = new System.Drawing.Size(76, 13);
            this.PlayerNumberChartLabel.TabIndex = 11;
            this.PlayerNumberChartLabel.Text = "Player Number";
            // 
            // Player1ChartLabel
            // 
            this.Player1ChartLabel.AutoSize = true;
            this.Player1ChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1ChartLabel.Location = new System.Drawing.Point(251, 52);
            this.Player1ChartLabel.Name = "Player1ChartLabel";
            this.Player1ChartLabel.Size = new System.Drawing.Size(19, 20);
            this.Player1ChartLabel.TabIndex = 12;
            this.Player1ChartLabel.Text = "1";
            // 
            // Player2ChartLabel
            // 
            this.Player2ChartLabel.AutoSize = true;
            this.Player2ChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2ChartLabel.Location = new System.Drawing.Point(324, 52);
            this.Player2ChartLabel.Name = "Player2ChartLabel";
            this.Player2ChartLabel.Size = new System.Drawing.Size(19, 20);
            this.Player2ChartLabel.TabIndex = 13;
            this.Player2ChartLabel.Text = "2";
            // 
            // Player3ChartLabel
            // 
            this.Player3ChartLabel.AutoSize = true;
            this.Player3ChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3ChartLabel.Location = new System.Drawing.Point(404, 52);
            this.Player3ChartLabel.Name = "Player3ChartLabel";
            this.Player3ChartLabel.Size = new System.Drawing.Size(19, 20);
            this.Player3ChartLabel.TabIndex = 14;
            this.Player3ChartLabel.Text = "3";
            // 
            // Player4ChartLabel
            // 
            this.Player4ChartLabel.AutoSize = true;
            this.Player4ChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4ChartLabel.Location = new System.Drawing.Point(480, 52);
            this.Player4ChartLabel.Name = "Player4ChartLabel";
            this.Player4ChartLabel.Size = new System.Drawing.Size(19, 20);
            this.Player4ChartLabel.TabIndex = 15;
            this.Player4ChartLabel.Text = "4";
            // 
            // TreasureGeneratedP1
            // 
            this.TreasureGeneratedP1.Location = new System.Drawing.Point(245, 94);
            this.TreasureGeneratedP1.Name = "TreasureGeneratedP1";
            this.TreasureGeneratedP1.Size = new System.Drawing.Size(25, 20);
            this.TreasureGeneratedP1.TabIndex = 16;
            // 
            // VictoryPointsP1
            // 
            this.VictoryPointsP1.Location = new System.Drawing.Point(245, 139);
            this.VictoryPointsP1.Name = "VictoryPointsP1";
            this.VictoryPointsP1.Size = new System.Drawing.Size(25, 20);
            this.VictoryPointsP1.TabIndex = 17;
            // 
            // DeckSizeP1
            // 
            this.DeckSizeP1.Location = new System.Drawing.Point(245, 186);
            this.DeckSizeP1.Name = "DeckSizeP1";
            this.DeckSizeP1.Size = new System.Drawing.Size(25, 20);
            this.DeckSizeP1.TabIndex = 18;
            // 
            // DeckSizeP2
            // 
            this.DeckSizeP2.Location = new System.Drawing.Point(318, 186);
            this.DeckSizeP2.Name = "DeckSizeP2";
            this.DeckSizeP2.Size = new System.Drawing.Size(25, 20);
            this.DeckSizeP2.TabIndex = 21;
            // 
            // VictoryPointsP2
            // 
            this.VictoryPointsP2.Location = new System.Drawing.Point(318, 139);
            this.VictoryPointsP2.Name = "VictoryPointsP2";
            this.VictoryPointsP2.Size = new System.Drawing.Size(25, 20);
            this.VictoryPointsP2.TabIndex = 20;
            // 
            // TreasureGeneratedP2
            // 
            this.TreasureGeneratedP2.Location = new System.Drawing.Point(318, 94);
            this.TreasureGeneratedP2.Name = "TreasureGeneratedP2";
            this.TreasureGeneratedP2.Size = new System.Drawing.Size(25, 20);
            this.TreasureGeneratedP2.TabIndex = 19;
            // 
            // DeckSizeP3
            // 
            this.DeckSizeP3.Location = new System.Drawing.Point(398, 186);
            this.DeckSizeP3.Name = "DeckSizeP3";
            this.DeckSizeP3.Size = new System.Drawing.Size(25, 20);
            this.DeckSizeP3.TabIndex = 24;
            // 
            // VictoryPointsP3
            // 
            this.VictoryPointsP3.Location = new System.Drawing.Point(398, 139);
            this.VictoryPointsP3.Name = "VictoryPointsP3";
            this.VictoryPointsP3.Size = new System.Drawing.Size(25, 20);
            this.VictoryPointsP3.TabIndex = 23;
            // 
            // TreasureGeneratedP3
            // 
            this.TreasureGeneratedP3.Location = new System.Drawing.Point(398, 94);
            this.TreasureGeneratedP3.Name = "TreasureGeneratedP3";
            this.TreasureGeneratedP3.Size = new System.Drawing.Size(25, 20);
            this.TreasureGeneratedP3.TabIndex = 22;
            // 
            // DeckSizeP4
            // 
            this.DeckSizeP4.Location = new System.Drawing.Point(474, 186);
            this.DeckSizeP4.Name = "DeckSizeP4";
            this.DeckSizeP4.Size = new System.Drawing.Size(25, 20);
            this.DeckSizeP4.TabIndex = 27;
            // 
            // VictoryPointsP4
            // 
            this.VictoryPointsP4.Location = new System.Drawing.Point(474, 139);
            this.VictoryPointsP4.Name = "VictoryPointsP4";
            this.VictoryPointsP4.Size = new System.Drawing.Size(25, 20);
            this.VictoryPointsP4.TabIndex = 26;
            // 
            // TreasureGeneratedP4
            // 
            this.TreasureGeneratedP4.Location = new System.Drawing.Point(474, 94);
            this.TreasureGeneratedP4.Name = "TreasureGeneratedP4";
            this.TreasureGeneratedP4.Size = new System.Drawing.Size(25, 20);
            this.TreasureGeneratedP4.TabIndex = 25;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(173, 8);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FileNameLabel.TabIndex = 28;
            this.FileNameLabel.Text = "File Name:";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(236, 8);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fileNameTextBox.TabIndex = 29;
            // 
            // GameOver
            // 
            this.GameOver.Location = new System.Drawing.Point(369, 313);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(75, 23);
            this.GameOver.TabIndex = 30;
            this.GameOver.Text = "Game Over";
            this.GameOver.UseVisualStyleBackColor = true;
            this.GameOver.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 456);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.DeckSizeP4);
            this.Controls.Add(this.VictoryPointsP4);
            this.Controls.Add(this.TreasureGeneratedP4);
            this.Controls.Add(this.DeckSizeP3);
            this.Controls.Add(this.VictoryPointsP3);
            this.Controls.Add(this.TreasureGeneratedP3);
            this.Controls.Add(this.DeckSizeP2);
            this.Controls.Add(this.VictoryPointsP2);
            this.Controls.Add(this.TreasureGeneratedP2);
            this.Controls.Add(this.DeckSizeP1);
            this.Controls.Add(this.VictoryPointsP1);
            this.Controls.Add(this.TreasureGeneratedP1);
            this.Controls.Add(this.Player4ChartLabel);
            this.Controls.Add(this.Player3ChartLabel);
            this.Controls.Add(this.Player2ChartLabel);
            this.Controls.Add(this.Player1ChartLabel);
            this.Controls.Add(this.PlayerNumberChartLabel);
            this.Controls.Add(this.DeckSizeChartLabel2);
            this.Controls.Add(this.DeckSizeChartLabel1);
            this.Controls.Add(this.VictoryPointsPurchasedChartLabel);
            this.Controls.Add(this.TreasureGeneratedThisRoundChartLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.currentRoundTracker);
            this.Controls.Add(this.currentRoundLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentRoundLabel;
        private System.Windows.Forms.Label currentRoundTracker;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label TreasureGeneratedThisRoundChartLabel;
        private System.Windows.Forms.Label VictoryPointsPurchasedChartLabel;
        private System.Windows.Forms.Label DeckSizeChartLabel1;
        private System.Windows.Forms.Label DeckSizeChartLabel2;
        private System.Windows.Forms.Label PlayerNumberChartLabel;
        private System.Windows.Forms.Label Player1ChartLabel;
        private System.Windows.Forms.Label Player2ChartLabel;
        private System.Windows.Forms.Label Player3ChartLabel;
        private System.Windows.Forms.Label Player4ChartLabel;
        private System.Windows.Forms.TextBox TreasureGeneratedP1;
        private System.Windows.Forms.TextBox VictoryPointsP1;
        private System.Windows.Forms.TextBox DeckSizeP1;
        private System.Windows.Forms.TextBox DeckSizeP2;
        private System.Windows.Forms.TextBox VictoryPointsP2;
        private System.Windows.Forms.TextBox TreasureGeneratedP2;
        private System.Windows.Forms.TextBox DeckSizeP3;
        private System.Windows.Forms.TextBox VictoryPointsP3;
        private System.Windows.Forms.TextBox TreasureGeneratedP3;
        private System.Windows.Forms.TextBox DeckSizeP4;
        private System.Windows.Forms.TextBox VictoryPointsP4;
        private System.Windows.Forms.TextBox TreasureGeneratedP4;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button GameOver;
    }
}

