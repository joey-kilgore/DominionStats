using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DominionStats
{
    public partial class Form1 : Form
    {
        public int currentRound = 0;
        public bool fileCreated = false;
        public int[] deckSize = new int[5];
        public int[] victoryPoints = new int[5];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                deckSize[i] = 10;
                victoryPoints[i] = 3;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (!fileCreated)
            {
                createFile();
            }
            currentRound++;
            currentRoundTracker.Text = currentRound.ToString();
            addToCSVFile();
            clearTextBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void createFile()
        {
            string filePath = @"C:\Users\joeya\Desktop\Dominion\" + fileNameTextBox.Text + ".CSV";
            StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine("Round,Player 1,,,Player 2,,,Player 3,,,Player 4,,,");
            writer.WriteLine(",Treasure Generated, Total VP's, Deck Size,Treasure Generated, Total VP's, Deck Size,Treasure Generated, Total VP's, Deck Size,Treasure Generated, Total VP's, Deck Size,");
            writer.Close();
            fileCreated = true;
        }

        public void addToCSVFile()
        {
            string filePath = @"C:\Users\joeya\Desktop\Dominion\" + fileNameTextBox.Text + ".CSV";
            StreamWriter writer = new StreamWriter(filePath, true);
            try
            {
                deckSize[1] += Convert.ToInt32(DeckSizeP1.Text);
                deckSize[2] += Convert.ToInt32(DeckSizeP2.Text);
                deckSize[3] += Convert.ToInt32(DeckSizeP3.Text);
                deckSize[4] += Convert.ToInt32(DeckSizeP4.Text);
            }
            catch (Exception e) { }

            try
            {
                victoryPoints[1] += Convert.ToInt32(VictoryPointsP1.Text);
                victoryPoints[2] += Convert.ToInt32(VictoryPointsP2.Text);
                victoryPoints[3] += Convert.ToInt32(VictoryPointsP3.Text);
                victoryPoints[4] += Convert.ToInt32(VictoryPointsP4.Text);
            }
            catch (Exception e) { }

            writer.Write(currentRound + ",");
            writer.Write(TreasureGeneratedP1.Text + "," + victoryPoints[1] + "," + deckSize[1] + ",");
            writer.Write(TreasureGeneratedP2.Text + "," + victoryPoints[2] + "," + deckSize[2] + ",");
            writer.Write(TreasureGeneratedP3.Text + "," + victoryPoints[3] + "," + deckSize[3] + ",");
            writer.Write(TreasureGeneratedP4.Text + "," + victoryPoints[4] + "," + deckSize[4] + ",");
            writer.WriteLine();
            writer.Close();
        }

        public void clearTextBoxes()
        {
            TreasureGeneratedP1.Clear();
            TreasureGeneratedP2.Clear();
            TreasureGeneratedP3.Clear();
            TreasureGeneratedP4.Clear();
            VictoryPointsP1.Clear();
            VictoryPointsP2.Clear();
            VictoryPointsP3.Clear();
            VictoryPointsP4.Clear();
            DeckSizeP1.Clear();
            DeckSizeP2.Clear();
            DeckSizeP3.Clear();
            DeckSizeP4.Clear();
        }

        private void GameOver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
