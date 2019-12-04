using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Global variables\\
        private readonly Random rnd = new Random();
        private int randomNumberOne;
        private int randomNumberTwo;
        private int score;
        private int time;

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Images\Jungle_Kids.jpg");
        }

        //Click event for all the radio buttons in the panel\\
        private void RadioBtn_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Start";

            var radioButtonSender = (RadioButton)sender;
            foreach (var rb in this.pnlButtons.Controls.OfType<RadioButton>())
            {
                var btnColour = rb == radioButtonSender ? "Green" : "Red";
                rb.BackgroundImage = Image.FromFile($@"Images\Button_{btnColour}_{(string)rb.Tag}.jpg");

                lblSum.Text = "Klik op start!";
                score = 0;
                lblScore.Text = Convert.ToString(score);
            }
        }

        //Click event for the start button\\
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (rbPlus.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne + randomNumberTwo))
                    {
                        score++;
                        lblScore.Text = Convert.ToString(score);
                        GenerateNumbers(1, 20, 1, 20);
                        lblSum.Text = $"{randomNumberOne}" + " + " + $"{randomNumberTwo}" + " =";
                    }
                    else
                    {
                        score--;
                        lblScore.Text = Convert.ToString(score);
                    }
                }

                if (btnStart.Text == "Start")
                {
                    GameCountDown.Enabled = true;
                    EndGame.Enabled = true;
                    time = 10;
                    GenerateNumbers(1, 20, 1, 20);
                    lblSum.Text = $"{randomNumberOne}" + " + " + $"{randomNumberTwo}" + " =";
                }
            }

            else if (rbMinus.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne - randomNumberTwo))
                    {
                        score++;
                        lblScore.Text = Convert.ToString(score);
                        GenerateNumbers(10, 20, 1, 10);
                        lblSum.Text = $"{randomNumberOne}" + " - " + $"{randomNumberTwo}" + " =";
                    }
                    else
                    {
                        score--;
                        lblScore.Text = Convert.ToString(score);
                    }
                }

                if (btnStart.Text == "Start")
                {
                    GameCountDown.Enabled = true;
                    EndGame.Enabled = true;
                    time = 10;
                    GenerateNumbers(10, 20, 1, 10);
                    lblSum.Text = $"{randomNumberOne}" + " - " + $"{randomNumberTwo}" + " =";
                }


            }

            else if (rbMultiply.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne * randomNumberTwo))
                    {
                        score++;
                        lblScore.Text = Convert.ToString(score);
                        GenerateNumbers(1, 10, 1, 10);
                        lblSum.Text = $"{randomNumberOne}" + " x " + $"{randomNumberTwo}" + " =";
                    }
                    else
                    {
                        score--;
                        lblScore.Text = Convert.ToString(score);
                    }
                }

                if (btnStart.Text == "Start")
                {
                    GameCountDown.Enabled = true;
                    EndGame.Enabled = true;
                    time = 10;
                    GenerateNumbers(1, 10, 1, 10);
                    lblSum.Text = $"{randomNumberOne}" + " x " + $"{randomNumberTwo}" + " =";
                }


            }

            else
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne / randomNumberTwo))
                    {
                        score++;
                        lblScore.Text = Convert.ToString(score);
                        GenerateNumbers(5, 10, 1, 5);
                        while (randomNumberOne % randomNumberTwo != 0)
                        {
                            GenerateNumbers(5, 10, 1, 5);
                        }
                        lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                    }
                    else
                    {
                        score--;
                        lblScore.Text = Convert.ToString(score);
                    }
                }

                if (btnStart.Text == "Start")
                {
                    GameCountDown.Enabled = true;
                    EndGame.Enabled = true;
                    time = 10;
                    GenerateNumbers(5, 10, 1, 5);
                    while (randomNumberOne % randomNumberTwo != 0)
                    {
                        GenerateNumbers(5, 10, 1, 5);
                    }
                    lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                }


            }
            btnStart.Text = "Controleer";
            tbAnswer.Clear();
        }

        //Method for creating two random numbers that are temporarily stored as two variables\\
        private void GenerateNumbers(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo)
        {
            randomNumberOne = rnd.Next(minValueOne, maxValueOne);
            randomNumberTwo = rnd.Next(minValueTwo, maxValueTwo);
        }

        private void TbAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnStart.PerformClick();
            }
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            if (rbPlus.Checked)
            {
                lblSum.Text = $"{randomNumberOne}" + " + " + $"{randomNumberTwo}" + " = " +
                              $"{randomNumberOne + randomNumberTwo}";
            }

            if (rbMinus.Checked)
            {
                lblSum.Text = $"{randomNumberOne}" + " - " + $"{randomNumberTwo}" + " = " +
                              $"{randomNumberOne - randomNumberTwo}";
            }

            if (rbMultiply.Checked)
            {
                lblSum.Text = $"{randomNumberOne}" + " x " + $"{randomNumberTwo}" + " = " +
                              $"{randomNumberOne * randomNumberTwo}";
            }

            if (rbDivide.Checked)
            {
                lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " = " +
                              $"{randomNumberOne / randomNumberTwo}";
            }
        }

        private void GameCountDown_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToString(time);
            time--;

        }

        private void EndGame_Tick(object sender, EventArgs e)
        {
            GameCountDown.Enabled = false;
            EndGame.Enabled = false;
            time = 10;
            MessageBox.Show($"De tijd is om. \n Je hebt {score} punten gehaald.");

        }
    }
}
// Getal x groter of kleiner dan y?
// Geen dubbele opgaves
// Muziek?
// Timers voor einde van de game