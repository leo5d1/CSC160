using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace NumberGuessingGame
{
    public partial class NumberGuess : Form
    {
        Random random = new Random();

        List<Label> lblResults = new List<Label>();
        List<PictureBox> picResults = new List<PictureBox>();

        int answer = 0;
        int numGuess = 0;
        int intRandomMax = 0;

        private void InitializeGame()
        {
            lblResults.Add(label1);
            lblResults.Add(label2);
            lblResults.Add(label3);
            lblResults.Add(label4);
            lblResults.Add(label5);

            picResults.Add(pictureBox1);
            picResults.Add(pictureBox2);
            picResults.Add(pictureBox3);
            picResults.Add(pictureBox4);
            picResults.Add(pictureBox5);
        }

        private void ResetGame()
        {
            foreach (Label label in lblResults)
            {
                label.Text = "";
            }

            foreach (PictureBox pictureBox in picResults)
            {
                pictureBox.Image = null;
            }

            txtGuess.Enabled = false;
            txtGuess.Text = "00";
            tblResults.Enabled = true;
            btnStart.Enabled = true;
            btnStart.Text = "Start";
            lblRange.Text = "";

            numGuess = 0;
        }

        private void StartGame()
        {
            answer = random.Next(1, intRandomMax + 1);

            txtGuess.Enabled = true;

            btnStart.Text = "Reset";

            lblRange.Text = "Range: 1 - " + intRandomMax;
            
            Controls.Add(lblRange);
        }

        private void GameWon()
        {
            txtGuess.Enabled = false;
            MessageBox.Show("You Won!");
        }

        private void GameLost()
        {
            txtGuess.Enabled = false;
            MessageBox.Show("You Lost. Try Again");
        }

        public NumberGuess()
        {
            InitializeComponent();
            InitializeGame();
            ResetGame();
        }

        private void NumberGuess_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                StartGame();
            }
            else
            {
                ResetGame();
            }
        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbEasy = (RadioButton)sender;
            if (rbEasy.Checked)
            {
                intRandomMax = 10;
            }
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbMedium = (RadioButton)sender;
            if (rbMedium.Checked)
            {
                intRandomMax = 50;
            }
        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbHard = (RadioButton)sender;
            if (rbHard.Checked)
            {
                intRandomMax = 100;
            }
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sGuess = txtGuess.Text;
                int iGuess = int.Parse(sGuess);

                numGuess++;
                
                if (iGuess == answer)
                {
                    lblResults[numGuess - 1].Text = sGuess + " correct!";
                    lblResults[numGuess - 1].ForeColor = Color.Green;
                    picResults[numGuess - 1].Image = Properties.Resources.correct_icon;
                    GameWon();
                }
                else
                {
                    string highLow;
                    if (iGuess > answer)
                    {
                        highLow = "Too High";
                    }
                    else
                    {
                        highLow = "Too Low";
                    }

                    lblResults[numGuess - 1].Text = highLow;
                    lblResults[numGuess - 1].ForeColor = Color.Red;
                    picResults[numGuess - 1].Image = Properties.Resources.incorrect_icon;

                    if (numGuess == 5)
                    {
                        GameLost();
                    }
                }
            }
        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
