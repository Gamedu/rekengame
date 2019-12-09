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
        private int time = 10;

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Images\Jungle_Kids.jpg");
            pnlUI.Visible = false;
        }

        //Click event for all the radio buttons in the panel\\
        private void RadioBtn_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Start";

            var radioButtonSender = (RadioButton)sender;
            foreach (var rb in this.pnlButtons.Controls.OfType<RadioButton>())
            {
                var btnColour = rb == radioButtonSender ? "Green" : "Red";
                rb.BackgroundImage = Image.FromFile($@"Images\Button_{btnColour}_{(string)rb.Tag}.png");

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
                        AfterFirstClick(1, 10, 1, 10, "+");
                    }
                    else
                    {
                        ScoreMinusOne();
                    }
                }

                if (btnStart.Text == "Start")
                {
                    FirstStartClick(1, 10, 1, 10, "+");
                }
            }

            else if (rbMinus.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne - randomNumberTwo))
                    {
                        AfterFirstClick(10, 20, 1, 10, "-");
                    }
                    else
                    {
                        ScoreMinusOne();
                    }
                }

                if (btnStart.Text == "Start")
                {
                    FirstStartClick(10, 20, 1, 10, "-");
                }


            }

            else if (rbMultiply.Checked)
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne * randomNumberTwo))
                    {
                        AfterFirstClick(1, 10, 1, 10, "x");
                    }
                    else
                    {
                        ScoreMinusOne();
                    }
                }

                if (btnStart.Text == "Start")
                {
                    tbAnswer.Clear();
                    FirstStartClick(1, 10, 1, 10, "x");
                }


            }

            else
            {
                if (btnStart.Text == "Controleer")
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne / randomNumberTwo))
                    {
                        AfterFirstClick(5, 10, 1, 5, "+");
                        while (randomNumberOne % randomNumberTwo != 0)
                        {
                            GenerateNumbers(5, 10, 1, 5);
                        }
                        lblSum.Text = $"{randomNumberOne}" + " : " + $"{randomNumberTwo}" + " =";
                    }
                    else
                    {
                        ScoreMinusOne();
                    }
                }

                if (btnStart.Text == "Start")
                {
                    FirstStartClick(5, 10, 1, 5, "+");
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



        private void FirstStartClick(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo, string type)
        {
            tbAnswer.Clear();
            lblTime.Visible = true;
            GameCountDown.Enabled = true;
            GenerateNumbers(minValueOne, maxValueOne, minValueTwo, maxValueTwo);
            lblSum.Text = $"{randomNumberOne}" + " " + type + " " + $"{randomNumberTwo}" + " =";
        }

        private void AfterFirstClick(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo, string type)
        {
            ScorePlusOne();
            GenerateNumbers(minValueOne, maxValueOne, minValueTwo, maxValueTwo);
            lblSum.Text = $"{randomNumberOne}" + " " + type + " " + $"{randomNumberTwo}" + " =";
        }

        private void ScorePlusOne()
        {
            score++;
            lblScore.Text = Convert.ToString(score);
        }

        private void ScoreMinusOne()
        {
            score--;
            lblScore.Text = Convert.ToString(score);
        }

        //Method for creating two random numbers that are temporarily stored as two variables\\
        private void GenerateNumbers(int minValueOne, int maxValueOne, int minValueTwo, int maxValueTwo)
        {
            randomNumberOne = rnd.Next(minValueOne, maxValueOne);
            randomNumberTwo = rnd.Next(minValueTwo, maxValueTwo);
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
            time--;
            lblTime.Text = Convert.ToString(time);
            if (time == 0)
            {
                GameCountDown.Enabled = false;
                lblTime.Visible = false;
                time = 10;
                lblTime.Text = Convert.ToString(time);
                rbPlus.Visible = true;
                rbMinus.Visible = true;
                rbMultiply.Visible = true;
                rbDivide.Visible = true;
                rbPlus.PerformClick();
                btnStart.Visible = true;
                pnlUI.Hide();
                pnlButtons.Visible = true;
                lblIntro.Visible = true;
                btnGo.Visible = true;
                MessageBox.Show($"De tijd is om. \n Je score is {score}");

            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            pnlUI.Visible = true;
            pnlUI.Top = 10;
            pnlUI.Left = 10;
            btnGo.Hide();
            lblIntro.Hide();
            pnlButtons.Hide();
            btnStart.PerformClick();
            this.ActiveControl = tbAnswer;
        }

        private void TmrControle_Tick_1(object sender, EventArgs e)
        {
            {
                if (rbPlus.Checked)
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne + randomNumberTwo))
                    {
                        btnStart.PerformClick();
                    }
                }

                if (rbMinus.Checked)
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne - randomNumberTwo))
                    {
                        btnStart.PerformClick();
                    }
                }

                if (rbMultiply.Checked)
                {
                    if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne * randomNumberTwo))
                    {
                        btnStart.PerformClick();
                    }
                }

                if (rbDivide.Checked)
                {
                    if (randomNumberOne != 0 && randomNumberTwo != 0)
                    {
                        if (Convert.ToString(tbAnswer.Text) == Convert.ToString(randomNumberOne / randomNumberTwo))
                        {
                            btnStart.PerformClick();
                        }
                    }
                }
            }
        }
    }
}